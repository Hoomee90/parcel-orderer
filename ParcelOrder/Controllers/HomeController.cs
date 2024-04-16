using Microsoft.AspNetCore.Mvc;

namespace ParcelOrder.Controllers
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