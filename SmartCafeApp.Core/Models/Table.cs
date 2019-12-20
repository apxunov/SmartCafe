using SmartCafeApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCafeApp.Core.Models
{
    public class Table : IEntity
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public bool IsOccupied { get; set; }

        public bool IsValid()
        {
            return Capacity > 0;
        }
    }
}
