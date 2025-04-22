using OnlineShop.Menu;
using OnlineShop.Services;

var userService = new UserService();
var productService = new ProductService();
var couponService = new CouponService();

StartMenu.ShowStartMenu(userService, productService, couponService);
