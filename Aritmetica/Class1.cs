using System;

namespace Aritmetica
{
    public class MisMates
    {
        private double a;
        private double b;
        private double r;
        /// <summary>
        /// MisMates recives two values of type double
        /// </summary>
        /// <param name="pA"></param>
        /// <param name="pB"></param>
        public MisMates(double pA, double pB)
        {
            a = pA;
            b = pB;
            r = 0;
        }

        public double R { get { return r; } }
        
        public double suma()
        {
            r = a + b;
            return r;
        }

        public double resta()
        {
            r = a - b;
            return r;
        }

        public double multi()
        {
            r = a * b;
            return r;
        }

        public double div()
        {
            r = a / b;
            return r;
        }
    }
}
