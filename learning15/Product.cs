using System;
using System.Collections.Generic;
using System.Text;

namespace learning15
{
    public abstract class Product
    {
        public string Name { get; }
        public decimal BasePrice { get; private set; }
        public int ProductQuantity { get; private set; }
        public int WarrantyMonth { get; private set; }

        public Product(string name, decimal basePrice, int productQuantity, int warrantyMonth)
        {
            Name = name;
            BasePrice = basePrice;
            ProductQuantity = productQuantity;
            WarrantyMonth = warrantyMonth;
        }

        public abstract decimal CalcPrice();

        public bool Sell(int amount)
        {
            if (amount <= 0) return false;

            if (amount > ProductQuantity) return false;

            return true;
        }

        public bool Replenish(int amount)
        {
            if (amount < 0) return false;

            return true;
        }

        protected void AddWarranty(int month)
        {
            if (month <= 0)
            {
                return;
            }

            WarrantyMonth += month;
        }

        public abstract string GetInfo();
    }
}
