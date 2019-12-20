using SmartCafeApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCafeApp.Core.Models
{
    public class Meal : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MealType { get; set; }
        public List<string> Ingredients { get; set; }
        public decimal Calories { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name);
        }
    }
}
