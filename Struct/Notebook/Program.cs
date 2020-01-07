using System;

namespace Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("VivoBook 15", "ASUS", 14299.00);
            notebook.DosplayInfo();
            Console.ReadLine();
        }
    }

    struct Notebook
    {
        public string model;
        public string producer;
        public double price;
       public Notebook(string model, string producer, double price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }
        public void DosplayInfo()
        {
            Console.WriteLine($"Model: {model} Producer: {producer} Price: {price}");
        }
    }
}
