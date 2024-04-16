using Microsoft.AspNetCore.Mvc;
using ParcelOrder.Models;

namespace ToDoList.Controllers
{
		public class ParcelsController : Controller
		{

			[HttpGet("/items")]
			public ActionResult Index()
			{
				// TODO: pass all parcels list once added
				return View();
			}
			
			[HttpGet("/item/order")]
			public ActionResult NewForm()
			{
				return View();
			}

			[HttpPost("/items")]
			public ActionResult Create(int[] dimensions, int weight)
			{
				Parcel _ = new(dimensions, weight);
				return RedirectToAction("Index");
			}
		}
}