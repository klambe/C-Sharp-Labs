using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca12016
{
    public interface ICartable
    {
         string ProductCode { get; }
         string ProductDescription { get; }
         double ProductPrice { get; }
    }
}
