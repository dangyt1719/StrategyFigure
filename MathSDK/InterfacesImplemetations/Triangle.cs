using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathSDK.Interfaces;

namespace MathSDK.InterfacesImplemetations
{
    public class Triangle:IFigure
    {
        private double _a { get; set; }
        private double _b { get; set; }
        private double _c { get; set; }

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public double Area()
        {
            var p = (_a + _b + _c) / 2d;
            var s= p*(p-_a)*(p-_b)*(p-_c);
            return Math.Sqrt(s<0? 0: s);
        }
    }
}
