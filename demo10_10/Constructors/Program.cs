using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // example of overloading a constructor
            Employee e = new Employee();
            e.Printstate();
            Console.WriteLine();

            Employee e2 = new Employee("Bill Baker");
            e2.Printstate();
            Console.WriteLine();

            Employee e3 = new Employee("Bill", 509509, 1234.50);
            e3.Printstate();
        }
    }
}
