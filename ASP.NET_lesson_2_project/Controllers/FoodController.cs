using ASP.NET_lesson_2_project.Models;
using ASP.NET_lesson_2_project.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_lesson_2_project.Controllers
{
	public class FoodController : Controller
	{
		public IFoodService Service { get; set; }
		public FoodController(IFoodService service)
		{
			this.Service = service;
		}
		public IActionResult GetFood()
		{
			return View(Service.GetFood());
		}
		public IActionResult AddFood()
		{
			return View();
		}
		public IActionResult UpdateFood(int id)
		{
			Food dish = Service.Dishes.First(dish => dish.Id == id);
			return View(dish);
		}
		[HttpPost]
		public IActionResult DeleteFood(int id)
		{
			Service.DeleteFood(id);
			return RedirectToAction(nameof(GetFood));
		}
		[HttpPost]
		public IActionResult AddFood(Food dish)
		{
			if (dish.Weight < 0 || dish.Price < 0)
				return RedirectToAction(nameof(ErrorPage), new {error = "Invalid weight or price"});
			Service.AddFood(dish);
			return RedirectToAction(nameof(GetFood));
		}
		[HttpPost]
		public IActionResult UpdateFood(Food dish)
		{
			if (dish.Weight < 0 || dish.Price < 0)
				return RedirectToAction(nameof(ErrorPage), new { error = "Invalid weight or price" });
			Service.UpdateFood(dish);
			return RedirectToAction(nameof(GetFood));
		}
		public IActionResult ErrorPage(string error)
		{
			ViewBag.ErrorMessage = error;
			return View();
		}
	}
}
