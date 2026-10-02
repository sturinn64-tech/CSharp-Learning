using System;
using System.Collections.Generic;
using System.Text;

namespace learning15
{
    internal class Laptop : Product, IExtendedWarranty
    {
        public int RAMCapacity { get; private set; }
        public bool IsGaming { get; private set; }

        public Laptop(string name, decimal basePrice, int productQuantity, int warrantyMonth, int ramCapacity, bool isGaming) : base(name, basePrice, productQuantity, warrantyMonth)
        {
            RAMCapacity = ramCapacity;
            IsGaming = isGaming;
        }

        public override decimal CalcPrice()
        {
            if (IsGaming == true)
                return BasePrice + 10000;

            return BasePrice;
        }

        public void ExtendedWarranty()
        {
            AddWarranty(12);
        }

        public override string GetInfo()
        {
            return $"Название ноутбука: {Name}, базовая цена ноутбука: {BasePrice}, количество на складе: {ProductQuantity}, месяцев гарантии: {WarrantyMonth}, количество оперативки: {RAMCapacity}, игровой: {IsGaming}";
        }
    }
}
