using OnlineShop.Domain;

namespace OnlineShop.Services;

public class CouponService
{
    private List<Coupon> _couponList = new List<Coupon>();
    private List<Coupon> acceptedCoupon = new List<Coupon>();

    public CouponService()
    {
        _couponList = new List<Coupon>
      {
        new Coupon("spring", "02FA", 15, DiscountType.Absolute),
        new Coupon("spring", "77AZ", 50, DiscountType.Percent),
        new Coupon("spring", "199F", 0, DiscountType.Absolute)
      };
    }

    public void CreateCoupon()
    {
        Console.WriteLine("Введите название купона");
        var name = Console.ReadLine();

        Console.WriteLine("Введите код купона");
        var code = Console.ReadLine();

        Console.WriteLine("Введите размер скидки купона");
        var discountSize = Console.ReadLine();
        var discountSizeToInt = Convert.ToInt32(discountSize);
        
        Console.WriteLine("Введите тип скидки купона");
        var discountType = Console.ReadLine();
        var discountTypeToEnum = Enum.Parse(typeof(DiscountType), discountType);
        var createdCoupon = new Coupon(name, code, discountSizeToInt, (DiscountType)discountTypeToEnum);

        _couponList.Add(createdCoupon);
    }

    public void AddCoupon()
    {
        Console.WriteLine("Введите код купона");                  //done создать купон, удалить купон service Convert.ToInt32(Console.ReadLine())//
        string code = Console.ReadLine();
        foreach (var coupon in _couponList)
        {
            if (code == coupon.CouponCode)
            {
                acceptedCoupon.Add(coupon);
                Console.WriteLine("Купон на скидку применен");
                Console.ReadKey();
                break;
            }
            else
            {
                Console.WriteLine("Введен неправильный код");
                break;
            }
        }
    }

    public void RemoveCoupon()
    {
        Console.WriteLine("Какой купон вы хотите удалить?");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            acceptedCoupon.RemoveAt(index - 1);
            Console.WriteLine("Купон удален");
        }
    }

    public void ShowAcceptedCoupon()
    {
        for (int i = 0; i < acceptedCoupon.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {acceptedCoupon.ElementAt(i)}");
        }
        Console.ReadKey();
    }

    public void ShowCouponList()
    {
        for (int i = 0; i < _couponList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_couponList.ElementAt(i)}");
        }
        Console.ReadKey();
    }
}

