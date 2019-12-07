using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address personAddress = new Address
            {
                Index = "X0E0L0",
                Country = "CA",
                City = "Fort Providence",
                Street = "Magnetic Drive",
                House = "401",
                Apartment = "Unit2"
            };


        Console.WriteLine("Index: " + personAddress.Index);
            Console.WriteLine("Country: " + personAddress.Country);
            Console.WriteLine("City: " + personAddress.City);
            Console.WriteLine("Street: " + personAddress.Street);
            Console.WriteLine("House: " + personAddress.House);
            Console.WriteLine("Apartment: " + personAddress.Apartment);
            Console.ReadLine();

        }
    }

    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public string House
        {
            get
            {
                return house;
            }

            set
            {
                house = value;
            }
        }

        public string Apartment
        {
            get
            {
                return apartment;
            }

            set
            {
                apartment = value;
            }
        }
    }

}
