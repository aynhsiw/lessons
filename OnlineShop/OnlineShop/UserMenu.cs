namespace OnlineShop;

public class UserMenu
{


    public static void MainMenu(string username, string password, List<User> userList)
    {
        Console.WriteLine($"\r\nДобро пожаловать {username}");
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
                while (true)
                {
                    Console.WriteLine("1. product 1");
                    Console.WriteLine("2. product 2");
                    Console.WriteLine("3. product 3");
                    Console.WriteLine("4. product 4");
                    Console.WriteLine("5. Выйти");
                    var productMenuChoice = Console.ReadLine();
                    if (productMenuChoice == "5")
                    {
                        MainMenu(username, password, userList);
                        break;
                    }

                }
                break;

            case "5":
                Console.WriteLine("Введите новое имя пользователя");
                string newUsername = Console.ReadLine();

                for (int i = 0; i < userList.Count; i++)
                {
                    if (userList[i].Username == username)
                    {
                        userList[i].Username = newUsername;
                        break;
                    }
                }
                break;

            case "6":
                Console.WriteLine("Введите текущий пароль");
                string currentPassword = Console.ReadLine();
                Console.WriteLine("Введите новый пароль");
                string newPassword = Console.ReadLine();

                for (int i = 0; i < userList.Count; i++)
                {
                    if (userList[i].Password == password)
                    {
                        userList[i].Password = newPassword;
                        break;
                    }
                }
                break;

            case "7":
                break;
        }

    }
}
