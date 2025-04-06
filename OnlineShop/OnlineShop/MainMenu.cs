namespace OnlineShop;

public class MainMenu
{
    public static void ShowMainMenu(string username, string password, UserService userServices)
    {
        Console.Clear();
        Console.WriteLine($"Добро пожаловать {username}");
        Console.WriteLine("1.Товары");
        Console.WriteLine("2.Купоны");
        Console.WriteLine("3.История покупок");
        Console.WriteLine("4.Купить товар");
        Console.WriteLine("5.Изменить данные пользователя");
        Console.WriteLine("6.Изменить пароль");
        Console.WriteLine("7.Выйти");

        string menu = Console.ReadLine();

        switch (menu)
        {
            case "1":
                Product.ProductMenu(username, password, userServices);
                break;

            case "5":
                userServices.ChangeLogin(username); // todo разобраться что мы сделали
                break;

            case "6":
                userServices.ChangePassword(username); // todo после перенесения вызвать userService
                break;

            case "7":
                return;
        }
    }
}