﻿using System;
using System.Collections.Generic;

namespace RecipeApp.Models
{
    public partial class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Quantity { get; set; }
        public string? Unit { get; set; }
        public int RecipeId { get; set; }
    }
}
