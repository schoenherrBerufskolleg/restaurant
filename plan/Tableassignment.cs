
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

namespace WinFormsApp1
{

    //public class Employee
    //{
    //public int EmployeeID { get; set; }
    //public string FirstName { get; set; }
    //public string LastName { get; set; }
    //public string Username { get; set; }
    //public string Password { get; set; }
    //public string Role { get; set; }

    //public List<Dictionary<string, object>> GetTips()
    //{
    //// query tips by employeeids
    //return new List<Dictionary<string, object>>();
    //}

    //public void AddTip(decimal amount)
    //{
    ////resp = save(EmployeeID, amount, Date.today())
    //}

    //public List<Dictionary<string, object>> GetTurnover(date)
    //{
    //// query paid orders by date
    //return new List<Dictionary<string, object>>();
    //}

    //public Orders GetOrders()
    //{
    //// query for orders status unpaid by employeeid
    //return new Orders();
    //}
    //}

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
        public Employee user;
        DatabaseManager manager = new DatabaseManager();
        public Form1(Employee user)
        {
            this.user = user;
            InitializeComponent();
            List<(decimal, DateTime)> old_tips = user.GetTips();
            Tabelle tipsTable = new Tabelle(this.TipsTable);
            tipsTable.initTable();
            foreach((decimal, DateTime) old_tip in old_tips)
            {
                tipsTable.addTipRow(old_tip.Item1, old_tip.Item2);
                //DateTime date = DateTime.Now;
                //tipsTable.addTipRow(0, date);
            }
            //TableLayoutPanel panel = (TableLayoutPanel)this.TipsTable;
            //panel.MaximumSize = new Size(700, 300);
            //panel.AutoScroll = false;
            //panel.AutoSize = true;
            //panel.RowCount = 0;
            //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            //panel.Controls.Add(new Label() { Text = "Amount" }, 0, 0);
            //panel.Controls.Add(new Label() { Text = "Date" }, 1, 0);
            //this.TipsTable = panel;

            TableLayoutPanel panel = (TableLayoutPanel)this.AssignedToYou;
            TabControl tabControl = (TabControl)this.tabControl1;
            {
                Dock = DockStyle.Fill; // Fill the entire form
            };

            // Create a new tab page and set its properties
            TabPage tabPage = new TabPage
            {
                Text = "Table Overview", // Set the tab page's title
            };

            // Add the tab page to the tab control
            tabControl.TabPages.Add(tabPage);

            // Create a FlowLayoutPanel and set its properties
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,    // Fill the entire tab page
                FlowDirection = FlowDirection.LeftToRight, // Arrange controls from left to right
                WrapContents = true,     // Wrap contents to the next row if necessary
                AutoScroll = true,       // Enable scrolling if the buttons exceed the tab page size
            };

            tabPage.Controls.Add(flowLayoutPanel);

            // Create 25 square buttons and add them to the FlowLayoutPanel
            for (int i = 0; i < 25; i++)
            {
                Button button = new Button
                {
                    Width = 50, // Set the width of the square button
                    Height = 50, // Set the height of the square button
                    Text = (i + 1).ToString(), // Set the button's text
                };

                // Add a click event handler for the button
                button.Click += OpenTableAssignmentForm;

                flowLayoutPanel.Controls.Add(button);
            }

            // Add the tab control to the form
            Controls.Add(tabControl);


        //panel.RowCount = 1;
        //panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
        //panel.Controls.Add(new Label() { Text = "Tablenumber" }, 0, 0);
        //panel.Controls.Add(new Label() { Text = "Contact No" }, 1, 0);
        //panel.Controls.Add(new Label() { Text = "Email ID" }, 2, 0);
        //this.AssignedToYou = panel;

        //panel.RowCount = panel.RowCount + 1;
        //panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        //panel.Controls.Add(new Label() { Text = "Street, City, State" }, 0, panel.RowCount - 1);
        //panel.Controls.Add(new Label() { Text = "888888888888" }, 1, panel.RowCount - 1);
        //panel.Controls.Add(new Label() { Text = "xxxxxxx@gmail.com" }, 2, panel.RowCount - 1);

        //manager.Connect();
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

        private void OpenTableAssignmentForm(object sender, EventArgs e)
        {

            // Create and show the SelectNameForm when a button is clicked
            Button clickedButton = (Button)sender;
            int tableNumber = Int32.Parse(clickedButton.Text);
            TableAssignment tableAssignmentForm = new TableAssignment(tableNumber);
            tableAssignmentForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {
                amount = Int32.Parse(this.AddTip.Text);
            }
            catch
            {
                Console.WriteLine("Es gab einen Error...");
                return;
            }

            //string query = "SELECT * FROM Employee WHERE Employee";

            //SQLiteDataRTipeader reader = manager.ExecuteQuery(query);

            Tabelle tipsTable = new Tabelle(this.TipsTable);
            TableLayoutPanel panel = (TableLayoutPanel)this.TipsTable;
            DateTime date = DateTime.Now;
            tipsTable.addTipRow(amount, date);
            user.AddTip(amount, date);
            //panel.RowCount = panel.RowCount + 1;
            //panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            //panel.Controls.Add(new Label() { Text = id.ToString() }, 0, panel.RowCount);
            //panel.Controls.Add(new Label() { Text = name }, 1, panel.RowCount);
            //this.TipsTable = panel;
        }

        private void TipsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tipsview_Click(object sender, EventArgs e)
        {

        }
    }
}