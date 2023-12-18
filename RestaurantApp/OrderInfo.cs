using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class OrderInfo
    {
            public int orderId;
            public int tableNumber;
            public string orderDate;
            public string status;

            public OrderInfo(int orderId, string orderDate, string status)
            {
                this.orderId = orderId;
                this.orderDate = orderDate;
                this.status = status;
            }

            public override string ToString()
            {
                return "Order " + this.orderId + " " + this.orderDate + " " + this.status;
            }
    }
}
