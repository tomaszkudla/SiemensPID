using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensPID
{
    class OscillatingObject
    {
        public double A { get; private set; } = 1.0;//?? not necessery now
        public double B { get; private set; } = 1.0;
        public double w { get; private set; } = 1.0;

        public OscillatingObject(double A, double B, double w)
        {
            this.A = A; 
            this.B = B;
            this.w = w;
        }

        public OscillatingObject()
        { }

        public double X(double F)
        {
            return F * Math.Exp(F) * Math.Cos(F);
        }
    }
}
