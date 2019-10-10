using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fields
{
    class Employee
    {
        // fields
        private string empName;
        private int empID;
        private double currPay;

        // accessor and mutator methods
        public string GetName() { return empName; }
        public int GetEmpID() { return empID; }
        public double GetCurrPay() { return currPay; }

        // mutators begin here
        public void SetName(string name)
        {
            // perform validation
            // if name is greater than 15, then take the characters that are indexed
            // 0-14 and return that portion of the string 
            if (name.Length > 15) { empName = name.Substring(0, 15); }
            // if the name is less than or equal to 15 then just take the characters
            // entered (all of them)
            else empName = name;
        }

        public void SetEmpID(int id) { empID = id; }
        public void SetCurrPay(double pay) { currPay = pay; }

        // other method
        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", empName);
            Console.WriteLine("ID:\t{0}", empID);
            Console.WriteLine("Pay:\t{0}", currPay);
        }
    }
}
