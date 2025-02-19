namespace Practice;

internal class Student
{
    public string name { get; set; }
    public int classroom { get; set; }
    public string subject { get; set; }
    public string favorite { get; set; }

    public string fav()
    {
        Console.WriteLine("Нравится ли вам выбранный предмет? (Да/Нет)");
        string answer = Console.ReadLine();
        if (answer == "Да")
        {
            Console.WriteLine("Урок начнется через час");
        }
        else if (answer == "Нет")
        {
            Console.WriteLine("Какой предмет вам нравится больше?");
            favorite = Console.ReadLine();
            Console.WriteLine(favorite);
        }
        return favorite;
    }
}