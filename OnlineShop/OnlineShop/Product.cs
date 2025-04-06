namespace OnlineShop;

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }

    public Product(string name, string description, double price)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    private static List<Product> productList = new List<Product>
    {
        new Product("Jacket", "Leather", 42.00d),
        new Product("T-Shirt", "Nylon", 15.00d),
        new Product("Shoes", "Fabric", 55.00d)
    };


    public static void ProductMenu(string username, string password, UserService userServices)
    {
        while (true)
        {
            Console.Clear();

            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {productList[i].Name}, {productList[i].Description}, {productList[i].Price}$");
            }

            Console.WriteLine("1. Добавить продукт");
            Console.WriteLine("2. Удалить продукт");
            Console.WriteLine("3. Изменить продукт");
            Console.WriteLine("4. Показать список продуктов");
            Console.WriteLine("5. Выйти");

            string productMenuChoice = Console.ReadLine();

            switch (productMenuChoice)
            {
                case "2":
                    Console.WriteLine("Какой продукт вы хотите удалить?");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        productList.RemoveAt(index - 1);
                    }
                    else
                    {
                        Console.WriteLine("Неверный номер");
                        Console.ReadKey();
                    }
                    break;

                case "5":
                    MainMenu.ShowMainMenu(username, password, userServices);
                    return;
            }

        }
    }
}