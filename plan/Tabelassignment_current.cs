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

        private class MenuItem
        {
            public int itemId;
            public string name;
            public decimal price;

            public MenuItem(int itemId, string itemName, decimal price)
            {
                this.itemId = itemId;
                this.name = itemName;
                this.price = price;
            }
            public override string ToString()
            {
                return this.name;
            }
        }

        private class OrderInfo
        {
            public int orderId;
            public int tableNumber;
            public DateTime orderDate;
            public string status;

            public OrderInfo(int orderId, DateTime orderDate, string status)
            {
                this.orderId = orderId;
                this.orderDate = orderDate;
                this.status = status;
            }

            public override string ToString()
            {
                return "Order " + this.orderId + " " + this.orderDate;
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

        private void fetchActiveOrders()
        {
            databaseManager.Connect();
            string query = "SELECT * FROM OrderInfo WHERE TableNumber = " + this.tableNumber;
            SQLiteDataReader reader = databaseManager.ExecuteQuery(query);
            while (reader.Read())
            {
                this.OrderInfoListBox.Items.Add(new OrderInfo(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2)));
            }
            reader.Close();
            databaseManager.Disconnect();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (this.MenuListBox.SelectedItem != null)
            {
                OrderInfo orderInfo;
                MenuItem menuItem;
                if (this.OrderInfoListBox.SelectedItem != null)
                {
                    orderInfo = (OrderInfo)this.OrderInfoListBox.SelectedItem;
                    menuItem = (MenuItem)this.MenuListBox.SelectedItem;
                    string query = "INSERT INTO OrderItem (OrderId, ItemId, SpecialInstructions) VALUES (" + orderInfo.orderId +", " + orderItem.itemId + ", " + orderItem.annotation
                }
            } else
            {
                MessageBox.Show("Please select an Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
