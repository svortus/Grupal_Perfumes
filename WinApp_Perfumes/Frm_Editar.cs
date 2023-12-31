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
    public partial class Frm_Editar : Form
    {
        public Frm_Editar(System.Data.DataRow[] VecB)
        {
            InitializeComponent();

            txBxNombre.Text = VecB[0]["Nom_perfume"].ToString();
            CboxTipos.Text = VecB[0]["Tipo_perfume"].ToString();
            txBxPrecio.Text = VecB[0]["Precio_perfume"].ToString();
            rchtxtBxDescripcion.Text = VecB[0]["Descrip_perfume"].ToString();
        }

        public void ActualiData(System.Data.DataRow[] VecND)
        {
            VecND[0]["Nom_perfume"] = txBxNombre.Text;
            VecND[0]["Tipo_perfume"] = CboxTipos.Text;
            VecND[0]["Precio_perfume"] = txBxPrecio.Text;
            VecND[0]["Descrip_perfume"] = rchtxtBxDescripcion;
        }

        private void EditarBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void Frm_Editar_Load(object sender, EventArgs e)
        {

        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
