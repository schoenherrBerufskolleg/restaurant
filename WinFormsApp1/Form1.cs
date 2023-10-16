using System;
using System.Collections.Generic;

namespace WinFormsApp1
{

    //public class Employee
    //{
    //public int EmployeeID { get; set; }
    //public string FirstName { get; set; }
    //public string LastName { get; set; }
    //public string Username { get; set; }
    //public string Password { get; set; }
    //public string Role { get; set; }

    //public List<Dictionary<string, object>> GetTips()
    //{
    //// query tips by employeeids
    //return new List<Dictionary<string, object>>();
    //}

    //public void AddTip(decimal amount)
    //{
    ////resp = save(EmployeeID, amount, Date.today())
    //}

    //public List<Dictionary<string, object>> GetTurnover(date)
    //{
    //// query paid orders by date
    //return new List<Dictionary<string, object>>();
    //}

    //public Orders GetOrders()
    //{
    //// query for orders status unpaid by employeeid
    //return new Orders();
    //}
    //}

    //public class TableAssignment
    //{
    //public int AssignmentID { get; set; }
    //public int EmployeeID { get; set; }
    //public int TableNumber { get; set; }
    //public DateTime AssignmentDate { get; set; }

    //private Order GetUnpaidOrder()
    //{
    //// query for unpaid oders by tablenumber
    //return new List[Order()];
    //}

    //public string GetTableInfo()
    //{
    //// query for unpaid oders by tablenumber
    //return string.Empty;
    //}

    //public void ChangeTable(newTableNumber)
    //{
    //// get orders -> GetUnpaidOrder
    //// update all oders with new tablenumber
    //// query for tableinfo by number and set status to free
    //}

    //public void CreateInvoice(List[OrderItem], oderItems)
    //{
    //// update status of oder to "about to be paid or so"
    //// get orderitem itemid and query for prices
    //// create invoice element with zero paid and current date
    //}

    //public Order RemoveOrder()
    //{

    //// Implementation
    //return new Order();
    //}

    //public void PayInvoice(decimal amount, int invoiceid)
    //{
    //// update paidamount on invoice
    //// query for invoices with same orderid
    //// if all paid query and update status of oder
    //}

    //public void ChangeEmployee(employeeid)
    //{
    //// update tableassignment 
    //// Getunpaidorders update all orders
    //}
    //}

    //public class Order
    //{
    //public int OrderID { get; set; }
    //public int TableNumber { get; set; }
    //public int EmployeeID { get; set; }
    //public DateTime OrderDate { get; set; }
    //public string Status { get; set; }

    //public int GetCurrentTableAssignment()
    //{
    //// query for table by tablenumber

    //// Implementation
    //return 0;
    //}

    //public List<Order> GetAllOrderItems()
    //{
    //// query for all orders
    //return new List<Order>();
    //}

    //public List<OrderItem> GetOrderItems()
    //{
    //// query for oder items by orderid
    //return new List<OrderItem>();
    //}
    //}

    //public class OrderItem
    //{
    //public int OrderItemID { get; set; }
    //public int OrderID { get; set; }
    //public int ItemID { get; set; }
    //public string SpecialInstructions { get; set; }

    //public string GetMenuInfo()
    //{
    //// query for Menu item and return info
    //// Implementation
    //return string.Empty;
    //}

    //public int GetPrice()
    //{
    //// query for Menu item and return only price
    //// Implementation
    //return 0;
    //}
    //}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}