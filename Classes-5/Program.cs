using System;

namespace Classes_5
{
    class Program
    {
        static void Main(string[] args)
        {
            User patient = new User
            {
                Login = "user",
                FirstName = "First",
                LastName = "Last",
                Age = 125
            };
            
            Console.WriteLine("Login: {0}; \nFirst Name: {1}; \nLast Name: {2}; \nAge: {3}; \nFilling date: {4}",patient.Login, patient.FirstName, patient.LastName, patient.Age, patient.FillingDate.ToString("d"));
            Console.ReadLine();
        }
    }

    class User
    {
        private string login, firstName, lastName;
        private int age;
        private readonly DateTime fillingDate = DateTime.Now;        

        public string Login { get => login; set => login = value; }
        public int Age { get => age; set => age = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public DateTime FillingDate => fillingDate;
    }
}
