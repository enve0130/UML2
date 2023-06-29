using System;
namespace UMLII
{
	public class UserInterface
    {
        private MenuCatalog menuCatalog;
        private CustomerCatalog customerCatalog;
        private OrderCatalog orderCatalog;

        public UserInterface(MenuCatalog mC, CustomerCatalog cC, OrderCatalog oC)
        {
            menuCatalog = mC;
            customerCatalog = cC;
            orderCatalog = oC;
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Vælg mellem: Pizza, Kunde, Ordre, Afslut");
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "pizza":
                        PizzaMenu();
                        break;
                    case "kunde":
                        CustomerMenu();
                        break;
                    case "ordre":
                        OrderMenu();
                        break;
                    case "afslut":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
            }
        }

        private void PizzaMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Vælg mellem: Opret, Læs, Opdater, Slet, Print, Afslut");
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "opret":
                        menuCatalog.CreatePizza();
                        break;
                    case "læs":
                        menuCatalog.ReadPizza();
                        break;
                    case "opdater":
                        menuCatalog.UpdatePizza();
                        break;
                    case "slet":
                        menuCatalog.DeletePizza();
                        break;
                    case "print":
                        menuCatalog.PrintMenu();
                        break;
                    case "afslut":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
            }
        }

       
        private void CustomerMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Vælg mellem: Opret, Læs, Opdater, Slet, Print, Afslut");
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "opret":
                        customerCatalog.CreateCustomer();
                        break;
                    case "læs":
                        customerCatalog.ReadCustomer();
                        break;
                    case "opdater":
                        customerCatalog.UpdateCustomer();
                        break;
                    case "slet":
                        customerCatalog.DeleteCustomer();
                        break;
                    case "print":
                        customerCatalog.PrintCustomers();
                        break;
                    case "afslut":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
            }
        }

        private void OrderMenu()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Vælg mellem: Opret, Læs, Opdater, Slet, Print, Afslut");
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "opret":
                        orderCatalog.CreateOrder();
                        break;
                    case "læs":
                        orderCatalog.ReadOrder();
                        break;
                    case "opdater":
                        orderCatalog.UpdateOrder();
                        break;
                    case "slet":
                        orderCatalog.DeleteOrder();
                        break;
                    case "print":
                        orderCatalog.PrintOrders();
                        break;
                    case "afslut":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ugyldigt valg");
                        break;
                }
            }
        }
    }
}

