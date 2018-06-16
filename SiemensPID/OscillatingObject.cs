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
        long ticksInit;
        double[] oldX;

        public OscillatingObject(double A, double B, double w)
        {
            this.A = A; 
            this.B = B;
            this.w = w;
        }

        public OscillatingObject()
        {
            ticksInit = DateTime.Now.Ticks;
            oldX=new double[2];
        }

        public double X(double F)
        {
            //double result = 0.01*F * Math.Exp(0.00005*F*(DateTime.Now.Ticks-ticksInit)) * Math.Cos(F);
            long t1 = DateTime.Now.Ticks - ticksInit;
            double t = (double)t1 / 100000000.0;
            //double result1 = F * Math.Cos(F) * Math.Exp(F*0.07) ;
            double result1 = F/100;
            double result = result1 + 0.995* oldX[1] - 0.995 * (oldX[0] - oldX[1]);
            if (result > 100.0) result = 100.0;
            else if (result < -100.0) result = -100.0;
            oldX[0] = oldX[1];
            oldX[1] = result;
            return result;
        }
    }
}
