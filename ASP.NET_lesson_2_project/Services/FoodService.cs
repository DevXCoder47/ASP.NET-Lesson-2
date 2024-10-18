using ASP.NET_lesson_2_project.Models;
using ASP.NET_lesson_2_project.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_lesson_2_project.Services
{
	public class FoodService : IFoodService
	{
		public List<Food> Dishes { get; set; } = new List<Food>
		{
			new Food{Name = "Apple Pie", Weight = 10.5, Price = 100},
			new Food{Name = "Bacon and Eggs", Weight = 6.7, Price = 67.5},
			new Food{Name = "Mushroom Soup", Weight = 11.4, Price = 85.2},
			new Food{Name = "Salad", Weight = 7.8, Price = 56.1},
			new Food{Name = "Pork", Weight = 25.45, Price = 250.67}
		};
		public void AddFood(Food dish)
		{
			Dishes.Add(dish);
		}
		public List<Food> GetFood()
		{
			return Dishes;
		}
	}
}
