using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Interop;

namespace The_Cashier
{
    class Item
    {
        private int id;
        public string title { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double subtotal { get; set; }
        private string type;
        private int v;
        private string titl;
        private object quantityype;

        public Item (int id, string title, int quantity, double price, double subtotal, string type)
        {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.price = price;
            this.subtotal = subtotal;
            this.type = type;

            
        }

        public Item(int v, string titl, object quantityype, double price)
        {
            this.v = v;
            this.titl = titl;
            this.quantityype = quantityype;
            this.price = price;
        }

        public Item(int v, string titl, object quantityype, double price, string type) : this(v, titl, quantityype, price)
        {
        }

        public string getTitle()
        {
            return title;
        }    

        public int getQuantity()
        {
            return quantity;
        }
        public string getType()
        {
            return type;

        }

        public double getPrice()
        {
            return price;

        }

        public double getSubtotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }

    }
}
