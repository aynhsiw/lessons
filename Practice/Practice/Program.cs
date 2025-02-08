string Name()
{
    Console.WriteLine("Введите ваше имя");
    string name = Console.ReadLine();
    return name;
}
string sName()
{
    Console.WriteLine("Введите вашу фамилию");
    string sName = Console.ReadLine();
    return sName;
}
string answer = "Вас зовут: " + Name() + " " + sName();
Console.WriteLine(answer);

bool marriage()
{
    Console.WriteLine("Вы замужем?");
    string question = Console.ReadLine();
    if (question == "Да")
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool a = marriage();
Console.WriteLine(a);

bool coffe()
{
    Console.WriteLine("Вы любите кофе?");
    string question = Console.ReadLine();
    if (question == "Да")
    {
        return true;
    }
    else
    {
        return false;
    }
}
bool b = coffe();
Console.WriteLine(b);

string allergy()
{
    Console.WriteLine("У вас есть аллергия?");
    string answer = Console.ReadLine();
    if (answer == "Да")
    {
        Console.WriteLine("На какие продукты у вас аллергия?");
    }
    else
    {
        return "У вас нет аллергии";
    }
    string products = Console.ReadLine();
    return "У вас аллергия на " + products.ToLower();
}
Console.WriteLine(allergy());

string mCount()
{
    Console.WriteLine("Сколько раз вы были женаты?");
    string answer = Console.ReadLine();
    int count = Int32.Parse(answer);
    if (count >= 0 && count <= 100)
    {
        return "Вы были женаты " + count + " раз";
    }

    return "Некорректное значение";
}
Console.WriteLine(mCount());

string honey()
{
    Console.WriteLine("Как вас вас зовут?");
    string name = Console.ReadLine();
    return "Дорогая, " + name + ", ты сегодня как всегда прекрасно выглядишь! <3";
}
Console.WriteLine(honey());

string employers()
{
    Console.WriteLine("Сколько у вас сотрудников?");
    string quantity = Console.ReadLine();
    int a = Int32.Parse(quantity);
    if (a == 1)
    {
        return "1 человек поздравляет тебя с Юбилеем";
    }
    else if (a >= 2 && a <= 4)
    {
        return a + " человека поздравляют тебя с Юбилеем";
    }
    else if (a > 4)
    {
        return "Все сотрудники поздравляют тебя с Юбилеем";
    }
    else
    {
        return "Никто не поздравит вас с Юбилеем";
    }
}
Console.WriteLine(employers());

DateOnly date()
{
    while (true)
    {
        Console.WriteLine("Напишите вашу дату рождения в формате ДД.ММ.ГГГГ");
        string bDate = Console.ReadLine();
        if (DateOnly.TryParse(bDate, out DateOnly date))
        {
            return date;
        }
        else
        {
            Console.WriteLine("Некорректный формат даты");
        }
    }

}
Console.WriteLine("Ваша дата рождения - " + date());

void movies()
{
    Console.WriteLine("Сколько у вас любимых фильмов?");
    var fCount = Console.ReadLine();
    int count = int.Parse(fCount);
    Console.WriteLine("У вас " + count + " любимых фильмов");
    for (int i = 1; i <= count; i++)
    {
        Console.WriteLine("Какой " + i + " фильм?");
        Console.ReadLine();
    }
}

movies();

////////////////////////////////////////////////////////////////////////////

int total = sum();
Console.WriteLine("Сумма ваших покупок " + total);
int sum()
{
    Console.WriteLine("Мы посчитаем сумму ваших покупок\r\n");
    int tSum = 0;
    for (int i = 1; i <= 3; i++)
    {
        Console.WriteLine("Сколько стоит " + i + " продукт?");
        string b = Console.ReadLine();
        int pSum = Int32.Parse(b);
        tSum += pSum;
    }
    return tSum;
}

string result = daughters();
Console.WriteLine(result);
string daughters()
{
    Console.WriteLine("Как зовут вашу первую дочь?");
    string daughter1 = Console.ReadLine();
    Console.WriteLine("Как зовут вашу вторую дочь?");
    string daughter2 = Console.ReadLine();
    Console.WriteLine("Как зовут вашу третью дочь?");
    string daughter3 = Console.ReadLine();
    string names = "Ваших дочерей зовут: " + daughter1 + ", " + daughter2 + ", " + daughter3 + ".";
    return names;
}

int time = SpaceTime();
Console.WriteLine(time);
int SpaceTime()
{
    int speed = 8;
    Console.WriteLine("Укажите расстояние в километрах");
    string StringUserDistance = Console.ReadLine();
    int UserDistance = int.Parse(StringUserDistance);
    int distance = speed * UserDistance;
    return distance;
}

int dayTime = clocks();
int clocks()
{
    Console.WriteLine("Сколько сейчас времени?");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int time))
        if (time >= 6 && time < 12)
        {
            Console.WriteLine("Доброе утро");
        }
        else if (time >= 12 && time < 18)
        {
            Console.WriteLine("Добрый день");
        }
        else if (time >= 18 && time < 24)
        {
            Console.WriteLine("Добрый вечер");
        }
        else if (time >= 0 && time < 6)
        {
            Console.WriteLine("Доброй ночи");
        }
        else
        {
            Console.WriteLine("Введите корректное значение");
        }
    return time;
}

int pool()
{
    Console.WriteLine("Введите длину");
    string a = Console.ReadLine();
    Console.WriteLine("Введите высоту");
    string b = Console.ReadLine();
    Console.WriteLine("Введите ширину");
    string c = Console.ReadLine();
    if (int.TryParse(a, out int l) && int.TryParse(b, out int h) && int.TryParse(c, out int d))
    {
        return l * h * d;
    }
    else
    {
        Console.WriteLine("Введите корректные значения");
        return 0;
    }
}
Console.WriteLine(pool());