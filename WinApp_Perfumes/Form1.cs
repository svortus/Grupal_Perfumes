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
            clave = Txt_Clave.Text;
            usuario = Txt_Usuario.Text;
            if (usuario == "Master" && clave == "1234")
            {

                Frm_Menu objFM = new Frm_Menu();
                objFM.ShowDialog();
                this.Visible = false;


            }
            else if (usuario == usc && clave == clc)
            {

                //Frm_Menu objFM = new Frm_Menu();
                //objFM.ShowDialog();//c
                //this.Visible = false;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }

        private void LkL_Rsgt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Frm_Registrar objFR = new Frm_Registrar(usc, clc);
            //objFR.Show();
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
