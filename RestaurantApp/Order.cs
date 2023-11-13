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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Security.Cryptography.Xml;

public class Order
{
    public int OrderID { get; set; }
    public int TableNumber { get; set; }
    public int EmployeeID { get; set; }
    public DateTime OrderDate { get; set; }
    public string State { get; set; }

    public Order(int OrderID, int TableNumber, int EmployeeID, DateTime OrderDate, string State)
    {
        this.EmployeeID = EmployeeID;
        this.OrderDate = OrderDate;
        this.TableNumber = TableNumber;
        this.OrderDate = OrderDate;
        this.State = State;
    }
    public List<int> getAllOrderItems() {
        string query = $"SELECT * FROM OrderItem WHERE OrderID == {OrderID}";
        return new List<int>();
    }
}