using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class MenuItem
    {
        public int itemId;
        public string name;
        public decimal price;

        public MenuItem(int itemId, string itemName, decimal price)
        {
            this.itemId = itemId;
            this.name = itemName;
            this.price = price;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
