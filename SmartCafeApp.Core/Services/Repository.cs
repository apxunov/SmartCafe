using SmartCafeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCafeApp.Core.Services
{
    class Repository
    {
        List<Order> ActiveOrders { get; }
        List<Order> NotPaidOrders { get; }
        List<Order> CompleteOrders { get; }
        List<Meal> Menu { get; }

        public bool ToNotPaid(Order order)
        {
            if (ActiveOrders.Contains(order))
            {
                ActiveOrders.Remove(order);
                NotPaidOrders.Add(order);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ToActive(Order order)
        {
            if (NotPaidOrders.Contains(order))
            {
                NotPaidOrders.Remove(order);
                ActiveOrders.Add(order);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ToComplete(Order order)
        {
            if (NotPaidOrders.Contains(order))
            {
                NotPaidOrders.Remove(order);
                CompleteOrders.Add(order);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Repository()
        {
            ActiveOrders = new List<Order>();
            NotPaidOrders = new List<Order>();
            CompleteOrders = new List<Order>();
            Menu = new List<Meal>()
            {
                new Meal
                {
                    Id = 1,
                    Name = "Ceasar",
                    MealType = "Salad",
                    Calories = 354,
                    Weight = 500,
                    Price = 350,
                    IsAvailable = true
                },

                new Meal
                {
                    Id = 2,
                    Name = "Olivie",
                    MealType = "Salad",
                    Calories = 304,
                    Weight = 550,
                    Price = 300,
                    IsAvailable = true
                },
                new Meal
                {
                    Id = 3,
                    Name = "Greek Salad",
                    MealType = "Salad",
                    Calories = 204,
                    Weight = 300,
                    Price = 300,
                    IsAvailable = true
                },
            };
        }
        



    }
}
