using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object
            // Employee() method - compiler will create a default constructor
            Employee employee = new Employee();

            // method call
            employee.Hello();
        }
    }
}
