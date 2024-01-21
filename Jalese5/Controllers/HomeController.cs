using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jalese5.Models;
using System.Globalization;

namespace Jalese5.Controllers;

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

        return RedirectToAction("RegUser");
    }
    public IActionResult ContactUs()
    {

        return View();

    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult RegUser()
    {
        Users obj1 = new Users();
        obj1.Name = "محمد";
        obj1.Family = "نسیمی فر";
        obj1.NameFather = "شاهین";
        obj1.Password = "123456";
        obj1.BirthDay = DateTime.Now;
        db.Userss.Add(obj1);
        db.SaveChanges();

        List<Users> ListUsers = new List<Users>();

        var query = db.Userss.ToList();
        var queryCountUser = db.Userss.ToList().Count;
        ViewBag.CountUser = queryCountUser;
        return View(query);

    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
