using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Perfumes
{
    public partial class Frm_Reportes : Form
    {
        public Frm_Reportes()
        {
            InitializeComponent();
        }

        private void Reporte1_Click(object sender, EventArgs e)
        {
            ReportePerfume_CodNom objR1 = new ReportePerfume_CodNom();
            objR1.ShowDialog();
        }

        private void Reporte2_Click(object sender, EventArgs e)
        {
            ReportePerfume_NomTip objR2 = new ReportePerfume_NomTip();
            objR2.ShowDialog();
        }

        private void Reporte3_Click(object sender, EventArgs e)
        {
            ReportePerfume_NomPrec objR3 = new ReportePerfume_NomPrec();
            objR3.ShowDialog();
        }
    }
}
