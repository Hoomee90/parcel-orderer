using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ParcelOrder.Models;

namespace ToDoList.Controllers
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
			public ActionResult Create(int[] dimensions, int weight)
			{
				Parcel _ = new(dimensions, weight);
				return RedirectToAction("Index");
			}
		}
}