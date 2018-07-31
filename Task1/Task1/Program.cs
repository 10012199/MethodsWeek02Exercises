using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = 0;
                        
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please choose the operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            string operation = Console.ReadLine();
        
            switch (operation)
            {
                case "1":
                    result = Math.Addition(num1,num2);
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                    break;

                case "2":
                    result = Math.Subtraction(num1,num2);
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                    break;
                
                case "3":
                    result = Math.Multiplication(num1,num2);
                    Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                    break;

                 case "4":
                    result = Math.Division(num1,num2);
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }        
    }
        
    public static class Math
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
