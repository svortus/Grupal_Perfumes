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
    public partial class Frm_BuscarEditar : Form
    {
        public Frm_BuscarEditar()
        {
            InitializeComponent();
        }

        private void BuscarBt_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml(Application.StartupPath + "\\PERFUMES.xml");
            System.Data.DataRow[] VecA;
            System.Data.DataRow[] Vec2;

            VecA = dataSet11.Tbl_Perfume.Select("Cod_perfume='" + txBxCodigo.Text + "'");

            if (VecA.Length > 0)
            {
                Frm_Editar objEd = new Frm_Editar(VecA);
                if (objEd.ShowDialog() == DialogResult.OK)
                {
                    Vec2 = VecA;
                    objEd.ActualiData(Vec2);
                    Vec2[0].AcceptChanges();
                    dataSet11.Tbl_Perfume.WriteXml(Application.StartupPath + "\\PERFUMES.xml");
                    this.Close();
                    objEd.Close();
                }
                else if (objEd.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                    objEd.Close();
                }
            }
            else MessageBox.Show("Datos inexistentes\n" + "Ingrese correctamente", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
