using System;
using System.Collections.Generic;

namespace PrintColor
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine("Enter text:");
            s = Console.ReadLine();

            Console.WriteLine("Select color number:");
            foreach (Colors colorElements in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{colorElements} - {(int)colorElements}");
            }
            int userColor = Convert.ToInt32(Console.ReadLine());
            Colors _color;
            switch (userColor)
            {
                case 0: _color = Colors.Green;                    
                    break;
                case 1: _color = Colors.Yellow;
                    break;
                case 2: _color = Colors.Magenta;
                    break;
                default: Console.WriteLine("Wrong color code");
                    _color = Colors.Gray;
                    break;
            }

            int colorCode = 0;

            
            PrintClass.Print(s, PrintClass.GetColorName(_color, colorCode));
            Console.ReadLine();

        }
    }

    public enum Colors {Green, Yellow, Magenta, Gray}

    static class PrintClass
    {
        static public Dictionary<Colors, ConsoleColor> colorSet = new Dictionary<Colors, ConsoleColor>() {
            { Colors.Green, ConsoleColor.Green},
            {Colors.Magenta,ConsoleColor.Magenta},
            { Colors.Yellow, ConsoleColor.Yellow} };

       static public int GetColorName(Colors colors, int _color)
        {
            return _color = (int)colorSet[colors];
        }
        static public void Print (string s, int color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(s);
        }
    }

}
