using System;
namespace UMLII
{
    public class CustomerCatalog
    {
        private List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }


        public void CreateCustomer()
        {
            Console.WriteLine("Indtast navn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast telefonnummer");
            int phoneNumber = int.Parse(Console.ReadLine());
            Customer customer = new Customer(name, phoneNumber);
            AddCustomer(customer);
        }

        public void ReadCustomer()
        {
            Console.WriteLine("Indtast kundens navn");
            string name = Console.ReadLine();
            Customer customer = SearchCustomer(name);
            Console.WriteLine();
            if (customer != null)
            {
                Console.WriteLine(customer.ToString());
            }
            else
            {
                Console.WriteLine("Kunde ikke fundet");
            }
        }

        public Customer SearchCustomer(string name)
        {
            return customers.Find(c => c.Name == name);
        }

        public void UpdateCustomer()
        {
            Console.WriteLine("Indtast kundens navn");
            string name = Console.ReadLine();
            Console.WriteLine("Indtast telefonnummer");
            int phoneNumber = int.Parse(Console.ReadLine());
            Customer customer = new Customer(name, phoneNumber);
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Name == name)
                {
                    customer.Name = name;
                    customers[i] = customer;
                    break;
                }
            }
        }

        public void DeleteCustomer()
        {
            Console.WriteLine("Indtast kundens navn");
            string name = Console.ReadLine();
            bool success = RemoveCustomer(name);
            if (success)
            {
                Console.WriteLine("Kunde slettet");
            }
            else
            {
                Console.WriteLine("Kunde ikke fundet");
            }
        }

        private bool RemoveCustomer(string name)
        {
            Customer customerToRemove = customers.Find(x => x.Name == name);
            if (customerToRemove != null)
            {
                customers.Remove(customerToRemove);
                return true;
            }
            return false;
        }

        public void PrintCustomers()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
        }
    }
}

