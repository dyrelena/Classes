using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {   
            Converter curConvert = new Converter(24, 26, 0.37);
            bool fromTo;

            Console.WriteLine("Выберите действие: \nобменять иностранную валюту на гривну - нажмите 1  \nобменять гривну на иностранную валюту - нажмите 2");
            string answer = Console.ReadLine();
            if(answer == "1")
            {
                fromTo = true;
            }
            else
            {
                fromTo = false;
            }

            curConvert.UsdToUah(fromTo);
            Console.ReadLine();
        }
    }

    class Converter
    {
        double usd, eur, rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void UsdToUah(bool fromTo)
        {
            double res, sum;
            string currencyName;
            Console.WriteLine("Сколько?");
            sum = Convert.ToDouble(Console.ReadLine());

            if (fromTo)
            {
                Console.WriteLine("В какой валюте (usd, eur, rub):");
                currencyName = Console.ReadLine();

                switch (currencyName)
                {
                    case "usd":
                        res = sum * usd;
                        break;
                    case "eur":
                        res = sum * eur;
                        break;
                    case "rub":
                        res = sum * rub;
                        break;
                    default:
                        res = sum;
                        break;
                }

                Console.WriteLine("{0} {1} = {2} грн.", sum, currencyName, res);
            }
            else
            {
                Console.WriteLine("На какую валюту (usd, eur, rub):");
                currencyName = Console.ReadLine();

                switch (currencyName)
                {
                    case "usd":
                        res =Math.Round(sum / usd,2);
                        break;
                    case "eur":
                        res = Math.Round(sum / eur, 2);
                        break;
                    case "rub":
                        res = Math.Round(sum / rub, 2);
                        break;
                    default:
                        res = sum;
                        break;
                }
                Console.WriteLine("{0} грн. = {1} {2} ", sum, res, currencyName);
            }
        }

    }
}
