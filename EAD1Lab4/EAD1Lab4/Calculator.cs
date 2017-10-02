using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab4
{
    class Calculator
    {

        public static double divideCalc(double firstNum, double secondNum)
        {
            if(secondNum == 0)
            {
                throw new ArgumentException("Error cannot divide by 0!");
            }
            else
            {
                return firstNum / secondNum;
            }
            

        }
    }
}
