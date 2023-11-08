using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jalese3.Models;


namespace Jalese3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutMe()
    {
        return View();
    }
    public IActionResult ContactUs()
    {

        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Shop()
    {

        List<Products> ListProduct = new List<Products>();

        Products product1 = new Products();

        product1.Id = 1;
        product1.Name = "کارت گرافیک";
        product1.Count = 1;
        product1.Color = "RGB";
        product1.Category = "قطعات کامپیوتر";
        product1.Price = 142000000;
        product1.Description = "کارت گرافیک MSI RTX 4090 SUPRIM X 24G";
        product1.available = true;
        ListProduct.Add(product1);

        Products product2 = new Products();
        product2.Id = 2;
        product2.Name = "پاور";
        product2.Count = 1;
        product2.Color = "مشکی";
        product2.Category = "قطعات کامپیوتر";
        product2.Price = 31000000;
        product2.Description = "پاور Corsair AX1600i Titanium";
        product2.available = true;
        ListProduct.Add(product2);

        Products product3 = new Products();
        product3.Id = 3;
        product3.Name = "اس اس دی";
        product3.Count = 2;
        product3.Color = "مشکی";
        product3.Category = "قطعات کامپیوتر";
        product3.Price = 15000000;
        product3.Description = "حافظه اس اس دی Corsair MP700 2TB";
        product3.available = true;
        ListProduct.Add(product3);

        Products product4 = new Products();
        product4.Id = 4;
        product4.Name = "مادربرد";
        product4.Count = 1;
        product4.Color = "سفید";
        product4.Category = "قطعات کامپیوتر";
        product4.Price = 42000000;
        product4.Description = "مادربرد ASUS ROG MAXIMUS Z790 HERO";
        product4.available = true;
        ListProduct.Add(product4);

        Products product5 = new Products();
        product5.Id = 5;
        product5.Name = "رم";
        product5.Count = 2;
        product5.Color = "مشکی";
        product5.Category = "قطعات کامپیوتر";
        product5.Price = 31000000;
        product5.Description = "رم Corsair Vengeance RGB DDR5 32GB Dual 5200MHz CL40 - ‌Black";
        product5.available = false;
        ListProduct.Add(product5);

        Products product6 = new Products();
        product6.Id = 6;
        product6.Name = "هدست";
        product6.Count = 1;
        product6.Color = "مشکی";
        product6.Category = "لوازم جانبی";
        product6.Price = 12600000;
        product6.Description = "هدست ASUS ROG Fusion II 500";
        product6.available = true;
        ListProduct.Add(product6);

        Products product7 = new Products();
        product7.Id = 7;
        product7.Name = "پردازنده";
        product7.Count = 1;
        product7.Color = "مشکی";
        product7.Category = "قطعات کامپیوتر";
        product7.Price = 44000000;
        product7.Description = "پردازنده Intel Core i9 14900K";
        product7.available = true;
        ListProduct.Add(product7);

        Products product8 = new Products();
        product8.Id = 8;
        product8.Name = "هارد دیسک";
        product8.Count = 2;
        product8.Color = "مشکی";
        product8.Category = "قطعات کامپیوتر";
        product8.Price = 8000000;
        product8.Description = "هارد دیسک WD Black 1TB WD1003FZEX";
        product8.available = true;
        ListProduct.Add(product8);


        var p = ListProduct.Where(x => x.available).ToList();
        var sum = ListProduct.Sum(x => x.Price);
        ViewBag.Sum = sum;
        return View(p);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
