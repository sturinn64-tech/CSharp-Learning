using System;
using System.Collections.Generic;
using System.Text;

namespace learning15
{
    internal class Store
    {
        private List<Product> products = new();

        public void AddProduct()
        {
            Console.WriteLine("Какой товар желаете добавить?");
            Console.WriteLine("1. Смартфон");
            Console.WriteLine("2. Ноутбук");
            Console.WriteLine("3. Телевизор");
            Console.Write("Выберите операцию: ");

            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    {
                        Console.Write("Введите название смартфона: ");

                        string name = Console.ReadLine();

                        decimal basePrice;

                        while (true)
                        {
                            Console.Write("Введите базовую стоимость: ");

                            if (!decimal.TryParse(Console.ReadLine(), out basePrice))
                            {
                                Console.WriteLine("Введите корректную цену.");
                                continue;
                            }

                            if (basePrice <= 0)
                            {
                                Console.WriteLine("Цена не может быть меньше 0.");
                                continue;
                            }

                            break;
                        }

                        int quantity;

                        while (true)
                        {
                            Console.Write("Введите количество товара: ");
                            if (!int.TryParse(Console.ReadLine(), out quantity))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (quantity < 0)
                            {
                                Console.WriteLine("Количество не может быть меньше 0.");
                                continue;
                            }

                            break;
                        }

                        int warrantyMonth;

                        while (true)
                        {
                            Console.Write("Сколько месяцев гарантии: ");
                            if (!int.TryParse(Console.ReadLine(), out warrantyMonth))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (warrantyMonth < 0)
                            {
                                Console.WriteLine("Гарантия не может быть меньше 0");
                                continue;
                            }

                            break;
                        }

                        int memoryCapacity;

                        while (true)
                        {
                            Console.Write("Введите количество памяти: ");
                            if (!int.TryParse(Console.ReadLine(), out memoryCapacity))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (memoryCapacity <= 0)
                            {
                                Console.WriteLine("Количество памяти должно быть больше 0.");
                                continue;
                            }

                            break;
                        }

                        bool support5G;

                        Console.Write("Есть поддержка 5G?: ");
                        string answer = Console.ReadLine();

                        if (answer.Trim().ToLower() == "да")
                        {
                            support5G = true;
                        }
                        else
                        {
                            support5G = false;
                        }

                        SmartPhone smartPhone = new SmartPhone(name, basePrice, quantity, warrantyMonth, memoryCapacity, support5G);
                        products.Add(smartPhone);

                        break;
                    }

                case "2":
                    {
                        Console.Write("Введите название ноутбука: ");

                        string name = Console.ReadLine();

                        decimal basePrice;

                        while (true)
                        {
                            Console.Write("Введите базовую стоимость: ");

                            if (!decimal.TryParse(Console.ReadLine(), out basePrice))
                            {
                                Console.WriteLine("Введите корректную цену.");
                                continue;
                            }

                            if (basePrice <= 0)
                            {
                                Console.WriteLine("Цена не может быть меньше 0.");
                                continue;
                            }

                            break;
                        }

                        int quantity;

                        while (true)
                        {
                            Console.Write("Введите количество товара: ");
                            if (!int.TryParse(Console.ReadLine(), out quantity))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (quantity < 0)
                            {
                                Console.WriteLine("Количество не может быть меньше 0.");
                                continue;
                            }

                            break;
                        }

                        int warrantyMonth;

                        while (true)
                        {
                            Console.Write("Сколько месяцев гарантии: ");
                            if (!int.TryParse(Console.ReadLine(), out warrantyMonth))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (warrantyMonth < 0)
                            {
                                Console.WriteLine("Гарантия не может быть меньше 0");
                                continue;
                            }

                            break;
                        }

                        int ramCapacity;

                        while (true)
                        {
                            Console.Write("Сколько оперативки?: ");
                            if (!int.TryParse(Console.ReadLine(), out ramCapacity))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (ramCapacity <= 0)
                            {
                                Console.WriteLine("Оперативки должно быть больше 0.");
                                continue;
                            }

                            break;
                        }

                        bool isGaming;

                        Console.Write("Это игровой ноутбук?: ");
                        string answer = Console.ReadLine();

                        if (answer.Trim().ToLower() == "да")
                        {
                            isGaming = true;
                        }
                        else
                        {
                            isGaming = false;
                        }

                        Laptop laptop = new Laptop(name, basePrice, quantity, warrantyMonth, ramCapacity, isGaming);
                        products.Add(laptop);

                        break;
                    }

                case "3":
                    {
                        Console.Write("Введите название телевизора: ");

                        string name = Console.ReadLine();

                        decimal basePrice;

                        while (true)
                        {
                            Console.Write("Введите базовую стоимость: ");

                            if (!decimal.TryParse(Console.ReadLine(), out basePrice))
                            {
                                Console.WriteLine("Введите корректную цену.");
                                continue;
                            }

                            if (basePrice <= 0)
                            {
                                Console.WriteLine("Цена не может быть меньше 0.");
                                continue;
                            }

                            break;
                        }

                        int quantity;

                        while (true)
                        {
                            Console.Write("Введите количество товара: ");
                            if (!int.TryParse(Console.ReadLine(), out quantity))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (quantity < 0)
                            {
                                Console.WriteLine("Количество не может быть меньше 0.");
                                continue;
                            }

                            break;
                        }

                        int warrantyMonth;

                        while (true)
                        {
                            Console.Write("Сколько месяцев гарантии: ");
                            if (!int.TryParse(Console.ReadLine(), out warrantyMonth))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (warrantyMonth < 0)
                            {
                                Console.WriteLine("Гарантия не может быть меньше 0");
                                continue;
                            }

                            break;
                        }

                        double diagonal;

                        while (true)
                        {
                            Console.Write("Какая диагональ?: ");
                            if (!double.TryParse(Console.ReadLine(), out diagonal))
                            {
                                Console.WriteLine("Введдите корректное число.");
                                continue;
                            }

                            if (diagonal < 24)
                            {
                                Console.WriteLine("Диагональ не может быть меньше 24.");
                                continue;
                            }

                            break;
                        }

                        bool isSmart;

                        Console.Write("Телевизор обладает smartTV?: ");
                        string answer = Console.ReadLine();

                        if (answer.Trim().ToLower() == "да")
                        {
                            isSmart = true;
                        }
                        else
                        {
                            isSmart = false;
                        }

                        TV tv = new TV(name, basePrice, quantity, warrantyMonth, diagonal, isSmart);
                        products.Add(tv);

                        break;
                    }
                default:
                    Console.WriteLine("Неверная операция.");
                    break;
            }
        }

