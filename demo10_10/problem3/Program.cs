using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
    class Program
    {
        //this is the main program
        static void Main(string[] args)
        {
            //regions stay inside of main
            #region region 1
            // the printerPrintsCondition can be just "cond1, cond2, cond3"
            // in that case label with comments like in the nested loops
            for (int printerPrintsCondition = 0; printerPrintsCondition <= 1; printerPrintsCondition++)
            {
                // cond2 = red light is flashing
                for (int cond2 = 0; cond2 <=1; cond2++)
                {
                    // cond3 = printer is recognized by computer
                    for (int cond3=0; cond3 <=1; cond3++)
                    {
                        if(printerPrintsCondition == 0 && cond2 == 0 && cond3 == 0)
                        {
                            // print out conditions
                            Console.WriteLine("Printer Prints Condition: NO"); // this can go within methods too
                            // call action methods
                        }
                        if(printerPrintsCondition == 0 && cond2 == 0 && cond3 == 1)
                        {
                            // call action methods
                            // printer jam?
                        }
                    }
                }
            }
            #endregion

            #region region 2
            for (int i = 0; i <=7; i++)
            {
                switch (i)
                {
                    case 0:
                        // print out conditions
                        // call action methods for NO, No, NO
                        break;
                   // case 1:
                        
                }
            }
            #endregion
        }

        // create all methods here (first one is already created)
        public void CheckInk()
        {
            Console.WriteLine("Check Ink and Replace if Empty");
        }
    }
}
