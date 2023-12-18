using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class PaymentForm : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        List<OrderInfo> activeOrders;
        DatabaseManager databaseManager = new DatabaseManager();
        Employee currentEmployee;
        TableAssignment tableAssignmentForm;
        public PaymentForm(List<OrderInfo> activeOrders, Employee currentEmployee, TableAssignment tableAssignmentForm)
        {
            this.activeOrders = activeOrders;
            InitializeComponent();
            fillOpenOrderList();
            this.currentEmployee = currentEmployee;
            this.tableAssignmentForm = tableAssignmentForm;
        }

        private void fillOpenOrderList()
        {
            foreach (var order in activeOrders)
            {
                this.OpenOrdersCheckedListBox.Items.Add(order);
            }
        }

        private void CloseOrdersButton_Click(object sender, EventArgs e)
        {
            decimal totalPrice = this.GetTotal();
            decimal paidAmount = this.AmountPaidNumberbox.Value;
            List<OrderInfo> orders = new List<OrderInfo>();
            if(paidAmount >= totalPrice)
            {
                foreach (var order in this.OpenOrdersCheckedListBox.CheckedItems)
                {
                    OrderInfo orderInfo = (OrderInfo)order;
                    this.payOrder(orderInfo);
                    orders.Add(orderInfo);
                }
                if(paidAmount > totalPrice)
                {
                    this.currentEmployee.AddTip(paidAmount - totalPrice, DateTime.Now);
                    MessageBox.Show("Added " + (paidAmount - totalPrice) + "€ as a Tip for " + this.currentEmployee.FirstName + " " + this.currentEmployee.LastName, "Added Tip", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult result = MessageBox.Show("Added Tip. Print Receipt?", "Added Tip. Print Receipt?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    OnYesClicked(orders);
                }
                this.tableAssignmentForm.fetchActiveOrders();
                this.Close();
            }
        }

        private void OpenOrdersCheckedListBox_CheckedChanged(object sender, EventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                this.TotalSumLabel.Text = "Total: " + this.GetTotal().ToString() + " €";
            });
        }

        private decimal GetOrderInfoPrice(OrderInfo orderinfo)
        {
            decimal total = 0;
            databaseManager.Connect();
            string query = "SELECT Price FROM OrderItem a JOIN MenuItem b ON a.ItemID = b.ItemID WHERE OrderId = " + orderinfo.orderId;
            SQLiteDataReader reader = databaseManager.ExecuteQuery(query);
            while (reader.Read())
            {
                total += reader.GetDecimal(0);
            }
            reader.Close();
            databaseManager.Disconnect();
            return total;
        }

        private decimal GetTotal()
        {
            decimal total = 0;
            foreach (var item in this.OpenOrdersCheckedListBox.CheckedItems)
            {
                OrderInfo orderinfo = (OrderInfo)item;
                total += this.GetOrderInfoPrice(orderinfo);
            }
            return total;
        }

        private void payOrder(OrderInfo orderinfo)
        {
            databaseManager.Connect();
            string query = "UPDATE OrderInfo set Status = \'closed\' WHERE OrderId = " + orderinfo.orderId;
            int result = databaseManager.ExecuteCommand(query);
            databaseManager.Disconnect();
        }

        private void PrintBitmap(Bitmap bitmap)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            };

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void OnYesClicked(List<OrderInfo> orders)
        {
            using (Bitmap bitmap = new Bitmap(600, 2000))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font font = new Font("Arial", 12))
                    {
                        graphics.Clear(Color.White);
                        foreach(OrderInfo order in orders)
                        {
                            graphics.DrawString("RECHNUNG", font, Brushes.Black, new PointF(10, 10));
                            graphics.DrawString(order.orderDate + " Tisch Nr:" + order.orderId, font, Brushes.Black, new PointF(10, 30));
                            int y = 50;
                            (List<MenuItem>, decimal) touple = fetchOrderedItems(order.orderId);
                            foreach(MenuItem item in touple.Item1)
                            {
                                graphics.DrawString(item.name + " " + item.price + "€", font, Brushes.Black, new PointF(10, y));
                                y+=20;
                            }
                            y += 20;
                            graphics.DrawString("Total: " + touple.Item2 + "€", font, Brushes.Black, new PointF(10, y));

                        }
                    }
                }

                PrintBitmap(bitmap);
            }

            Console.WriteLine("PDF created successfully.");
        }
        private (List<MenuItem>,decimal) fetchOrderedItems(int orderInfoId)
        {
            List<MenuItem> res = new List<MenuItem>();
            decimal total = 0;
            databaseManager.Connect();
            string query = "SELECT OrderItemId, ItemName, Price FROM OrderItem a JOIN MenuItem b ON a.ItemID = b.ItemID WHERE OrderId = " + orderInfoId;
            SQLiteDataReader reader = databaseManager.ExecuteQuery(query);
            while (reader.Read())
            {
                res.Add(new MenuItem(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2)));
                total += reader.GetDecimal(2);
            }
            reader.Close();
            databaseManager.Disconnect();
            return (res, total);
        }
    }
}
