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
    public partial class Form1 : Form
    {
        string usuario = "", clave = "", usc, clc;
        
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml(Application.StartupPath + "\\Perfumes.xml");
            clave = Txt_Clave.Text;
            usuario = Txt_Usuario.Text;
            string datCorreo = Convert.ToString(dataSet11.Tbl_Usuario.Select("Correo='"+ usc +"'"));
            string datClave = Convert.ToString(dataSet11.Tbl_Usuario.Select("Clave='"+ clc +"'"));
            if (usuario == "Master" && clave == "1234")
            {

                Frm_Menu objFM = new Frm_Menu();
                objFM.ShowDialog();
                this.Visible = false;


            }
            else if 
            (usuario ==  datCorreo && clave == datClave)
            {

                Frm_Menu objFM = new Frm_Menu();
                objFM.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void LkL_Rsgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Registrar objFR = new Frm_Registrar(usc, clc);
            objFR.Show();
        }

        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Txt_Clave.Focus();
            }
        }

        private void Txt_Clave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Btn_Ingresar.Focus();
            }
        }

        private void Btn_Ingresar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Btn_Ingresar_Click(sender,e);
            }
        }

        private void Cbx_Mc_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbx_Mc.Checked)
            {
                Txt_Clave.PasswordChar = '\0';
            }
            else
            {
                Txt_Clave.PasswordChar = '*';
            }
        }

        public Form1(string us, string cl)
        {
            InitializeComponent();
            this.usc = us;
            this.clc = cl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
