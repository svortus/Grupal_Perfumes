using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp_Perfumes.Properties;

namespace WinApp_Perfumes
{
    public partial class Frm_Insercion : Form
    {
        public Frm_Insercion()
        {
            InitializeComponent();
            DataSet1 dataSet = new DataSet1();
            dataSet.WriteXml(Application.StartupPath + "\\Perfumes.xml");
        }

        private void ManejarPulsacionEnter(TextBox textBox, Control siguienteControl, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MostrarError("El campo no puede estar vacío.");
                        e.Handled = true;
                    }
                    else
                    {
                        siguienteControl.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al procesar la entrada del campo: " + ex.Message);
            }
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txBxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManejarPulsacionEnter(txBxCodigo, txBxNombre, e);
        }

        private void txBxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ManejarPulsacionEnter(txBxNombre, CboxTipos, e);
        }

        private void CboxTipos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(CboxTipos.Text)) // Corregir para verificar CboxTipos en lugar de txBxCodigo
                    {
                        MessageBox.Show("El campo no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                    }
                    else
                    {
                        txBxPrecio.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al procesar la entrada del campo: " + ex.Message);
            }
        }

        private void txBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ManejarPulsacionEnter(txBxPrecio, rchtxtBxDescripcion, e);
                }
                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true;
                    MessageBox.Show("Ingrese solo números en el campo de precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (e.KeyChar == '.' && txBxPrecio.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al procesar la entrada del campo: " + ex.Message);
            }
        }

        private void rchtxtBxDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(txBxCodigo.Text))
                    {
                        // Mostrar un mensaje si el campo está vacío
                        MessageBox.Show("El campo no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                    }
                    else
                    {
                        btnIngresar.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar la entrada del campo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Utiliza el bloque using para asegurarte de liberar recursos adecuadamente
                using (DataSet1 dataSet = new DataSet1())
                {
                    string filePath = Path.Combine(Application.StartupPath, "Perfumes.xml");
                    dataSet.ReadXml(filePath);

                    DataRow newRow = dataSet.Tbl_Perfume.NewRow();
                    newRow["Cod_perfume"] = txBxCodigo.Text;
                    newRow["Nom_perfume"] = txBxNombre.Text;
                    newRow["Tipo_perfume"] = CboxTipos.Text;
                    newRow["Precio_perfume"] = txBxPrecio.Text;
                    newRow["Descrip_perfume"] = rchtxtBxDescripcion.Text;

                    dataSet.Tbl_Perfume.Rows.Add(newRow);

                    // Guardar los cambios
                    dataSet.WriteXml(filePath);

                    Frm_Factura objFac = new Frm_Factura();
                    objFac.CodPerfume = txBxCodigo.Text;
                    objFac.PrecioPerfume = txBxPrecio.Text;
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error: " + ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txBxCodigo.Clear();
            txBxNombre.Clear();
            CboxTipos.SelectedIndex = -1;
            rchtxtBxDescripcion.Clear();
            txBxPrecio.Clear();
        }

        private void Frm_Insercion_Load(object sender, EventArgs e)
        {

        }
    }
}
