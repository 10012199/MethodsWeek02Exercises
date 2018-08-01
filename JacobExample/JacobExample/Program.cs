using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JacobExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstName me = new FirstName("Georgette");
            Console.WriteLine(me.Fname);
            Console.ReadLine();
        }
    }    
}
