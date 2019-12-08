using System;
using System.Collections.Generic;

namespace Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> articlesPrice = new Dictionary<string, double>();
            articlesPrice.Add("ball", 15.50);
            articlesPrice.Add("new year tree", 3500.00);
            articlesPrice.Add("doll Santa Claus", 500.00);
            
            Invoice order = new Invoice(1, "Customer", "Provider");
            order.Article = "new year tree";
            order.Quantity = 5;

            order.CountOrder(order.Quantity, articlesPrice, out double sum, out double withTax);
            Console.WriteLine("Счет №{0}\nДля: {1}\tОт: {2}\nТовар: {3}\t{4} шт.\nСумма товара: {5}\n" +
                "Сумма к оплате с НДС: {6}",order.account, order.customer, order.provider, order.Article, order.Quantity, sum, withTax);
            Console.ReadLine();
        }
    }

    class Invoice
    {
       public readonly int account;
        public readonly string customer;
        public readonly string provider;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private string article;
        private int quantity;

        public string Article { get => article; set => article = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public void CountOrder(int quantity, Dictionary<string, double>articlesPrice, out double sum, out double withTax)
        {
            sum = quantity * articlesPrice[Article];
            withTax = sum * 1.18;
        }


    }


}
