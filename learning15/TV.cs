using System;
using System.Collections.Generic;
using System.Text;

namespace learning15
{
    internal class TV : Product
    {
        public double Diagonal { get; private set; }
        public bool IsSmartTV { get; private set; }

        public TV(string name, decimal basePrice, int productQuantity, int warrantyMonth, double diagonal, bool isSmartTV) : base(name, basePrice, productQuantity, warrantyMonth)
        {
            Diagonal = diagonal;
            IsSmartTV = isSmartTV;
        }

        public override decimal CalcPrice()
        {
            if (IsSmartTV == true)
                return BasePrice + 5000;

            return BasePrice;
        }

        public override string GetInfo()
        {
            return $"Название телевизора: {Name}, базовая цена телевизора: {BasePrice}, количество на складе: {ProductQuantity}, месяцев гарантии: {WarrantyMonth}, диагональ: {Diagonal}, имеется SmartTV: {IsSmartTV}";
        }
    }
}
