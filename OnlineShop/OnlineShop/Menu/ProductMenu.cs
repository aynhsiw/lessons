using OnlineShop.Services;

namespace OnlineShop.Menu;

public class ProductMenu
{
    public static void ShowProductMenu(string username, string password, UserService userService, ProductService productService, CouponService couponService)
    {
        Console.Clear();
        Console.WriteLine("1. Создать продукт");
        Console.WriteLine("2. Добавить продукт");
        Console.WriteLine("3. Удалить продукт");
        Console.WriteLine("4. Изменить продукт");
        Console.WriteLine("5. Показать список продуктов");
        Console.WriteLine("6. Показать продукты в корзине");
        Console.WriteLine("7. Выйти");

        string productMenuChoice = Console.ReadLine();

        switch (productMenuChoice)
        {
            case "1":
                productService.CreateProduct();
                    break;
            case "2":
                productService.AddProduct();
                break;
            case "3":
                productService.RemoveProduct();
                break;
            case "4":
                productService.ChangeProduct();
                break;
            case "5":
                productService.ShowProductsList();
                break;
            case "6":
                productService.ShowCartList();
                break;
            case "7":
                MainMenu.ShowMainMenu(username, password, userService, productService, couponService);
                break;
        }
        ShowProductMenu(username, password, userService, productService, couponService);
    }
}
