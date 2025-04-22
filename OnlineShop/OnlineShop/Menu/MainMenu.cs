using System.Collections.Generic;
using OnlineShop.Services;

namespace OnlineShop.Menu;

public class MainMenu
{
    public static void ShowMainMenu(string username, string password, UserService userService, ProductService productService,CouponService couponService)
    {
        Console.Clear();
        Console.WriteLine($"Добро пожаловать {username}");
        Console.WriteLine("1.Продукты");
        Console.WriteLine("2.Купоны");
        Console.WriteLine("3.История покупок");
        Console.WriteLine("4.Купить продукт");
        Console.WriteLine("5.Изменить данные пользователя");
        Console.WriteLine("6.Изменить пароль");
        Console.WriteLine("7.Выйти");

        string menu = Console.ReadLine();

        switch (menu)
        {
            case "1":
                ProductMenu.ShowProductMenu(username, password, userService, productService, couponService);
                break;

            case "2":
                CouponMenu.ShowCouponMenu(username, password, userService, productService, couponService);
                break;

            case "3":
                break;

            case "4":
                break;

            case "5":
                userService.ChangeLogin(username);
                break;

            case "6":
                userService.ChangePassword(username);
                break;

            case "7":
                return;
        }
    }
}