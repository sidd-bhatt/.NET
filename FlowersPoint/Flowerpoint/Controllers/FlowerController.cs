using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Flowerpoint.Models;
using BLL;//since we have to get the complete data through Catelog.cs of BLL
using BOL;//since the data is defined in Flower.cs in BOL

namespace Flowerpoint.Controllers;

public class FlowerController : Controller
{
    private readonly ILogger<FlowerController> _logger;

    public FlowerController(ILogger<FlowerController> logger)
    {
        _logger = logger;
    }

    public IActionResult GetFlowersDetails()
    {
        Catelog catelog = new Catelog();
        List<Flower> allFlowers = catelog.GetFlower();//getting list of all the flower from Catelog.cs of BLL
        this.ViewData["flowers"] = allFlowers;//giving keyword 'flowers' to the whole list we are getting
        return View();
    }
}