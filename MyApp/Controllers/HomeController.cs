using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using formUser;
using System.Text.Json;
using log;

namespace MyApp.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult ErrorPage()
    {
        return View();
    }

    public IActionResult Validate(string em, string pd)
    {
        try
        {
            string fileName = @"D:\AnagogicAks_Roach\.NET\MyApp\MyApp\Models\storage.json";
            string jsonString = System.IO.File.ReadAllText(fileName);
            List<User> jsonUsers = JsonSerializer.Deserialize<List<User>>(jsonString);            
            foreach (User newUser in jsonUsers)
            {
                if (newUser.email == em && newUser.pwd == pd)
                {
                    return Redirect("/home/Seat");
                }
                else
                {
                    return Redirect("/home/ErrorPage");
                }
            } 
        }
        catch (System.Exception)
        {

            throw;
        }
        return View();
    }

    public IActionResult Seat()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult NewUser(string fn, string ln, string email, int mn, string pwd, string cnfpwd)
    {
        var user = new User(fn, ln, email, mn, pwd, cnfpwd);
        List<User> list = new List<User>();
        list.Add(user);

        try
        {
            var options = new JsonSerializerOptions { IncludeFields = true };
            var usersJson = JsonSerializer.Serialize<List<User>>(list, options);
            string fileName = @"D:\AnagogicAks_Roach\.NET\MyApp\MyApp\Models\storage.json";
            System.IO.File.WriteAllText(fileName, usersJson);
            return Redirect("/Home/Login");

        }
        catch (System.Exception)
        {

            throw;
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}