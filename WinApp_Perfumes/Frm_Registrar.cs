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
    public partial class Frm_Registrar : Form
    {
        string usur, clv, auxcl, usc, clc;

        private void Txt_Cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Txt_Nombre.Focus();
                try
                {
                    string cedula = Txt_Cedula.Text;
                    ClVerificar objV = new ClVerificar(cedula);
                    if (objV.Validacion())
                    {

                        MessageBox.Show("La cédula ingresada ha sido verificada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("La cédula ingresada no es correcta");
                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese numeros validos");
                }
            }
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Txt_Apellido.Focus();
            }
        }

        private void DtTm_Fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Cbx_Ciudad.Focus();
            }
        }

        private void Txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DtTm_Fecha.Focus();
            }
        }

        private void DtTm_Fecha_ValueChanged(object sender, EventArgs e)
        {
            int edad = DateTime.Now.Year - DtTm_Fecha.Value.Year;
            
            Txt_Edad.Text = edad.ToString();
        } 

        private void Cbx_Ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Txt_Correo.Focus();
            }
        }

        private void Txt_Correo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Txt_Clave.Focus();
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Txt_Clave2.Focus();
            }
        }

        private void Txt_Clave2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_Rsgt.Focus();
            }
        }

        private void Btn_Rsgt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Btn_Rsgt_Click(sender, e);
            }
        }

        private void Btn_Rsgt_Click(object sender, EventArgs e)
        {

            try 
            {
                if (Txt_Correo.Text != "" && Txt_Clave.Text != "" && Txt_Clave2.Text != "")
                {
                    clv = Txt_Clave.Text;
                    auxcl = Txt_Clave2.Text;
                    usur = Txt_Correo.Text;
                    if (clv == auxcl)
                    {
                        usc = usur;
                        clc = clv;

                        dataSet11.ReadXml(Application.StartupPath + "\\Perfumes.xml");
                        object[] vec = new object[8];
                        vec[0] = int.Parse(Txt_Cedula.Text);
                        vec[1] = Txt_Nombre.Text;
                        vec[2] = Txt_Apellido.Text;
                        vec[3] = Cbx_Ciudad.SelectedItem;
                        vec[4] = int.Parse(Txt_Edad.Text);
                        vec[5] = DtTm_Fecha.Value;
                        vec[6] = Txt_Correo.Text;
                        vec[7] = Txt_Clave2.Text;
                        dataSet11.Tbl_Usuario.Rows.Add(vec);
                        dataSet11.Tbl_Usuario.WriteXml(Application.StartupPath + "\\Perfumes.xml");

                        MessageBox.Show("Resgisto exitoso");
                        Form1 objF1 = new Form1(usc, clv);
                        objF1.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La clave no es igual");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese correo y claves correctas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_Correo.Focus();
                }
                
                
            }
            catch 
            {
                MessageBox.Show("ERROR");
            }

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Txt_Clave.PasswordChar = '\0';
                Txt_Clave2.PasswordChar = '\0';
            }
            else
            {
                Txt_Clave.PasswordChar = '*';
                Txt_Clave2.PasswordChar = '*';
            }
        }

        public Frm_Registrar(string us, string cl)
        {
            InitializeComponent();
            this.usc = us;
            this.clc = cl;
        }

        private void Frm_Registrar_Load(object sender, EventArgs e)
        {

        }
    }
}
