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
    public partial class ReportePerfume_NomTip : Form
    {
        public ReportePerfume_NomTip()
        {
            InitializeComponent();
            dataSet1.ReadXml(Application.StartupPath + "\\Perfumes.xml");
        }

        private void ReportePerfume_NomTip_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
