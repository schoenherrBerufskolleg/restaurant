using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using RestaurantApp;
using System.Data.SQLite;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Employee user;

        private PrintDocument printDocument = new PrintDocument();
        DatabaseManager manager = new DatabaseManager();
        public Form1(Employee user)
        {
            this.user = user;
            InitializeComponent();
            List<(decimal, DateTime)> old_tips = user.GetTips();
            Tabelle tipsTable = new Tabelle(this.TipsTable);
            tipsTable.initTable(new List<string> { "Amount", "Date" });
            foreach ((decimal, DateTime) old_tip in old_tips)
            {
                tipsTable.addTipRow(old_tip.Item1, old_tip.Item2);
                //DateTime date = DateTime.Now;
                //tipsTable.addTipRow(0, date);
            }

            int recentDays = 30;
            DateTime today = DateTime.Today;
            List<DateTime> dateList = new List<DateTime> { };
            for (int day = 0; day < recentDays; day++)
            {
                DateTime recentDay = today.AddDays(-day);
                dateList.Add(recentDay);
            }

            Tabelle turnoverTable = new Tabelle(this.TurnoverTable1);
            turnoverTable.initTable(new List<string> { "Amount", "Date" });
            decimal totalPrice;
            foreach (DateTime day_date in dateList)
            {
                totalPrice = user.GetTurnover(day_date);
                turnoverTable.addTurnoverRow(totalPrice, day_date);
            }
            Label numberLabel = this.TotalTurnoverNumberLabel;
            numberLabel.Text = 0.ToString();
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

        private void printButton_Click(object sender, EventArgs e)
        {
            string filePath = "H:\\repo\\GitHub\\restaurant\\pdf";

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                using (Bitmap bitmap = new Bitmap(200, 100))
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Font font = new Font("Arial", 12))
                        {
                            graphics.Clear(Color.White);
                            graphics.DrawString("Hello, this is a PDF created using C# built-in capabilities!", font, Brushes.Black, new PointF(10, 10));
                        }
                    }

                    bitmap.Save(fs, ImageFormat.Png);
                }
            }

            Console.WriteLine("PDF created successfully.");
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

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }
}