        public void ShowProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Список продуктов пуст.");
                return;
            }
            
            foreach (Product product in  products)
            {
                Console.WriteLine(product.GetInfo());
            }
        }

        public void SellProduct()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Список продуктов пуст.");
                return;
            }

            Console.Write("Какой товар вы хотите продать?: ");
            string name = Console.ReadLine();
            
            int amount;
            while (true)
            {
                Console.Write("Введите количество товара: ");
                if (!int.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Некорректный ввод.");
                    continue;
                }

                if (amount <= 0)
                {
                    Console.WriteLine("Количество товара должно быть больше 0.");
                    continue;
                }

                break;
            }
            
            foreach (Product product in products)
            {                              
                if (name == product.Name)
                {
                    bool sell = product.Sell(amount);

                    if (sell)
                    {
                        Console.WriteLine("Товар продан.");
                    }
                    else
                    {
                        Console.WriteLine("Товара на складе недостаточно.");
                    }

                    return;
                }
            }

            Console.WriteLine("Товар не найден.");
        }

        public void ReplenishProduct()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Список продуктов пуст.");
                return;
            }

            Console.Write("Какой товар вы хотите пополнить?: ");
            string name = Console.ReadLine();

            int amount;
            while (true)
            {
                Console.Write("Введите количество товара: ");
                if (!int.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Некорректный ввод.");
                    continue;
                }

                if (amount <= 0)
                {
                    Console.WriteLine("Количество товара должно быть больше 0.");
                    continue;
                }

                break;
            }

            foreach(Product product in products)
            {
                if (name == product.Name)
                {
                    bool replenish = product.Replenish(amount);

                    if (replenish)
                    {
                        Console.WriteLine("Товар пополнен");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка пополнения");
                    }

                    return;
                }                         
            }

            Console.WriteLine("Товар не найден.");
        }

        public void ShowAvialableProduct()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Список продуктов пуст.");
                return;
            }

            bool found = false;

            foreach(Product product in products)
            {
                if (product.ProductQuantity > 0)
                {
                    Console.WriteLine(product.GetInfo());
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Товаров нет в наличии.");
            }
        }

        public void FinalProductPrice()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Список продуктов пуст.");
                return;
            }

            Console.Write("Введите название товара, для которого хотите узнать итоговую стоимость: ");
            string name = Console.ReadLine();

            foreach (Product product in products)
            {
                if (name == product.Name)
                {
                    decimal price = product.CalcPrice();

                    Console.WriteLine($"Цена товара составляет: {price}");

                    return;
                }              
            }

            Console.WriteLine("Товар не найден.");
        }

        public void AddExtendedWarranty()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Список продуктов пуст.");
                return;
            }

            Console.Write("Введите название товара, для которого хотите продлить гарантию: ");
            string name = Console.ReadLine();

            foreach (Product product in products)
            {
                if (name == product.Name)
                {
                    if (product is IExtendedWarranty warrantyProduct)
                    {
                        warrantyProduct.ExtendedWarranty();
                        Console.WriteLine($"Гарантия продлена, теперь {product.WarrantyMonth} месяцев.");
                    }
                    else
                    {
                        Console.WriteLine("Для этого товара проддить гарантию нельзя");
                    }

                    return;
                }
            }

            Console.WriteLine("товар не найден.");
        }
    }
}
