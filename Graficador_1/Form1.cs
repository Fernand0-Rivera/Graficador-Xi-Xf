using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using info.lundin.math;
namespace Graficador_1{
    public partial class Form1 : Form{
        double xi, xf;
        int n;
        public Form1(){
            InitializeComponent();
            n = chart1.Width;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void BtnFirma_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start("Firma_2");

        private void Btgraficar_Click(object sender, EventArgs e){
            xi = double.Parse(tBxi.Text);
            xf = double.Parse(tBxf.Text);

            Graficas gr1 = new Graficas(n);
            gr1.Graficador(xi, xf);

            for (int k = 0; k < n; k++) {
                chart1.Series["Series1"].Points.AddXY(gr1.X[k], gr1.Y[k]);
            }
        }
    }
}
