using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensPID
{
    class OscillatingObject
    {
        double[] oldX;  //old value memory

        public OscillatingObject()
        {
            oldX=new double[2]; 
        }

        public double X(double F)
        {
            double result1 = F/100;
            double result = result1 + 0.995* oldX[1] - 0.995 * (oldX[0] - oldX[1]); //  randomly picked coefficient
            if (result > 100.0) result = 100.0;
            else if (result < -100.0) result = -100.0;
            oldX[0] = oldX[1];
            oldX[1] = result;
            return result;
        }
    }
}
