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
    public partial class Frm_Eliminacion : Form
    {
        private string codigo;
        public Frm_Eliminacion(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            MostrarDetallesPerfume(codigo);
        }

        private void MostrarDetallesPerfume(string codigo)
        {

            DataSet1 dataSet = new DataSet1();
            dataSet.ReadXml(Application.StartupPath + "\\Perfumes.xml");

            DataRow perfumeRow = dataSet.Tbl_Perfume.SingleOrDefault(row => row.Cod_perfume == codigo);

            if (perfumeRow != null)
            {
                lblCodigo.Text = perfumeRow["Cod_perfume"].ToString();
                lblNombre.Text = perfumeRow["Nom_perfume"].ToString();
                lblTipo.Text = perfumeRow["Tipo_perfume"].ToString();
                lblPrecio.Text = perfumeRow["Precio_perfume"].ToString();
                lblDescripcion.Text = perfumeRow["Descrip_Perfume"].ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Confirmar si el usuario realmente desea eliminar el perfume
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este perfume?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Lógica para eliminar el perfume del archivo XML
                EliminarPerfumeDelXML(codigo);
                MessageBox.Show("El perfume ha sido eliminado.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario después de eliminar
                this.Close();
            }
        }

        private void EliminarPerfumeDelXML(string codigo)
        {
            // Lógica para eliminar el perfume del archivo XML
            // Debes implementar esta función según la estructura de tu XML
            // Puedes usar XmlDocument o LINQ to XML para realizar esta eliminación.

            // Ejemplo básico (puedes ajustar según tu estructura XML):
            DataSet1 dataSet = new DataSet1();
            dataSet.ReadXml(Application.StartupPath + "\\Perfumes.xml");

            DataRow perfumeRow = dataSet.Tbl_Perfume.SingleOrDefault(row => row.Cod_perfume == codigo);

            if (perfumeRow != null)
            {
                perfumeRow.Delete();
                dataSet.WriteXml(Application.StartupPath + "\\Perfumes.xml");
            }
        }
    }
}
