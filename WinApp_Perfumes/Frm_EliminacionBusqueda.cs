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
    public partial class Frm_EliminacionBusqueda : Form
    {
        public Frm_EliminacionBusqueda()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            // Verificar si el código existe en el archivo XML
            if (CodigoExisteEnXML(codigo))
            {
                // Mostrar el formulario con los detalles y opción de eliminación
                Frm_Eliminacion frm_Eliminacion = new Frm_Eliminacion(codigo);
                frm_Eliminacion.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("El código no existe.", "Código no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CodigoExisteEnXML(string codigo)
        {
            
            DataSet1 dataSet = new DataSet1();
            dataSet.ReadXml(Application.StartupPath + "\\Perfumes.xml");

            return dataSet.Tbl_Perfume.Any(row => row.Cod_perfume == codigo);
        }
    }
}
