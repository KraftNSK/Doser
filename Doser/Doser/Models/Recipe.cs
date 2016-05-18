using System;
using System.Collections.Generic;

namespace Doser.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Product Product { get; set; }
        public List<RecipeElement> Elements { get; set; }
        public DateTime TimeCreate { get; set; }
        public DateTime TimeDeleted { get; set; }
        public User UserCreate { get; set; }
        public User UserDeleted { get; set; }
        public bool isDeleted { get; set; }
        public string Description { get; set; }
    }
}