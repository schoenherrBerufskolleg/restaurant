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
public string Password { get; set; }
public string Role { get; set; }

private List<Dictionary<string, DateTime>> GetTips(object employee, DatabaseManager manager)
{
string query = $"SELECT * FROM Tips WHERE EmployeeID == {EmployeeID}";
SQLiteDataReader reader = manager.ExecuteQuery(query);
int amount;
DateTime date;
List<Dictionary<string, DateTime || int>> tipList = new List<Dictionary<string, DateTime || int>>();
while (reader.Read())
{
    amount = reader.GetInt32(0);
    date = reader.GetDateTime(1);
	tipList.append({"amount:"})
}

return new List<Dictionary<string, object>>();
}

public void AddTip(decimal amount)
{
//resp = save(EmployeeID, amount, Date.today())
}

public List<Dictionary<string, object>> GetTurnover(date)
{
// query paid orders by date
return new List<Dictionary<string, object>>();
}

public Orders GetOrders()
{
// query for orders status unpaid by employeeid
return new Orders();
}
}
