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
        string sqlFormattedDate = date.ToString("yyyy-MM-dd HH:MM:SS");
        this.Manager.Connect();
        string query = $"INSERT INTO Tip (Amount, TipDate, EmployeeID) VALUES({amount}, \'{sqlFormattedDate}\', {EmployeeID})";
        int reader = Manager.ExecuteCommand(query);
        this.Manager.Disconnect();

    }
    public int DeleteTurnover(DateTime showdate) {
        string sqlFormattedDate = showdate.ToString("yyyy-MM-dd HH:MM:SS");
        string deleteTurnoverQuery = $"Delete from DailyTurnover WHERE EmployeeID == {EmployeeID} AND TurnoverDate == \'{sqlFormattedDate}\'";
        int deleteResponse = Manager.ExecuteCommand(deleteTurnoverQuery);
        return deleteResponse;
    }

    public decimal GetTurnoverByInvoice(DateTime date, List<int> orderInfoIDList = null) {
        string sqlFormattedDate = date.ToString("yyyy-MM-dd HH:MM:SS");
        string invoiceQuery;
        decimal turnover = 0;
        if (orderInfoIDList == null) {
            invoiceQuery = $"SELECT * FROM Invoice WHERE InvoiceDate == \'{sqlFormattedDate}\'";
            SQLiteDataReader reader = Manager.ExecuteQuery(invoiceQuery);
            while (reader.Read())
            {
                turnover = turnover + reader.GetInt32(3);
            }
            reader.Close();
        }
        else {
            foreach(int id in orderInfoIDList) {
                invoiceQuery = $"SELECT * FROM Invoice WHERE OrderID == {id} AND InvoiceDate == \'{sqlFormattedDate}\'";
                SQLiteDataReader reader = Manager.ExecuteQuery(invoiceQuery);
                while (reader.Read())
                {
                    turnover = turnover + reader.GetInt32(3);
                }
                reader.Close();
            }
        }
        return turnover;
    }
    
    public List<decimal> GetMenuPrice(List<int> orderItemIDList) {
        List<decimal> priceList = new List<decimal> { };
        decimal price;
        string MenuItemQuery;
        foreach(int id in orderItemIDList) {
            MenuItemQuery = $"SELECT * FROM MenuItem WHERE ItemID == {id}";
            SQLiteDataReader reader = Manager.ExecuteQuery(MenuItemQuery);
            while (reader.Read())
            {
                price = reader.GetInt32(2);
                priceList.Add(price);
            }
            reader.Close();
        }
        return priceList;
    }

    public List<int> GetOrderInfo(DateTime date) {
        string sqlFormattedDate = date.ToString("yyyy-MM-dd HH:MM:SS");
        SQLiteDataReader reader;
        string orderInfoQuery = $"SELECT * FROM OrderInfo WHERE EmployeeID == {EmployeeID} AND OrderDate == \'{sqlFormattedDate}\'";
        reader = Manager.ExecuteQuery(orderInfoQuery);
        int orderInfoID;
        List<int> orderInfoIDList = new List<int> { };
        while (reader.Read())
        {
            orderInfoID = reader.GetInt32(0);
            orderInfoIDList.Add(orderInfoID);
        }
        reader.Close();
        return orderInfoIDList;
    }

    public decimal GetTurnover(
        DateTime showdate,
        bool GENERATE_NEW=false,
        bool SAVE=true
        )
    {
        SQLiteDataReader reader;
        string sqlFormattedDate = showdate.ToString("yyyy-MM-dd HH:MM:SS");
        string orderTurnover;
        orderTurnover = $"SELECT * FROM DailyTurnover WHERE EmployeeID == {EmployeeID} AND TurnoverDate == \'{sqlFormattedDate}\'";
        Manager.Connect();

        reader = Manager.ExecuteQuery(orderTurnover);
        decimal totalPrice;
        List<decimal> totalPriceList = new List<decimal> { };
        List<decimal> priceList = new List<decimal> { };
        while (reader.Read())
        {
            totalPrice = reader.GetDecimal(2);
            totalPriceList.Add(totalPrice);
        }
        reader.Close();
        if (totalPriceList.Count == 1 && GENERATE_NEW == false) {
            return totalPriceList[0];
        }
        if (totalPriceList.Count > 1 || GENERATE_NEW) {
            int deleteResponse = DeleteTurnover(showdate);
        }

        // generate turnover object for specified date
        // fetch orderinfo to get order ids
        List<int> orderInfoIDList = GetOrderInfo(showdate);

        foreach(int id in orderInfoIDList) {
            priceList.Add(GetTurnoverByInvoice(showdate, new List<int> {id}));
        }

        // calculate the price in total
        totalPrice = 0;
        foreach(decimal p in priceList) {
            totalPrice = totalPrice + p;
        }
        
        // save result
        if (SAVE == true) {
            string insertTurnoverQuery = $"INSERT INTO DailyTurnover (TotalTurnover, TurnoverDate, EmployeeID) VALUES({totalPrice}, \'{sqlFormattedDate}\', {EmployeeID})";
            int response = Manager.ExecuteCommand(insertTurnoverQuery);
        }
        Manager.Disconnect();
        return totalPrice;
    }
    
    public decimal TurnoverTodayForAll() {
        Manager.Connect();
        decimal turnover = this.GetTurnoverByInvoice(DateTime.Today);
        Manager.Disconnect();
        return turnover;
    }

    public decimal TurnoverToday() {
        Manager.Connect();
        List<int> orderInfoIDList = GetOrderInfo(DateTime.Today);
        decimal turnover = this.GetTurnoverByInvoice(DateTime.Today, orderInfoIDList);
        Manager.Disconnect();
        return turnover;
    }

    public int createInvoice(int orderID) {
        SQLiteDataReader reader;
        this.Manager.Connect();

        string query = $"SELECT * FROM OrderInfo WHERE TableNumber == {orderID}";
        reader = Manager.ExecuteQuery(query);

        string status = "";
        while (reader.Read()) {
            int OrderId = reader.GetInt32(0);
            status = reader.GetString(4);
        }
        if (status == "open") {
            return 1;
        }

        string orderQuery = $"SELECT * FROM OderItem WHERE OrderId == {orderID}";
        reader = Manager.ExecuteQuery(orderQuery);
        List<int> orderItemIdList = new List<int> {};
        while (reader.Read()) {
            orderItemIdList.Add(reader.GetInt32(0));
        }
        
        List<decimal> priceList = GetMenuPrice(orderItemIdList);
        decimal totalPrice = 0;
        foreach(decimal p in priceList) {
            totalPrice = totalPrice + p;
        }

        string sqlFormattedDate = DateTime.Today.ToString("yyyy-MM-dd HH:MM:SS");
        string createInvoiceQuery = $"INSERT INTO Invoice (TotalAmount, InvoiceDate, OrderId, PaidAmount) VALUES({totalPrice}, \'{sqlFormattedDate}\', {orderID}, 0)";
        int response = Manager.ExecuteCommand(createInvoiceQuery);

        this.Manager.Disconnect();
        return 0;
    }


    public List<(decimal, DateTime)> GetUnpaidOrder(int tableNumber)
    {
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
    }
}