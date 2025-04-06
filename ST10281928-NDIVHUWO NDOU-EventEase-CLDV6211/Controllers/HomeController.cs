using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ST10281928_NDIVHUWO_NDOU_EventEase_CLDV6211.Models;

namespace ST10281928_NDIVHUWO_NDOU_EventEase_CLDV6211.Controllers;

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
