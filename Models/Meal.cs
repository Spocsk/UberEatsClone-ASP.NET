using System;
using System.ComponentModel.DataAnnotations;

namespace UberEatsClone.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Country { get; set; }
    }
}