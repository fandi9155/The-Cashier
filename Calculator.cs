﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Documents;

namespace The_Cashier
{
    class Calculator
    {
        private List<Item> listItem;
        private double total = 0;

        public Calculator()
        {
            this.listItem = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.listItem.Add(item);
            this.total += item.getSubtotal();

        }

        public double getTotal()
        {
            return total;
        }
        public List<Item> getListItem()
        {
            return listItem;
        }     
        
    }
}
