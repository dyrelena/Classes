using System;
using System.Collections.Generic;

namespace Employee
{
    class Program
    {

        static void Main(string[] args)
        {
            const double minSalary = 4173;
            
            Employee salesManager = new Employee("Иванов", "Вольдемар");
            salesManager.WorkStart = new DateTime (2012, 7, 20);

            Dictionary<string, double> positionAndRate = new Dictionary<string, double>();
            positionAndRate.Add("менеджер", 2);
            positionAndRate.Add("продажник", 1.5);
            positionAndRate.Add("вахтер", 1);

            salesManager.Position = "менеджер";

            TimeSpan experience = (DateTime.Now - salesManager.WorkStart);
            double experenceYear = experience.Days/365.25;

            int experenceRate = ExperienceRate(experenceYear);
            salesManager.SalaryAndTax(minSalary, positionAndRate, experenceRate, out double salary, out double tax);

            Console.WriteLine("Информация о сферическом сотруднике:\nФамилия: {0}\nИмя: {1}\nДолжность: {2}" +
                "\nОклад: {3}\nНалоговый сбор: {4}",  salesManager.LastName, salesManager.FirstName, salesManager.Position, salary, tax);
            Console.ReadLine();
            
        }

        public static int ExperienceRate(double experenceYear)
        {
            int experenceRate;
            if (experenceYear > 0 && experenceYear <= 3) experenceRate = 1;
            else if (experenceYear <= 5) experenceRate = 2;
            else if (experenceYear > 5) experenceRate = 3;
            else experenceRate = 0;

            return experenceRate;
        }
    }

    class Employee
    {
        string lastName, firstName;
        DateTime workStart;
        string position;
        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public DateTime WorkStart { get => workStart; set => workStart = value; }
        public string Position { get => position; set => position = value; }
        public string LastName { get => lastName; }
        public string FirstName { get => firstName;  }

        public void SalaryAndTax(double minSalary, Dictionary<string, double> positionRate, int experienceRate, out double salary, out double tax)
        {
            salary = minSalary * positionRate[Position] * experienceRate;
            tax = salary * 0.18;
        }
    }

}
