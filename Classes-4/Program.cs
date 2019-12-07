using System;

namespace Classes_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure triangle = new Figure(new Point(4, 4, "A"), new Point(4, -4, "B"), new Point(-3, -3, "C"));
            Figure rectangle = new Figure(new Point(4, 4, "A"), new Point(4, -4, "B"), new Point(-3, -3, "C"), new Point(-3, 4, "D"));
            Figure pentagon = new Figure(new Point(4, 4, "A"), new Point(4, -4, "B"), new Point(-3, -3, "C"), new Point(-3, 4, "D"), new Point(-6, 0, "E"));
            double trianglePerimetr, rectanglePerimetr, pentagonPerimetre;

            triangle.PerimeterCalculator(out trianglePerimetr);
            rectangle.PerimeterCalculator(out rectanglePerimetr);
            pentagon.PerimeterCalculator(out pentagonPerimetre);

            Console.WriteLine("Периметр треугольника: {0}", trianglePerimetr);
            Console.WriteLine("Периметр четырехугольника: {0}", rectanglePerimetr);
            Console.WriteLine("Периметр пятиугольника: {0}", pentagonPerimetre);
            Console.ReadLine();


        }
    }

    class Point
    {
        int x, y;
        string lable;

        public Point(int x, int y, string lable)
        {
            this.x = x;
            this.y = y;
            this.lable = lable;
        }
        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public string Lable
        {
            get
            {
                return lable;
            }
        }
    }
    class Figure
    {
        private Point[] points = new Point[5];
        public Figure(Point a1, Point a2, Point a3)
        {
            points[0] = a1;
            points[1] = a2;
            points[2] = a3;

        }
        public Figure(Point a1, Point a2, Point a3, Point a4) : this(a1, a2, a3)
        {
            points[3] = a4;
        }
        public Figure(Point a1, Point a2, Point a3, Point a4, Point a5) : this(a1, a2, a3, a4)
        {
            points[4] = a5;

        }
        //double lengthSide;
        public static double LengthSide(Point A, Point B)
        {
            double lengthSide = Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
            return lengthSide;
            //Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }

        public void PerimeterCalculator(out double result)
        {
            int i = 2;
            result = LengthSide(points[0], points[1]);
            for (; i < points.Length; i++)
            {
                if (points[i] != null)
                {
                    result += LengthSide(points[i-1], points[i]);                    
                }  
                else
                {
                    break;
                }
            }
            result += LengthSide(points[i - 1], points[0]);
        }

    }
}
