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

public class OrderItem
{
    public int OrderItemID { get; set; }
    public int OrderID { get; set; }
    public int ItemID { get; set; }
    public string SpecialInstructions { get; set; }

    public OrderItem(int OrderItemID, int OrderID,  int ItemID,  string SpecialInstructions)
    {
        this.OrderID = OrderID;
        this.OrderItemID = OrderItemID;
        this.ItemID = ItemID;
        this.SpecialInstructions = SpecialInstructions;
    }
}