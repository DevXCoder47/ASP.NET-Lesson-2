using ASP.NET_lesson_2_project.Models;

namespace ASP.NET_lesson_2_project.ServiceInterfaces
{
	public interface IFoodService
	{
		List<Food> Dishes { get; set; }
		public List<Food> GetFood();
		public void AddFood(Food dish);
	}
}
