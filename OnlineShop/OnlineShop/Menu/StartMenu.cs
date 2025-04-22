using OnlineShop.Services;

namespace OnlineShop.Menu;

public class StartMenu
{
    public static void ShowStartMenu(UserService userService, ProductService productService, CouponService couponService)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.register");
            Console.WriteLine("2.login");
            int.TryParse(Console.ReadLine(), out int answer);
            if (answer == 1)
            {
                userService.RegisterUser();

                ShowStartMenu(userService, productService, couponService);
            }
            else if (answer == 2)
            {
                var user = userService.LoginUser();
                if (user != null)
                {
                    MainMenu.ShowMainMenu(user.Username, user.Password, userService, productService, couponService);
                }
                else
                {
                    ShowStartMenu(userService, productService, couponService);
                }
            }
        }
    }
}