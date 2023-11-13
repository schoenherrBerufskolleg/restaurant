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

public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Role { get; set; }
    private DatabaseManager Manager { get; set; }

    public Employee(int EmployeeID, string FirstName, string LastName, string Username, string Role)
    {
        this.EmployeeID = EmployeeID;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Username = Username;
        this.Role = Role;
        this.Manager = new DatabaseManager();

    }

    public List<(decimal, DateTime)> GetTips()
    {
        string query = $"SELECT * FROM Tip WHERE EmployeeID == {EmployeeID}";
        this.Manager.Connect();
        SQLiteDataReader reader = Manager.ExecuteQuery(query);
        decimal amount;
        DateTime date;
        List<(decimal, DateTime)> tipList = new List<(decimal, DateTime)> { };
        while (reader.Read())
        {
            amount = reader.GetInt32(2);
            date = reader.GetDateTime(3);
            tipList.Add((amount, date));
        }
        reader.Close();
        this.Manager.Disconnect();
        return tipList;
    }

    public void AddTip(decimal amount, DateTime date)
    {
        //resp = save(EmployeeID, amount, Date.today())
        string sqlFormattedDate = date.ToString("yyyy-MM-dd");
        this.Manager.Connect();
        string query = $"INSERT INTO Tip (Amount, TipDate, EmployeeID) VALUES({amount}, \'{sqlFormattedDate}\', {EmployeeID})";
        int reader = Manager.ExecuteCommand(query);
        this.Manager.Disconnect();

    }

    public List<(int, DateTime)> GetTurnover(DateTime date)
    {
        string sqlFormattedDate = date.ToString("yyyy-MM-dd");
        string orderInfoQuery = $"SELECT * FROM OrderInfo WHERE EmployeeID == {EmployeeID} AND OrderDate == {sqlFormattedDate}";
        int OrderInfoID = 0;
        string OrderItemQuery = $"SELECT * FROM OrderItem WHERE OrderID == {OrderInfoID}";
        int ItemID = 0;
        string MenuItemQuery = $"SELECT * FROM MenuItem WHERE ItemID == {ItemID}";
        // query paid orders by date
        return new List<(int, DateTime)>();
    }
    public List<(decimal, DateTime)> GetUnpaidOrder(int tableNumber)
    {
        this.Manager.Connect();
        string query = $"SELECT * FROM OrderInfo WHERE TableNumber == {tableNumber} AND Status == \'open\'";
        SQLiteDataReader orderInfoReader = Manager.ExecuteQuery(query);
        int OrderId = orderInfoReader.GetInt32(0);
        string orderQuery = $"SELECT * FROM OderItem WHERE OrderId == {OrderId}";
        SQLiteDataReader orderItemReader = Manager.ExecuteQuery(query);
        decimal amount;
        DateTime date;
        List<(decimal, DateTime)> tipList = new List<(decimal, DateTime)> { };
        //while (reader.Read())
        //{
        //    amount = reader.GetInt32(2);
        //    date = reader.GetDateTime(3);
        //    tipList.Add((amount, date))
        //reader.Close();;
        //}
        //this.Manager.Disconnect();
        return tipList;
        //private Order GetUnpaidOrder()
        //{
        //// query for unpaid oders by tablenumber
        //return new List[Order()];
        //}

        //public Orders GetOrders()
        //{
        //// query for orders status unpaid by employeeid
        //return new Orders();
        //}
    }
}