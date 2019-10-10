using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object
            Employee e = new Employee();

            // for property
            e.Name = "William I. Baker";
            e.ID = 509509;
            e.Pay = 1234.50;

            e.Printstate();
        }
    }
}
