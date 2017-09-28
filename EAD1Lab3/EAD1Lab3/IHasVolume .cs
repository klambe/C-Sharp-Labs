using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAD1Lab3
{
     interface IHasVolume
    {

         string TypeOfShape
        {
            get;
            set;            
        }
        
        double calculateVolume();

        //string ToString();      


    }
}
