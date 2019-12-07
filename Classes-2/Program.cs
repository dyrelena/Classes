using System;

namespace Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;
            Console.WriteLine("Введите длину стороны 1:");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину стороны 2:");
            side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rec1 = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника = " + rec1.Area);
            Console.WriteLine("Периметр прямоугольника = " + rec1.Perimeter);
            Console.ReadLine();
        }
    }

    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }

        private double PerimeterCalculator()
        {
            double perimeter = 2 * (side1 + side2);
            return perimeter;
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
     }
}
