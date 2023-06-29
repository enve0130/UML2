using System;
using System.Collections.Generic;

namespace UMLII
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vi instansierer objekter af alle klasser, for at initatileserer systemet
            MenuCatalog menuCatalog = new MenuCatalog();
            CustomerCatalog customerCatalog = new CustomerCatalog();

            Pizza pizza1 = new Pizza(1, "MARGHERITA", 77, "Tomato and cheese");
            Pizza pizza2 = new Pizza(2, "VESUVIO", 88, "Tomato, cheese, and ham");
            Pizza pizza3 = new Pizza(3, "CAPRICCIOSA", 93, "Tomato, cheese, ham, and mushroom");

            menuCatalog.AddPizza(pizza1);
            menuCatalog.AddPizza(pizza2);
            menuCatalog.AddPizza(pizza3);

            Customer customer1 = new Customer("Hans", 12121212);
            Customer customer2 = new Customer("Martin", 23232323);
            Customer customer3 = new Customer("Louise", 34343434);

            customerCatalog.AddCustomer(customer1);
            customerCatalog.AddCustomer(customer2);
            customerCatalog.AddCustomer(customer3);

            Order order1 = new Order(1, new List<Pizza> { pizza1, pizza2 }, customer1);
            Order order2 = new Order(2, new List<Pizza> { pizza2, pizza3 }, customer2);
            Order order3 = new Order(3, new List<Pizza> { pizza3, pizza3 }, customer3);

            //Denne klasse tager to argumenter for sin konstruktor, fordi de skal bruges til, at
            //ordreCatolog objektet kan skabe en ny kunde i forbindelse med oprettelse af en ny ordre,
            //og for at finde og tilføje pizzaer fra menuCatalog objektet. 
            OrderCatalog orderCatalog = new OrderCatalog(menuCatalog, customerCatalog);

            orderCatalog.AddOrder(order1);
            orderCatalog.AddOrder(order2);
            orderCatalog.AddOrder(order3);

            
            UserInterface ui = new UserInterface(menuCatalog, customerCatalog, orderCatalog);
            ui.Run();
        }
    }
}