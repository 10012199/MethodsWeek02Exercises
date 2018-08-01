using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1 - Calculate circle area");
                Console.WriteLine("2 - Calculate square area");
                Console.WriteLine("3 - Exit");
                string selection = Console.ReadLine();

                int radius = 0;

                switch (selection)
                {
                    case "1":
                        break;
                       
                    case "2":
                        break;

                    default:
                        break;
                }

            } while (true);
        }
    }
    public static class Circle
    {
        public static int GetCircleValues()
        {
            Console.WriteLine("Please enter the circle's radius");
            int radius = int.Parse(Console.ReadLine());
            return radius;
        }
        public static double CalcCircleArea(double radius)
        {
            return 3.14 * Math.Pow(radius, 2);
        }
    }
    public static class Square
    {

    }
}
