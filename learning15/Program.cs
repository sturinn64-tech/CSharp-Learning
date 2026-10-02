namespace learning15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            bool continueLooping = true;

            while (continueLooping)
            {
                Console.WriteLine("1. Добавить товар");
                Console.WriteLine("2. Показать все товары");
                Console.WriteLine("3. Показать товары только в наличии");
                Console.WriteLine("4. Продать товар");
                Console.WriteLine("5. Пополнить товар");
                Console.WriteLine("6. Рассчитать итоговую стоимость товара");
                Console.WriteLine("7. Продлить гарантию");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите операцию: ");

                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        store.AddProduct();
                        break;
                    case "2":
                        store.ShowProducts(); 
                        break;
                    case "0":
                        continueLooping = false;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
        }
    }
}
