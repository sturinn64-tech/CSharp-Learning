using System;
using System.Collections.Generic;
using System.Text;

namespace learning15
{
    internal class SmartPhone : Product
    {
        public int MemoryCapacity { get; private set; }
        public bool Supporting5G {  get; private set; }

        public SmartPhone(string name, decimal basePrice, int productQuantity, int warrantyMonth, int memoryCapacity, bool supporting5G) : base(name, basePrice, productQuantity, warrantyMonth)
        {
            MemoryCapacity = memoryCapacity;
            Supporting5G = supporting5G;
        }

        public override decimal CalcPrice()
        {
            if (Supporting5G == true)
                return BasePrice + 3000;

            return BasePrice;
        }

        public void ExtendedWarranty()
        {
            AddWarranty(12);
        }

        public override string GetInfo()
        {
            return $"Название смартфона: {Name}, базовая цена смартфона: {BasePrice}, количество на складе: {ProductQuantity}, месяцев гарантии: {WarrantyMonth}, количество памяти: {MemoryCapacity}, имеется поддержка 5G: {Supporting5G}";
        }
    }
}
