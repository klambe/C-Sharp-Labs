using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab4
{
    class ModuleCAResults
    {
        private const int MAX_CA_RESULTS = 50;
        private double[] scores = new double[MAX_CA_RESULTS];
        private int currentIndex = 0;
        public string ModuleName { get; set; }

        public int NumberOfCredits { get; set; }

        public string StudentName { get; set; }

       

        public double this[int i]
        {
            set
            {                
                    scores[checkValidityOfIndex(i)] = value;
                    currentIndex++;
            }
            get
            {             
                   return scores[checkValidityOfIndex(i)];                
            }
        }

        private int checkValidityOfIndex(int i)
        {
            int index = i - 1;
            if (index >= 0 | index <= scores.Length)
            {
                return index;
            }
            else
            {
                throw new ArgumentException("Index out of bounds exception");
            }

        }

        public override string ToString()
        {
            string fullDetails = "Module Name: " + ModuleName + "\nStudent Name: " + StudentName 
                + "\nNumber Of Credits: " + NumberOfCredits;
            for (int i = 0; i < currentIndex; i++)
            {
                fullDetails += "\nResult for CA" + (i+1) + ": " + scores[i];
            }
            return fullDetails;
        }



    }
}
