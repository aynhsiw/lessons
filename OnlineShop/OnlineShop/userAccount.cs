
using System.ComponentModel.Design;

namespace OnlineShop;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
public class UserAccount
{   
        public List<User> Users = new List<User>();
    public void Registration()
    {
        Console.WriteLine("1.register\r\n2.login");
        int.TryParse(Console.ReadLine(), out int answer);
        if (answer == 1)
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
        }
        else if (answer == 2)
            Console.WriteLine("Введите логин и пароль");
            Console.ReadLine();
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