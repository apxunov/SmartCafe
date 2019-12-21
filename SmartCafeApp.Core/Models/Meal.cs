using System.Collections.Generic;

namespace SmartCafeApp.Core.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MealType { get; set; }
        public List<string>? Ingredients { get; set; }
        public decimal Calories { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        

    }
}
