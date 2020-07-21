using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/parcel/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/parcel")]
      public ActionResult Create(int height, int width, int length, int weight)
      {
        Parcel newParcel = new Parcel(height, width, length, weight);
        return View("ItemDetails", newParcel);
      }
    }
}