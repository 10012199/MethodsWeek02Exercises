using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person employee1 = new Person("Georgette", "De Souza", 1000, 5, "1234");
            Console.WriteLine(employee1.LastName);
            Console.ReadLine();            
        }
    }
}