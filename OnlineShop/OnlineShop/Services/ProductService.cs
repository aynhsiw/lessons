using OnlineShop.Domain;
using OnlineShop.Menu;

namespace OnlineShop.Services;

public class ProductService
{
    private List<Product> _productList = new List<Product>();
    private List<Product> cart = new List<Product>();

    public ProductService()
    {
        _productList = new List<Product>
        {
            new Product("Jacket", "Leather", 48, 42.00d),
            new Product("T-Shirt", "Nylon", 42, 15.00d),
            new Product("Shoes", "Fabric", 41, 55.00d)
        };
    }

    public void CreateProduct()
    {
        Console.WriteLine("Введите название товара");
        var name = Console.ReadLine();

        Console.WriteLine("Введите описание товара");
        var description = Console.ReadLine();

        Console.WriteLine("Введите размер товара");
        var sizeText = Console.ReadLine();
        var size = Int32.Parse(sizeText);

        Console.WriteLine("Введите цену товара");
        var priceText = Console.ReadLine();
        var price = Int32.Parse(priceText);

        var createdProduct = new Product(name, description, size, price);
        _productList.Add(createdProduct);
    }
    public void AddProduct()                       //done добавить метод для создания товара
    {
        for (int i = 0; i < _productList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_productList.ElementAt(i)}");
        }

        Console.WriteLine("Какой продукт вы хотите добавить?");

        var input = Console.ReadLine();
        var values = input.Split(";");
        foreach (var value in values)
        {
            if (int.TryParse(value, out int index))
            {
                cart.Add(_productList[index - 1]);
                Console.WriteLine($"Продукт {_productList.ElementAt(index - 1)} добавлен в корзину");
            }
        }
        Console.ReadKey();

    }

    public void RemoveProduct()
    {
        Console.WriteLine("Какой продукт вы хотите удалить?");

        if (cart.Count > 0)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cart.ElementAt(i)}$");
            }
        }
        else
        {
            Console.WriteLine("Ваша корзина пуста");
        }

        if (int.TryParse(Console.ReadLine(), out int index))
        {
            cart.RemoveAt(index - 1);
            Console.WriteLine("Продукт удален");
            Console.ReadKey();

        }
        else
        {
            Console.WriteLine("Неверный номер");
            Console.ReadKey();
        }
    }

    public void ChangeProduct()
    {
        //if (cart.Count == 0)
        //{
        //    Console.WriteLine("Ваша корзина пуста");
        //    Console.ReadKey();
        //    return;
        //}

        for (int i = 0; i < _productList.Count; i++)
        {
            //var productItem = cart.ElementAt(i);                        //done применить в других местах//
            Console.WriteLine($"{i + 1}. {_productList.ElementAt(i)}");         //done исправить изменение продукта
        }

        Console.WriteLine("Какой продукт вы хотите изменить?");
        var numberText = Console.ReadLine();
        int number = Int32.Parse(numberText);

        if (number > 0 && _productList.Count >= number)
        {
            Console.WriteLine("Неверный номер");
            Console.ReadKey();
            return;
        }

        var product = _productList.ElementAt(number - 1);               // мы вынесли в переменную индекс нужного товара

        Console.WriteLine("Введите новое название");
        var newProductName = Console.ReadLine();

        Console.WriteLine("Введите новое описание");
        var newProductDescription = Console.ReadLine();

        Console.WriteLine("Введите новый размер");
        var sizeText = Console.ReadLine();
        int newProductSize = Int32.Parse(sizeText);

        Console.WriteLine("Введите новую цену");
        var newProductPriceText = Console.ReadLine();
        double newProductPrice = Double.Parse(newProductPriceText);

        product.Name = newProductName;
        product.Description = newProductDescription;
        product.Size = newProductSize;                                    // поскольку product является экземпляром продукта, мы можем менять у него его поля
        product.Price = newProductPrice;                                                              // done изменение остальных полей в меню продукта
    }

    public void ShowProductsList()
    {
        for (int i = 0; i < _productList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_productList.ElementAt(i)}"); //done применить в других местах//
        }
        Console.ReadKey();
    }

    public void ShowCartList()
    {
        if (cart.Count > 0)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {cart.ElementAt(i)}");
            }
        }
        else
        {
            Console.WriteLine("Ваша корзина пуста");
            Console.ReadKey();
            return;
        }
        Console.ReadKey();
    }

    public void LeaveProductMenu(string username, string password, UserService userServices, ProductService productServices, CouponService couponService)
    {
        MainMenu.ShowMainMenu(username, password, userServices, productServices, couponService);
    }
}
