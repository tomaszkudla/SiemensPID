using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensPID
{
    class Trend
    {
        Queue<double> qOUT  = new Queue<double>(new double[1000]);
        public double[] OUT { get; private set; } = new double[1000];

        Queue<double> qSP = new Queue<double>(new double[1000]);
        public double[] SP { get; private set; } = new double[1000];

        Queue<double> qPV = new Queue<double>(new double[1000]);
        public double[] PV { get; private set; } = new double[1000];


        public void AddPoints(double pvY, double spY, double outY)
        {
            qPV.Enqueue(pvY);
            qPV.Dequeue();
            PV = qPV.ToArray();

            qSP.Enqueue(spY);
            qSP.Dequeue();
            SP = qSP.ToArray();

            qOUT.Enqueue(outY);
            qOUT.Dequeue();
            OUT = qOUT.ToArray();
        }
    }
}
