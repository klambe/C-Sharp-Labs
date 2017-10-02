using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab4
{
    class Program
    {
        static void Main()
        {
            //Calculator c1 = new Calculator();

            Console.WriteLine("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            double num3 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter forth number: ");
            double num4 = Double.Parse(Console.ReadLine());

            try { 
            double firstCalc = Calculator.divideCalc(num1, num2);

            double secondCalc = Calculator.divideCalc(num3, num4);

                Console.WriteLine("Result1: " + firstCalc);

                Console.WriteLine("Result1: " + secondCalc);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception caught");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception caught");

            }

            try
            {
                ModuleCAResults results = new ModuleCAResults() { ModuleName = "Python", NumberOfCredits = 10, StudentName = "Kevin Lambe" };
                results[1] = 20;                    // new result for CA1
                results[2] = 40;
                results[3] = 60;
                results[1] = 25;                    // overwrite
                results[3] = 65;                    // overwrite
                results[4] = 99;

                Console.WriteLine(results);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
