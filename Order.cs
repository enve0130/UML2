using System;
namespace UMLII
{
	public class Order
    {
        public int OrderId { get; set; }
        private List<Pizza> pizzas; 

        public List<Pizza> Pizzas 
        {
            get { return pizzas; }
            set { pizzas = value; }
        }
        public Customer Customer { get; set; }
        private const double TaxRate = 0.25;
        private const double DeliveryCost = 40;

        public Order(int orderId, List<Pizza> pizzas, Customer customer)
        {
            OrderId = orderId;
            Pizzas = pizzas;
            Customer = customer;
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (Pizza pizza in Pizzas)
            {
                totalPrice += pizza.Price;
            }
            totalPrice += totalPrice * TaxRate;
            totalPrice += DeliveryCost;
            return totalPrice;
        }

        public override string ToString()
        {
            string pizzasString = Pizzas != null ? string.Join(", ", Pizzas) : string.Empty;
            return $"Ordre ID: {OrderId}, Kunde: {this.Customer}, Pizzaer: {pizzasString}, Total pris: {CalculateTotalPrice()}";
        }
    }
}

