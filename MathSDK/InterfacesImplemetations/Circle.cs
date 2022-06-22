using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathSDK.Interfaces;

namespace MathSDK.InterfacesImplemetations
{
    public class Circle:IFigure
    {
        private double _r { get; set; }

        public Circle(double r)
        {
            _r = r;
        }
        public double Area()
        {
            return Math.PI*Math.Pow(_r,2);
        }
    }
}
