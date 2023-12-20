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
