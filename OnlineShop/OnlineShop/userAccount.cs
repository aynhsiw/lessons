using System.Security.Cryptography.X509Certificates;

namespace OnlineShop;

public class UserAccount
{
    public List<User> Users = new List<User>();

    public void ShowStartMenu()
    {
        Console.WriteLine("1.register\r\n2.login");
        int.TryParse(Console.ReadLine(), out int answer);
        if (answer == 1)
        {
            RegisterUser();
        }
        else if (answer == 2)
        {
            LoginUser();
        }
    }

    public void RegisterUser()
    {
        Console.WriteLine("Введите логин");
        string username = Console.ReadLine();
        Console.WriteLine("Введите пароль");
        string password = Console.ReadLine();

        bool userExists = false;
        foreach (var user in Users)
        {
            if (user.Username == username)
            {
                userExists = true;
                break;
            }
        }

        if (userExists)
        {
            Console.WriteLine($"Пользователь с логином {username} уже существует.");
        }
        else
        {
            Users.Add(new User(username, password));
            Console.WriteLine("Успешная регистрация");
        }

        ShowStartMenu();
    }

    public void LoginUser()
    {
        Console.WriteLine("Введите логин");
        string username = Console.ReadLine();
        Console.WriteLine("Введите пароль");
        string password = Console.ReadLine();

        bool userExists = false;
        foreach (var user in Users)
        {
            if (user.Username == username && user.Password == password)
            {
                userExists = true;
                break;
            }
        }

        if (userExists)
        {
            MainMenu(username);
        }
        else
        {
            Console.WriteLine("Такого пользователя не существует");
            ShowStartMenu();
        }
    }

    public void MainMenu(string username)
    {
        Console.WriteLine($"\r\nДобро пожаловать {username}");
        Console.WriteLine("\r\n1.Товары\r\n2.Купоны\r\n3.История покупок\r\n4.Купить товар\r\n5.Изменить данные пользователя\r\n6.Изменить пароль\r\n7.Выйти");
        string menu = Console.ReadLine();

        switch (menu)
        {
            case "5":
                Console.WriteLine("Введите текущее имя пользователя");
                string currentUsername = Console.ReadLine();
                Console.WriteLine("Введите новое имя пользователя");
                string newUsername = Console.ReadLine();
                for (int i = 0; i < Users.Count; i++)
                {
                    if (Users[i].Username == currentUsername)
                    {
                        Users[i].Username = newUsername;
                        break;
                    }
                }
                ShowStartMenu();
                break;

            case "6":
                Console.WriteLine("Введите текущий пароль");
                string currentPassword = Console.ReadLine();
                Console.WriteLine("Введите новый пароль");
                string newPassword = Console.ReadLine();
                for (int i = 0; i < Users.Count; i++)
                {
                    if (Users[i].Password == currentPassword)
                    {
                        Users[i].Password = newPassword;
                        break;
                    }
                }
                ShowStartMenu();
                break;

            case "7":
                ShowStartMenu();
                break;
        }

    }

    public void Display()
    {
        Console.WriteLine("Список зарегистрированных пользователей:");
        foreach (var user in Users)
        {
            Console.WriteLine($"Логин: {user.Username}, Пароль: {user.Password}");
        }
    }
}