using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Employee
    {
        // field
        private string empName;

        // properties; usually capitalized
        public string Name
        {
            // a property has two pre-defined methods: get and set
            get { return empName; }
            set
            {
                // perform validation
                // predefined parameter : value instead of reg. parameters
                if (value.Length > 15) { empName = value.Substring(0, 15); }
                else empName = value;
            }
            
        }
        // automatic properties
        // if you don't need to validate, then use auto. properties
        // no fields created by programmer; they are created by compiler
        // implicitly
        public int ID { get; set; }
        public double Pay { get; set; }

        public void Printstate()
        {
            // referencing field
            Console.WriteLine("Name:\t{0}", empName);
            // referencing property (alt. method)
            Console.WriteLine("Name:\t{0}", Name);
            Console.WriteLine("ID:\t{0}", ID);
            Console.WriteLine("Pay:\t{0}", Pay);
        }
    }
}
