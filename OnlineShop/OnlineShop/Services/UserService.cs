using OnlineShop.Domain;

namespace OnlineShop.Services;

public class UserService
{
    private List<User> _usersList = new List<User>();

    public UserService()
    {
        var defaultUser = new User("1", "1");
        _usersList.Add(defaultUser);
    }

    public void RegisterUser()
    {
        Console.WriteLine("Введите логин");
        string username = Console.ReadLine();
        Console.WriteLine("Введите пароль");
        string password = Console.ReadLine();

        bool userExists = false;
        foreach (var user in _usersList)
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
            _usersList.Add(new User(username, password));
            Console.WriteLine("Успешная регистрация");
        }
    }

    public User LoginUser()
    {
        Console.WriteLine("Введите логин");
        string username = Console.ReadLine();
        Console.WriteLine("Введите пароль");
        string password = Console.ReadLine();

        foreach (var user in _usersList)
        {
            if (user.Username == username && user.Password == password)
            {
                return user;
            }
        }

        Console.WriteLine("Такого пользователя не существует");
        Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
        Console.ReadKey();

        return null;
    }
    public void ChangePassword(string username)
    {
        Console.WriteLine("Введите текущий пароль");
        string currentPassword = Console.ReadLine();
        Console.WriteLine("Введите новый пароль");
        string newPassword = Console.ReadLine();

        for (int i = 0; i < _usersList.Count; i++)
        {
            if (_usersList[i].Password == currentPassword && _usersList[i].Username == username)
            {
                _usersList[i].Password = newPassword;
                break;
            }
        }
    }

    public void ChangeLogin(string username)
    {
        Console.WriteLine("Введите новое имя пользователя");
        string newUsername = Console.ReadLine();

        for (int i = 0; i < _usersList.Count; i++)
        {
            if (_usersList[i].Username == username)
            {
                _usersList[i].Username = newUsername;
                break;
            }
        }
    }
}
