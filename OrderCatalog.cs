using System;
namespace UMLII
{
	public class OrderCatalog
    {
        private List<Order> orders = new List<Order>();
        private CustomerCatalog customerCatalog;
        private MenuCatalog menuCatalog;

        public OrderCatalog(MenuCatalog mC, CustomerCatalog cC)
        {
            menuCatalog = mC;
            customerCatalog = cC;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public void CreateOrder()
        {
            Console.WriteLine("Indtast ordre ID");
            int orderId = int.Parse(Console.ReadLine());
            string customerName = "0";

            Console.WriteLine("Er det en ny kunde? ja/nej");
            string eksisterendeKunde = Console.ReadLine();
            switch (eksisterendeKunde.ToLower())
            {
                case "ja":
                    customerCatalog.CreateCustomer();
                    Console.WriteLine("Indtast  kundes navn igen");
                    customerName = Console.ReadLine();
                    break;
                case "nej":
                    Console.WriteLine("Indtast eksisterende kundes navn");
                    customerName = Console.ReadLine();
                    break;

            }


            List<Pizza> pizzas = new List<Pizza>();
            bool addingPizza = true;

            while (addingPizza)
            {
                Console.WriteLine("Indtast pizza ID (eller 'afslut' for at stoppe tilføjelsen af pizzaer)");
                string input = Console.ReadLine();

                if (input.ToLower() == "afslut")
                {
                    addingPizza = false;
                }
                else
                {
                    if (int.TryParse(input, out int pizzaId))
                    {
                        Pizza pizza = menuCatalog.SearchPizza(pizzaId);
                        if (pizza != null)
                        {
                            pizzas.Add(pizza);
                            Console.WriteLine("Pizza tilføjet til ordren.");
                        }
                        else
                        {
                            Console.WriteLine("Pizza ikke fundet.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig indtastning. Prøv igen.");
                    }
                }
            }

            Order order = new Order(orderId, pizzas, customerCatalog.SearchCustomer(customerName));
            AddOrder(order);
        }

        public void ReadOrder()
        {
            Console.WriteLine("Indtast ordre ID");
            int orderId = int.Parse(Console.ReadLine());
            Order order = SearchOrder(orderId);
            Console.WriteLine();
            if (order != null)
            {
                Console.WriteLine(order.ToString());
            }
            else
            {
                Console.WriteLine("Ordre ikke fundet");
            }
        }

        public Order SearchOrder(int orderId)
        {
            return orders.Find(o => o.OrderId == orderId);
        }

        public void UpdateOrder()
        {
            Console.WriteLine("Indtast ordre ID");
            int orderId = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast kundens navn");
            string customerName = Console.ReadLine();
            List<Pizza> pizzas = new List<Pizza>();
            bool addingPizza = true;

            while (addingPizza)
            {
                Console.WriteLine("Indtast pizza ID (eller 'afslut' for at stoppe tilføjelsen af pizzaer)");
                string input = Console.ReadLine();

                if (input.ToLower() == "afslut")
                {
                    addingPizza = false;
                }
                else
                {
                    if (int.TryParse(input, out int pizzaId))
                    {
                        Pizza pizza = menuCatalog.SearchPizza(pizzaId);
                        if (pizza != null)
                        {
                            pizzas.Add(pizza);
                            Console.WriteLine("Pizza tilføjet til ordren.");
                        }
                        else
                        {
                            Console.WriteLine("Pizza ikke fundet.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ugyldig indtastning. Prøv igen.");
                    }
                }
            }

            Order order = new Order(orderId, pizzas, customerCatalog.SearchCustomer(customerName));
            UpdateNow(orderId, order);
        }

        private void UpdateNow(int orderId, Order updatedOrder)
        {
            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].OrderId == orderId)
                {
                    updatedOrder.OrderId = orderId;
                    orders[i] = updatedOrder;
                    break;
                }
            }
        }

        public void DeleteOrder()
        {
            Console.WriteLine("Indtast ordre ID");
            int orderId = int.Parse(Console.ReadLine());
            bool success = RemoveOrder(orderId);
            if (success)
            {
                Console.WriteLine("Ordre slettet");
            }
            else
            {
                Console.WriteLine("Ordre ikke fundet");
            }
        }

        private bool RemoveOrder(int orderId)
        {
            Order orderToRemove = orders.Find(o => o.OrderId == orderId);
            if (orderToRemove != null)
            {
                orders.Remove(orderToRemove);
                return true;
            }
            return false;
        }

        public void PrintOrders()
        {
            foreach (Order order in orders)
            {
                Console.WriteLine(order.ToString());
            }
        }
    }
}

