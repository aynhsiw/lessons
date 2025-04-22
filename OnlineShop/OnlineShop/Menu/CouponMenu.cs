using OnlineShop.Services;

namespace OnlineShop.Menu;

public class CouponMenu
{
    public static void ShowCouponMenu(string username, string password, UserService userService, ProductService productService, CouponService couponService)
    {
        Console.Clear();

        Console.WriteLine("1. Создать купон");
        Console.WriteLine("2. Применить купон");
        Console.WriteLine("3. Удалить купон");
        Console.WriteLine("4. Показать активный купон");
        Console.WriteLine("5. Показать все купоны");
        Console.WriteLine("6. Выйти");

        string couponMenuChoice = Console.ReadLine();

        switch (couponMenuChoice)
        {
            case "1":
                couponService.CreateCoupon();
                break;
            case "2":
                couponService.AddCoupon();
                break;
            case "3":
                couponService.RemoveCoupon();
                break;
            case "4":
                couponService.ShowAcceptedCoupon();
                break;
            case "5":
                couponService.ShowCouponList();
                break;
            case "6":
                MainMenu.ShowMainMenu(username, password, userService, productService, couponService);
                return;
        }
        ShowCouponMenu(username, password, userService, productService, couponService);
    }
}
