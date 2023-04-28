using System;
using Shared.DTO;

namespace Shared.Models
{
	public class Ingredient
	{
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double? Price { get; set; }

        public Ingredient(){}

        public Ingredient(IngredientDTO dto) {
            this.Name = dto.Name;
            this.Price = dto.Price;
        }
    }
}

