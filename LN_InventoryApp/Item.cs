using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LN_InventoryApp
{
    internal class Item
    {
        private string itemName;
        private int itemNumber;
        private int itemQuantity;

        public Item(string name, int number, int quantity)
        {
            itemName = name;
            itemNumber = number;
            itemQuantity = quantity;
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }

        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                itemNumber = value;
            }
        }

        public int ItemQuantity
        {
            get
            {
                return itemQuantity;
            }
            set
            {
                itemQuantity = value;
            }
        }

        public int Receive(int quantity)
        {
            return itemQuantity += quantity;
        }

        public int Issue(int quantity)
        {
            return itemQuantity -= quantity;
        }
    }
}
