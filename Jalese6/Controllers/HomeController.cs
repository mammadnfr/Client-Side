using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jalese6.Models;
using System.Globalization;

namespace Jalese6.Controllers;

public class HomeController : Controller
{

    private readonly Context db;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, Context context)
    {
        db = context;
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

    public IActionResult SaveUser(Users obj)
    {
        /*Start Save*/
        // Users obj = new Users();
        // obj.Name = "Ali";
        // obj.Family = "Rostami";
        // obj.NameFather = "Gholam";
        // obj.Password = "236541";
        // obj.BirthDay = DateTime.Now;
        // obj.Gender = true;
        // obj.Active = true;
        // obj.weight = 90.5;
        db.Userss.Add(obj);
        db.SaveChanges();
        /*End Save*/

        return RedirectToAction("ContactUs");
    }
    public IActionResult ContactUs()
    {


        var query = db.Userss.ToList().OrderByDescending(x => x.Id);
        var queryCountUser = db.Userss.ToList().Count;
        ViewBag.CountUser = queryCountUser;
        return View(query);
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Shop()
    {

        List<Users> ListUsers = new List<Users>();


        Users obj1 = new Users();
        obj1.Id = 1;
        obj1.Name = "Mammad";
        obj1.Family = "NasimiFar";
        obj1.NameFather = "Shahin";
        obj1.Password = "123456";
        obj1.Gender = true; //True means Man & False means Woman
        //obj1.BirthDay = DateTime.Parse("2001/30/11");
        obj1.BirthDay = DateTime.ParseExact("2001/30/11", "yyyy/dd/MM", CultureInfo.InvariantCulture);
        obj1.Active = true;
        obj1.weight = 100;
        ListUsers.Add(obj1);

        Users obj2 = new Users();
        obj2.Id = 2;
        obj2.Name = "Mobin";
        obj2.Family = "Motiei";
        obj2.NameFather = "mohamad";
        obj2.Password = "654321";
        obj2.Gender = true; //True means Man & False means Woman
        //obj2.BirthDay = DateTime.Parse("2002/30/11");
        obj2.BirthDay = DateTime.ParseExact("2002/30/11", "yyyy/dd/MM", CultureInfo.InvariantCulture);
        obj2.Active = true;
        obj2.weight = 120;
        ListUsers.Add(obj2);

        Users obj3 = new Users();
        obj3.Id = 3;
        obj3.Name = "Arsal";
        obj3.Family = "Arghavan";
        obj3.NameFather = "MammadReza";
        obj3.Password = "112233";
        obj3.Gender = true; //True means Man & False means Woman
        //obj3.BirthDay = DateTime.Parse("2000/30/11");
        obj3.BirthDay = DateTime.ParseExact("2000/30/11", "yyyy/dd/MM", CultureInfo.InvariantCulture);
        obj3.Active = false;
        obj3.weight = 150;
        ListUsers.Add(obj3);

        Users obj4 = new Users();
        obj4.Id = 4;
        obj4.Name = "Sara";
        obj4.Family = "Moradi";
        obj4.NameFather = "Ali";
        obj4.Password = "112233";
        obj4.Gender = false; //True means Man & False means Woman
        //obj4.BirthDay = DateTime.Parse("2005/30/11");
        obj4.BirthDay = DateTime.ParseExact("2005/30/11", "yyyy/dd/MM", CultureInfo.InvariantCulture);
        obj4.Active = true;
        obj4.weight = 250.5;
        ListUsers.Add(obj4);


        var query = ListUsers.ToList();

        double SumAllWeight = 0;
        foreach (var item in query)
        {
            if (item.weight.HasValue)
            {
                SumAllWeight += item.weight.Value;
            }
        }

        return View(query);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
