using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld 
{
    class Student : User
    {
        public Student(string nameIn, double salaryIn, int ageIn) : base(nameIn, salaryIn, ageIn)
        {
            //Base(nameIn, salaryIn, ageIn);

        }


    }
}
