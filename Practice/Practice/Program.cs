Console.WriteLine("Задание 1\r\n");
Console.WriteLine("Введите имя пользователя");
var name = Console.ReadLine();

if (name == "admin")
{
    Console.WriteLine("\r\nВы администратор");
}
else
{
    Console.WriteLine("\r\nЗдравствуйте " + name);
}

Console.WriteLine("Задание 2-3\r\n");
Console.WriteLine("Напишите Ваш пол");
var gender = Console.ReadLine();
if (gender == "Мужчина")
{
    Console.WriteLine("Вы женат?");
}
else
{
    Console.WriteLine("Вы замужем?");
}
var answer = Console.ReadLine();
if (gender == "Мужчина" && answer == "Да")
{
    Console.WriteLine("Вы женаты");
}
else if (gender == "Женщина" && answer == "Да")
{
    Console.WriteLine("Вы замужем");
}
else
{
    Console.WriteLine("Вы холосты");
}

Console.WriteLine("Задание 4-5\r\n");
Console.WriteLine("Сколько вам лет?");
var question = Console.ReadLine();
int age = Int32.Parse(question);
if (age < 18)
{
    Console.WriteLine("Доступ запрещен");
}
else
{
    Console.WriteLine("Доступ разрешен");
}

Console.WriteLine("Задание 5\r\n");
Console.WriteLine("В какой стране вы проживаете?");
string страна = Console.ReadLine();
if (страна == "РФ")
{
    Console.WriteLine("Ваша страна - Российская Федерация");
}
else if (страна == "Китай")
{
    Console.WriteLine("Ваша страна - Китай");
}
else if (страна == "Турция")
{
    Console.WriteLine("Ваша страна - Турция");
}
else
{
    Console.WriteLine("Ваша страна - " + страна);
}
