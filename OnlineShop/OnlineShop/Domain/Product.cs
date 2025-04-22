using System.Globalization;

namespace OnlineShop.Domain;

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Size { get; set; }
    public double Price { get; set; }

    public Product(string name, string description, int size, double price)
    {
        Name = name;
        Description = description;
        Size = size;
        Price = price;
    }

    public override string ToString()
    {
        var culture = new CultureInfo("en-US");
        //var price = Price.ToString("{0:C2}",culture);
        var price = string.Format(culture, "{0:C2}", Price);
        return $"{Name}, {Description}, {Size}, {price}";
    }
}