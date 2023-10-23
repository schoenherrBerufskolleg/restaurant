using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using RestaurantApp;
using System.Data.SQLite;
using System.Data;

namespace WinFormsApp1
{

    
    //public class TableAssignment
    //{
    //public int AssignmentID { get; set; }
    //public int EmployeeID { get; set; }
    //public int TableNumber { get; set; }
    //public DateTime AssignmentDate { get; set; }

    //private Order GetUnpaidOrder()
    //{
    //// query for unpaid oders by tablenumber
    //return new List[Order()];
    //}

    //public string GetTableInfo()
    //{
    //// query for unpaid oders by tablenumber
    //return string.Empty;
    //}

    //public void ChangeTable(newTableNumber)
    //{
    //// get orders -> GetUnpaidOrder
    //// update all oders with new tablenumber
    //// query for tableinfo by number and set status to free
    //}

    //public void CreateInvoice(List[OrderItem], oderItems)
    //{
    //// update status of oder to "about to be paid or so"
    //// get orderitem itemid and query for prices
    //// create invoice element with zero paid and current date
    //}

    //public Order RemoveOrder()
    //{

    //// Implementation
    //return new Order();
    //}

    //public void PayInvoice(decimal amount, int invoiceid)
    //{
    //// update paidamount on invoice
    //// query for invoices with same orderid
    //// if all paid query and update status of oder
    //}

    //public void ChangeEmployee(employeeid)
    //{
    //// update tableassignment 
    //// Getunpaidorders update all orders
    //}
    //}

    //public class Order
    //{
    //public int OrderID { get; set; }
    //public int TableNumber { get; set; }
    //public int EmployeeID { get; set; }
    //public DateTime OrderDate { get; set; }
    //public string Status { get; set; }

    //public int GetCurrentTableAssignment()
    //{
    //// query for table by tablenumber

    //// Implementation
    //return 0;
    //}

    //public List<Order> GetAllOrderItems()
    //{
    //// query for all orders
    //return new List<Order>();
    //}

    //public List<OrderItem> GetOrderItems()
    //{
    //// query for oder items by orderid
    //return new List<OrderItem>();
    //}
    //}

    //public class OrderItem
    //{
    //public int OrderItemID { get; set; }
    //public int OrderID { get; set; }
    //public int ItemID { get; set; }
    //public string SpecialInstructions { get; set; }

    //public string GetMenuInfo()
    //{
    //// query for Menu item and return info
    //// Implementation
    //return string.Empty;
    //}

    //public int GetPrice()
    //{
    //// query for Menu item and return only price
    //// Implementation
    //return 0;
    //}
    //}
    public partial class Form1 : Form
    {

        DatabaseManager manager = new DatabaseManager();
        public Form1()
        {
            InitializeComponent();
            TableLayoutPanel panel = (TableLayoutPanel)this.TipsTable;
            panel.MaximumSize = new Size(700, 300);
            panel.AutoScroll = false;
            panel.AutoSize = true;
            panel.RowCount = 0;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panel.Controls.Add(new Label() { Text = "Amount" }, 0, 0);
            panel.Controls.Add(new Label() { Text = "Date" }, 1, 0);
            this.TipsTable = panel;

            panel = (TableLayoutPanel)this.AssignedToYou;
            panel.RowCount = 1;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panel.Controls.Add(new Label() { Text = "Tablenumber" }, 0, 0);
            panel.Controls.Add(new Label() { Text = "Contact No" }, 1, 0);
            panel.Controls.Add(new Label() { Text = "Email ID" }, 2, 0);
            this.AssignedToYou = panel;

            panel.RowCount = panel.RowCount + 1;
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panel.Controls.Add(new Label() { Text = "Street, City, State" }, 0, panel.RowCount - 1);
            panel.Controls.Add(new Label() { Text = "888888888888" }, 1, panel.RowCount - 1);
            panel.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 2, panel.RowCount - 1);

            manager.Connect();
            //string command = "INSERT INTO Employee (FirstName, LastName, Username, password, Role) VALUES(\'Maik\', \'B�sert\', \'Nova Mane\', \'test123\', \'Waiter\')";
        }

        private void AssignedToYou_Paint(object sender, PaintEventArgs e)
        {
            //TableLayoutPanel panel = (TableLayoutPanel)this.AssignedToYou;
            //panel.ColumnCount = 3;
            //panel.RowCount = 1;
            //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            ////////panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            //panel.Controls.Add(new Label() { Text = "Address" }, 1, 0);
            //panel.Controls.Add(new Label() { Text = "Contact No" }, 2, 0);
            //panel.Controls.Add(new Label() { Text = "Email ID" }, 3, 0);
            //this.AssignedToYou = panel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.AddTip.Text;
            TableLayoutPanel panel = (TableLayoutPanel)this.TipsTable;
            int width = panel.Size.Width;
            int height = panel.Size.Height;
            string query = "SELECT * FROM Employee";

            SQLiteDataReader reader = manager.ExecuteQuery(query);
            int id = 0;
            string name = "";
            while (reader.Read())
            {
                id = reader.GetInt32(0);
                name = reader.GetString(1); 

                Console.WriteLine($"ID: {id}, Name: {name}");
            }
            if (height > 150 && !panel.AutoScroll)
            {
                panel.AutoScroll = true;
}
                panel.RowCount = panel.RowCount + 1;
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            panel.Controls.Add(new Label() { Text = id.ToString() }, 0, panel.RowCount);
            panel.Controls.Add(new Label() { Text = name }, 1, panel.RowCount);
            this.TipsTable = panel;
        }

        private void TipsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tipsview_Click(object sender, EventArgs e)
        {

        }
    }
}