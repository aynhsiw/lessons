
namespace OnlineShop;

public class userAccount
{
    public string username { get; set; }
    public string password { get; set; }

    public string registration()
    {
        Console.WriteLine("For registration press - 1 \r\nFor authorization press - 2");
        int uInput;
        int.TryParse(Console.ReadLine(), out uInput);
        if (uInput == 1)
        {
            Console.WriteLine("Registration of new User. Enter username");
            username = Console.ReadLine();
            Console.WriteLine("Registration of new User. Enter password");
            password = Console.ReadLine();
        }
        else if (uInput == 2)
        {
            Console.WriteLine("Enter username and password.");
        }
        return username + password;
    }
}
