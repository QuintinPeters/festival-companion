using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Festivalcompanion.Models;

namespace Festivalcompanion.Controllers;

public class BalansController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}