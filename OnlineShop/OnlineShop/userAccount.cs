
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

            Users.Add(new User(username, password));
        }
        else if (answer == 2)
        {
            Console.WriteLine("Введите логин и пароль");
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