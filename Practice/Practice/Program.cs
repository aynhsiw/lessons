using Practice;

var Tourist = new Tourist();
Tourist.Name = "Alex";
Tourist.Age = 32;
Tourist.Place = "Africa";

var Info = Tourist.Info();
Console.WriteLine(Info);

//using Practice;

var Jacket = new Clothes();
Jacket.Color = "Black";
Jacket.Size = 48;
Jacket.Price = 5000;

var Coat = new Clothes();
Coat.Color = "Brown";
Coat.Size = 52;
Coat.Price = 9800;

var FurCoat = new Clothes();
FurCoat.Color = "White";
FurCoat.Size = 42;
FurCoat.Price = 27000;

Console.WriteLine("Выберите тип одежды: \r\n 1 - Jacket \r\n 2 - Coat \r\n 3 - Fur Coat");
string a = Console.ReadLine();
int check = int.Parse(a);
if (check == 1)
{
    Console.WriteLine("Jacket: " + Jacket.ShowText());
}
else if (check == 2)
{
    Console.WriteLine("Coat: " + Coat.ShowText());
}
else if (check == 3)
{
    Console.WriteLine("Fur Coat: " + FurCoat.ShowText());
}

//using Practice;

var student1 = new Student();
student1.name = "Ilya";
student1.classroom = 5;
student1.subject = "English";

var student2 = new Student();
student2.name = "Sasha";
student2.classroom = 2;
student2.subject = "Russian";

student1.fav();