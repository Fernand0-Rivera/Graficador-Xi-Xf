using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using info.lundin.math;
namespace Graficador_1{
    internal class Graficas{
        private double xi, xf;
        private int n;
        private double[] x;
        private double[] y;

        public Graficas(int n) {
            this.n = n;
            x = new double[n];
            y = new double[n];
        }
        public double[] X { 
            set { x = value; }
            get { return x; }
        }
        public double[] Y { 
            set { y = value; }
            get { return y; }
        }
        public double fu(double x) {
            double r;
            r = Math.Cos(x);
            return r;
        }
        public void Graficador (double xi, double xf) {
            double h;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++){
                X[k] = xi + k * h;
                Y[k] = fu(X[k]);
            }
        }

    }
}
