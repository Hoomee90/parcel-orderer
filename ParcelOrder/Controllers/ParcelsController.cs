using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParcelOrder.Models;

namespace ParcelOrder.Controllers
{
		public class ParcelsController : Controller
		{

			[HttpGet("/parcels")]
			public ActionResult Index()
			{
				List<Parcel> allParcels = Parcel.GetAll();
				return View(allParcels);
			}
			
			[HttpGet("/parcels/order")]
			public ActionResult NewForm()
			{
				return View();
			}

			[HttpPost("/parcels")]
			public ActionResult Create(int length, int width, int height, int weight)
			{
				Parcel _ = new(new[] {length, width, height}, weight);
				return RedirectToAction("Index");
			}
		}
}