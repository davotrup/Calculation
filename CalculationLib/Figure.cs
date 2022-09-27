using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLib
{
    public class Figure
    {
        public float Area { get; set; }
        public virtual double GetArea(){ return Area; }
        public void GetInfo()
        {
            Console.WriteLine("Area = {0}",GetArea());
        }
    }
}
