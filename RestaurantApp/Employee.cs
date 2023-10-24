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

public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Role { get; set; }
    private DatabaseManager Manager;

    public Employee(int EmployeeID, string FirstName, string LastName, string Username, string Role)
    {
        this.EmployeeID = EmployeeID;
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Username = Username;
        this.Role = Role;
        this.Manager = null;
    }

    private List<(decimal, DateTime)> GetTips(DatabaseManager Manager)
    {
        string query = $"SELECT * FROM Tips WHERE EmployeeID == {EmployeeID}";
        SQLiteDataReader reader = Manager.ExecuteQuery(query);
        decimal amount;
        DateTime date;
        List<(decimal, DateTime)> tipList = new List<(decimal, DateTime)>();
        while (reader.Read())
        {
            amount = reader.GetInt32(0);
            date = reader.GetDateTime(1);
            tipList.Append((amount, date));
        }

        return tipList;
    }

    public void AddTip(decimal amount, DateTime date)
    {
        //resp = save(EmployeeID, amount, Date.today())

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
