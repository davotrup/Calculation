using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLib
{
    public class Triangle:Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool CheckExistence()
        {
            if ((a < b + c) && (b < a + c) && (c < a + b))
                return true;
            else return false;
        }
        public override double GetArea()
        {
            try
            {
                if (!CheckExistence())
                    throw new Exception("The triangle does not exist!!!");
                if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                    Console.WriteLine("The triangle is rectangular");
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
