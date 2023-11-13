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
        // query paid orders by date
        return new List<(int, DateTime)>();
    }

    //public Orders GetOrders()
    //{
    //// query for orders status unpaid by employeeid
    //return new Orders();
    //}
}
