using System;
namespace UMLII
{

    public class Customer
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }

        public Customer(string name, int phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return $"Navn: {Name}, Telefonnummer: {PhoneNumber}";
        }
    }
}

