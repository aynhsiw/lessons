namespace OnlineShop;

public class UserService
{
    public List<User> UsersList = new List<User>();

    public void RegisterUser()
    {
        Console.WriteLine("Введите логин");
        string username = Console.ReadLine();
        Console.WriteLine("Введите пароль");
        string password = Console.ReadLine();

        bool userExists = false;
        foreach (var user in UsersList)
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
            UsersList.Add(new User(username, password));
            Console.WriteLine("Успешная регистрация");
        }
    }

    public User LoginUser()
    {
        Console.WriteLine("Введите логин");
        string username = Console.ReadLine();
        Console.WriteLine("Введите пароль");
        string password = Console.ReadLine();

        foreach (var user in UsersList)
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

        for (int i = 0; i < UsersList.Count; i++)
        {
            if (UsersList[i].Password == currentPassword && UsersList[i].Username == username)
            {
                UsersList[i].Password = newPassword;
                break;
            }
        }
    }

    public void ChangeLogin(string username)  //todo: перенести changelogin и changepassword в UserService
    {
        Console.WriteLine("Введите новое имя пользователя");
        string newUsername = Console.ReadLine();

        for (int i = 0; i < UsersList.Count; i++)
        {
            if (UsersList[i].Username == username)
            {
                UsersList[i].Username = newUsername;
                break;
            }
        }
    }
}
