namespace OnlineShop;

public class Shop
{
    public static void ShowStartMenu(UserService userServices)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.register");
            Console.WriteLine("2.login");
            int.TryParse(Console.ReadLine(), out int answer);
            if (answer == 1)
            {
                userServices.RegisterUser();

                ShowStartMenu(userServices);
            }
            else if (answer == 2)
            {
                var user = userServices.LoginUser();
                if (user != null)
                {
                    MainMenu.ShowMainMenu(user.Username, user.Password, userServices);
                }
                else
                {
                    ShowStartMenu(userServices);
                }
            }
        }
    }
}