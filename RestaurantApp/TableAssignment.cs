using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{

    public partial class TableAssignment : Form
    {
        private class NameWithId
        {
            public string name;
            public int id;
            public NameWithId(string name, int id)
            {
                this.name = name;
                this.id = id;
            }

            public override string ToString()
            {
                return this.name;
            }
        }

        private class OrderItem
        {
            public int orderItemId;
            public int orderId;
            public int itemId;
            public string name;
            public string annotation;

            public OrderItem(int orderItemId, int orderId, string annotation, string name)
            {
                this.orderItemId = orderItemId;
                this.orderId = orderId;
                this.name = name;
                this.annotation = annotation;
            }

            public override string ToString()
            {
                return this.name;
            }
        }
        int tableNumber = 0;
        List<Employee> employees = new List<Employee>();
        DatabaseManager databaseManager = new DatabaseManager();
        Employee assignedEmployee;
        public TableAssignment(int tableNumber)
        {
            this.tableNumber = tableNumber;
            InitializeComponent();
            getEmployees();
            getAssignment();
        }
        /**
         * Assigns the selected employee to the current table
         */
        private void AssignButton_Click(object sender, EventArgs e)
        {
            if (this.EmployeeListBox.SelectedItem != null)
            {
                NameWithId selectedEmployee = (NameWithId)this.EmployeeListBox.SelectedItem;
                Employee newAssign = employees.FirstOrDefault(employee => employee.EmployeeID == selectedEmployee.id);
                string command = "UPDATE TableAssignment SET EmployeeID = " + selectedEmployee.id + " WHERE TableNumber = " + this.tableNumber;
                databaseManager.Connect();
                if (databaseManager.ExecuteCommand(command) > 0)
                {
                    getAssignment();

                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                databaseManager.Disconnect();
            }
            else
            {
                MessageBox.Show("Please select an Employee to assign first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /**
         * (Temporary) Method that fetches all the Employees from the Database
         */
        private void getEmployees()
        {
            databaseManager.Connect();
            string query = "SELECT EmployeeId, FirstName, LastName, Username, Role FROM Employee";
            SQLiteDataReader reader = databaseManager.ExecuteQuery(query);
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string firstName = reader.GetString(1);
                string lastName = reader.GetString(2);
                string username = reader.GetString(3);
                string role = reader.GetString(4);
                employees.Add(new Employee(id, firstName, lastName, username, role));
            }
            reader.Close();
            databaseManager.Disconnect();
        }
        /**
         * Fetches the assignment of the current table number from the database
         */
        private void getAssignment()
        {
            if (this.tableNumber != 0)
            {
                databaseManager.Connect();
                string query = "SELECT EmployeeId FROM TableAssignment WHERE TableNumber = " + tableNumber;
                SQLiteDataReader reader = databaseManager.ExecuteQuery(query);
                while (reader.Read())
                {
                    int id = (int)reader.GetInt32(0);
                    this.assignedEmployee = employees.FirstOrDefault(employee => employee.EmployeeID == id);
                }
                reader.Close();
                databaseManager.Disconnect();
                updateView();
            }
        }
        /**
         * Updates the view with the new values
         */
        private void updateView()
        {
            if (this.assignedEmployee != null)
            {
                this.AssignedEmployee.Text = this.assignedEmployee.FirstName + " " + this.assignedEmployee.LastName;
                this.showOrderMenu();
            }
            if (this.employees.Count > 0 && this.EmployeeListBox.Items.Count == 0)
            {
                foreach (Employee x in this.employees)
                {
                    NameWithId name = new NameWithId(x.FirstName + " " + x.LastName, x.EmployeeID);
                    this.EmployeeListBox.Items.Add(name);
                }

            }
        }

        private void showOrderMenu()
        {
            this.OrderMenu.Show();
            this.fetchMenuItems();
            this.fetchActiveOrders();
        }

        private void fetchMenuItems()
        {
            databaseManager.Connect();
            string query = "SELECT * FROM MenuItem";
            SQLiteDataReader reader = databaseManager.ExecuteQuery(query);
            while (reader.Read())
            {
                this.MenuListBox.Items.Add(new MenuItem(reader.GetInt32(0), reader.GetString(1) + " " + reader.GetDecimal(2) + "€", reader.GetDecimal(2)));
            }
            reader.Close();
            databaseManager.Disconnect();
        }

        public void fetchActiveOrders()
        {
            this.OrderInfoListBox.Items.Clear();
            databaseManager.Connect();
            string query = "SELECT OrderId, OrderDate, Status FROM OrderInfo WHERE TableNumber = " + this.tableNumber;
            SQLiteDataReader reader = databaseManager.ExecuteQuery(query);
            while (reader.Read())
            {
                this.OrderInfoListBox.Items.Add(new OrderInfo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            reader.Close();
            databaseManager.Disconnect();
        }

        private void fetchOrderedItems(int orderInfoId)
        {
            this.OrderedItemsListBox.Items.Clear();
            decimal total = 0;
            databaseManager.Connect();
            string query = "SELECT OrderItemId, OrderId, SpecialInstructions, ItemName, Price FROM OrderItem a JOIN MenuItem b ON a.ItemID = b.ItemID WHERE OrderId = " + orderInfoId;
            SQLiteDataReader reader = databaseManager.ExecuteQuery(query);
            while (reader.Read())
            {
                this.OrderedItemsListBox.Items.Add(new OrderItem(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3)));
                total += reader.GetDecimal(4);
            }
            reader.Close();
            databaseManager.Disconnect();
            this.TotalLabel.Text = "Total: " + total.ToString();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (this.MenuListBox.SelectedItem != null)
            {
                if (this.OrderInfoListBox.SelectedItem != null)
                {
                    this.addSelectedMenuItem();
                }
                else
                {
                    databaseManager.Connect();
                    string query = $"INSERT INTO OrderInfo (TableNumber, EmployeeID, OrderDate, Status) VALUES ({this.tableNumber}, {this.assignedEmployee.EmployeeID}, \'{DateTime.Now}\',\'open\')";
                    int result = databaseManager.ExecuteCommand(query);
                    if (result != 0)
                    {
                        string query1 = "SELECT OrderId, OrderDate, Status FROM OrderInfo WHERE TableNumber = " + this.tableNumber + " ORDER BY OrderDate DESC LIMIT 1";
                        SQLiteDataReader reader = databaseManager.ExecuteQuery(query1);
                        while (reader.Read())
                        {
                            this.OrderInfoListBox.Items.Add(new OrderInfo(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
                        }
                        reader.Close();
                        databaseManager.Disconnect();
                        this.OrderInfoListBox.SelectedIndex = this.OrderInfoListBox.Items.Count - 1;
                        this.addSelectedMenuItem();
                    }
                    else
                    {
                        MessageBox.Show("*Extremely loud buzzzer noise*");
                        databaseManager.Disconnect();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderInfoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderInfo orderinfo = (OrderInfo)this.OrderInfoListBox.SelectedItem;
            fetchOrderedItems(orderinfo.orderId);
            if (orderinfo.status == "closed")
            {
                PayButton.Enabled = false;
                OrderButton.Enabled = false;
            }
            else
            {
                PayButton.Enabled = true;
                OrderButton.Enabled = true;
            }
        }

        private void addSelectedMenuItem()
        {
            OrderInfo orderinfo = (OrderInfo)this.OrderInfoListBox.SelectedItem;
            MenuItem menuItem = (MenuItem)this.MenuListBox.SelectedItem;
            databaseManager.Connect();
            string query = "INSERT INTO OrderItem (OrderId, ItemId, SpecialInstructions) VALUES (" + orderinfo.orderId + ", " + menuItem.itemId + ", " + "\'" + this.AnnotationTextBox.Text + "\')";
            int result = databaseManager.ExecuteCommand(query);
            if (result != 0)
            {
                databaseManager.Disconnect();
                fetchOrderedItems(orderinfo.orderId);

            }
            else
            {
                MessageBox.Show("*Extremely loud buzzzer noise*");
                databaseManager.Disconnect();
            }
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            //OrderInfo orderinfo = (OrderInfo)this.OrderInfoListBox.SelectedItem;
            //databaseManager.Connect();
            //string query = "UPDATE OrderInfo set Status = \'closed\' WHERE OrderId = " + orderinfo.orderId;
            //int result = databaseManager.ExecuteCommand(query);
            //if (result != 0)
            //{
            //    databaseManager.Disconnect();
            //    fetchActiveOrders();
            //}
            //else
            //{
            //    databaseManager.Disconnect();
            //}
            List<OrderInfo> activeOrders = new List<OrderInfo>();
            foreach (var x in this.OrderInfoListBox.Items)
            {
                OrderInfo orderInfo = (OrderInfo)x;
                if (orderInfo.status != "closed")
                {
                    activeOrders.Add((OrderInfo)x);

                }
            }

            PaymentForm form = new PaymentForm(activeOrders, this.assignedEmployee, this);
            form.Show();
        }

        private void ChangeTableButton_Click(object sender, EventArgs e)
        {
            OrderInfo orderinfo = (OrderInfo)this.OrderInfoListBox.SelectedItem;
            databaseManager.Connect();
            string query = "UPDATE OrderInfo set TableNumber = " + ChangeTableNumberBox.Value + " WHERE OrderId = " + orderinfo.orderId;
            int result = databaseManager.ExecuteCommand(query);
            if (result != 0)
            {
                databaseManager.Disconnect();
                MessageBox.Show("Successfully Changed the Tablenumber of the selected Order to " + ChangeTableNumberBox.Value, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fetchActiveOrders();
            } else
            {
                databaseManager.Disconnect();
            }
        }
    }
}
