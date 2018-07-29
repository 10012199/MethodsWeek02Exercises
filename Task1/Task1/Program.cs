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

            int num1 = 0;
            int num2 = 0;
            
            //MultiplyNumsTask1A(num1,num2);

            Console.WriteLine("Enter first number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = int.Parse(Console.ReadLine());
            
            int result = Math.MultiplyNumsTask1B(num1,num2);

            Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
            Console.ReadLine();            
        }

        /*static void MultiplyNumsTask1A(int num1, int num2)
        {

            Console.WriteLine("Enter first number:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1*num2));
            Console.ReadLine();
        } */       
    }
    public static class Math
    {
        public static int MultiplyNumsTask1B(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
