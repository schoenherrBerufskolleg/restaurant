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

public class TableAssignment
{
    public int AssignmentID { get; set; }
    public int EmployeeID { get; set; }
    public int TableNumber { get; set; }
    private DatabaseManager Manager { get; set; }

    public TableAssignment(int AssignmentID,  int EmployeeID, int TableNumber,)
    {
        this.EmployeeID = EmployeeID;
        this.AssignmentID = AssignmentID;
        this.TableNumber = TableNumber;
        this.Manager = new DatabaseManager();
    }

    public List<(decimal, DateTime)> GetUnpaidOrder(SQLiteConnection conn, int tableNumber)
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
    }

    public string getTableInfo() {
        string query = $"Select * from TableInfo WHERE TableNumber == {TableNumber}";
        return "";
    }
    public void changeTable() {
        string query = $"Select * from OrderInfo WHERE TableNumber == {TableNumber} AND Status == \'open\'";
        return;
    }
    public void createInvoice() {
        string orderInfoQuery = $"Select * from OrderInfo WHERE TableNumber == {TableNumber} AND Status == \'open\'";
        string orderItemQuery = $"Select * from OrderItem";
        int ItemID = 0;
        string menuItemQuery = $"Select * from MenuItem WHERE ItemID == {ItemID}";
        decimal TotalAmount = 0;
        decimal PaidAmount = 0;
        int OrderID = 0;
        DateTime date = DateTime.Now;
        string sqlFormattedDate = date.ToString("yyyy-MM-dd");
        string createInvoiceQuery = $"INSERT INTO Invoice (OrderID, TotalAmount, PaidAmount, InvoiceDate) VALUES({OrderID}, {TotalAmount}, {PaidAmount}, \'{sqlFormattedDate}\')";
        return;
    }
    public void removeOrders() {
        string query = $"Delete from OrderInfo WHERE TableNumber == {TableNumber} AND State == \'open\'";

    }
    public void PayInvoice(decimal paid) {
        string orderInfoQuery = $"Select * from OrderInfo WHERE TableNumber == {TableNumber}";
        int OrderID = 0;
        string invoiceQuery = $"Select * from Invoice WHERE OrderID == {OrderID}";
        decimal currentlyPaid = 0;
        decimal totalAmount = 0;

        bool fully_paid = false;
        if (currentlyPaid + totalAmount == totalAmount) {
            string updateQuery = $"Update OrderID SET PaidAmount = {paid} WHERE OrderID == {OrderID}"; 
            fully_paid = true;
        }
    }
    public void ChangeEmployee(int new_id) {
        string updateAssignmentQuery = $"Update TableAssignment Set EmployeeID WHERE TableNumber = {TableNumber}";
        return;
    }
}