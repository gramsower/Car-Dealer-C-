using Microsoft.AspNetCore.Mvc;
using Inventory.Models;

namespace CarDealer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}