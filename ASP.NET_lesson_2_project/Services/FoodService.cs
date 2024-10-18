using ASP.NET_lesson_2_project.Models;
using ASP.NET_lesson_2_project.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_lesson_2_project.Services
{
	public class FoodService : IFoodService
	{
		public List<Food> Dishes { get; set; } = new List<Food>
		{
			new Food{Id = 1, Name = "Apple Pie", Weight = 10.5, Price = 100},
			new Food{Id = 2, Name = "Bacon and Eggs", Weight = 6.7, Price = 67.5},
			new Food{Id = 3, Name = "Mushroom Soup", Weight = 11.4, Price = 85.2},
			new Food{Id = 4, Name = "Salad", Weight = 7.8, Price = 56.1},
			new Food{Id = 5, Name = "Pork", Weight = 25.45, Price = 250.67}
		};
		public void AddFood(Food dish)
		{
			Dishes.Add(dish);
		}

		public void DeleteFood(int id)
		{
			Dishes.Remove(Dishes.First(dish => dish.Id == id));
		}

		public void UpdateFood(Food dish)
		{
			int index = Dishes.IndexOf(Dishes.First(d => d.Id == dish.Id));
			Dishes[index] = dish;
		}

		public List<Food> GetFood()
		{
			return Dishes;
		}
	}
}
