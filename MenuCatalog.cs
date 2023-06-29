using System;
namespace UMLII
{
    public class MenuCatalog
    {
        private List<Pizza> pizzas = new List<Pizza>();

        public void AddPizza(Pizza pizza)
        {
            pizzas.Add(pizza);
        }



        public void CreatePizza()
        {
            Console.WriteLine("Indtast pizza ID");
            int pizzaId = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast navn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast pris");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast ingredienser");
            string ingredients = Console.ReadLine();
            Pizza pizza = new Pizza(pizzaId, name, price, ingredients);
            AddPizza(pizza);
        }

        public void ReadPizza()
        {
            Console.WriteLine("Indtast pizza ID");
            int pizzaId = int.Parse(Console.ReadLine());
            Pizza pizza = SearchPizza(pizzaId);
            Console.WriteLine();
            if (pizza != null)
            {
                Console.WriteLine(pizza.ToString());
            }
            else
            {
                Console.WriteLine("Pizza ikke fundet");
            }
        }

        public Pizza SearchPizza(int pizzaId)
        {
            return pizzas.Find(p => p.PizzaId == pizzaId);
        }

        public void UpdatePizza()
        {
            Console.WriteLine("Indtast pizza ID");
            int pizzaId = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast navn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast pris");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast ingredienser");
            string ingredients = Console.ReadLine();
            Pizza pizza = new Pizza(pizzaId, name, price, ingredients);
            for (int i = 0; i < pizzas.Count; i++)
            {
                if (pizzas[i].PizzaId == pizzaId)
                {
                    pizza.PizzaId = pizzaId;
                    pizzas[i] = pizza;
                    break;
                }
            }
        }

        public void DeletePizza()
        {
            Console.WriteLine("Indtast pizza ID");
            int pizzaId = int.Parse(Console.ReadLine());
            bool success = RemovePizza(pizzaId);
            if (success)
            {
                Console.WriteLine("Pizza slettet");
            }
            else
            {
                Console.WriteLine("Pizza ikke fundet");
            }
        }


        private bool RemovePizza(int pizzaId)
        {
            Pizza pizzaToRemove = pizzas.Find(p => p.PizzaId == pizzaId);
            if (pizzaToRemove != null)
            {
                pizzas.Remove(pizzaToRemove);
                return true;
            }
            return false;
        }

        public void PrintMenu()
        {
            foreach (Pizza pizza in pizzas)
            {
                Console.WriteLine(pizza.ToString());
            }
        }
    }
}

