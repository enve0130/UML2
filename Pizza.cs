using System;
namespace UMLII
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Ingredients { get; set; }

        public Pizza(int pizzaId, string name, double price, string ingredients)
        {
            PizzaId = pizzaId;
            Name = name;
            Price = price;
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            return $"PizzaId: {PizzaId}, Pizza: {Name}... {Price}... {Ingredients}";
        }
    }
}

