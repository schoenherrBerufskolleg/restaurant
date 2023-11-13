using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace RestaurantApp
{
    public partial class Login : Form
    {
        DatabaseManager manager = new DatabaseManager();
        Employee currentUser;
        public Login()
        {
            //string command = "INSERT INTO Employee (FirstName, LastName, Username, password, Role) VALUES(\'Ben\', \'Schönherr\', \'Tricksero\', \'test\', \'Waiter\')";
            //manager.ExecuteCommand(command);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            Boolean loginSuccess = login(username, password);
            if(loginSuccess)
            {
                MessageBox.Show("Your login has succeeded", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 TableApplicationForm = new Form1(currentUser);
                TableApplicationForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User credentials", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private Boolean login(string username, string password)
        {
            manager.Connect();
            string query = "SELECT Username, Password, EmployeeID, Firstname, Lastname, Role FROM EMPLOYEE WHERE Username = \'"+ username + "\' AND Password = \'" + password + "\'";
            SQLiteDataReader result = manager.ExecuteQuery(query);
            while (result.Read())
            {
                string resultUsername = result.GetString(0);
                string resultPassword = result.GetString(1);
                int resultID = result.GetInt32(2);
                string resultFirstName = result.GetString(3);
                string resultLastName = result.GetString(4);
                string resultRole = result.GetString(5);
                if (username == resultUsername && password == resultPassword)
                {
                    currentUser = new Employee(resultID, resultFirstName, resultLastName, resultUsername, resultRole);
                    result.Close();
                    manager.Disconnect();
                    return true;
                }
                else
                {
                    result.Close();
                    manager.Disconnect();
                    return false;
                }
            }
            result.Close();
            manager.Disconnect();
            return false;
        }
    }
}
