using System.Globalization;

namespace OnlineShop.Domain;

public class Coupon
{
    public string CouponName { get; set; }
    public string CouponCode { get; set; }
    public int DiscountValue { get; set; }
    public DiscountType DiscountType {  get; set; }

    public Coupon(string name, string code,int discountValue, DiscountType discountType)
    {
        CouponName = name;
        CouponCode = code;
        DiscountValue = discountValue;
        DiscountType = discountType;
    }

    public override string ToString()
    {
        var culture = new CultureInfo("en-US");
        var couponToString = string.Format(culture, CouponName, CouponCode, DiscountValue, DiscountType);
        return $"{CouponName} {CouponCode} {DiscountValue} {DiscountType}";

    }
}
