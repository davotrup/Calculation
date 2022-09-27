using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLib
{
    public class Circle:Figure
    {
        public double r { get; set; }
        public Circle(double radius)
        {
            this.r = radius;
        }
        public override double GetArea()
        {
            return Math.PI * r * r;
        }
    }
}
