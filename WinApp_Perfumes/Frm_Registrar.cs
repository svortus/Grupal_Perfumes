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

        private void Btn_Rsgt_Click(object sender, EventArgs e)
        {
            dataSet11.ReadXml(Application.StartupPath + "\\Perfumes.xml");
            object[] vec = new object[8];
            vec[0] = int.Parse(Txt_Cedula.Text);
            vec[1] = Txt_Nombre.Text; 
            vec[2] = Txt_Apellido.Text;
            vec[3] = Cbx_Ciudad.SelectedItem;
            vec[4] = Txt_Edad.Text;
            vec[5] = Convert.ToDateTime(Txt_Fecha.Text);
            vec[6] = Txt_Correo.Text;
            vec[7] = Txt_Clave2.Text;
            dataSet11.Tbl_Usuario.Rows.Add(vec);
            dataSet11.Tbl_Usuario.WriteXml(Application.StartupPath + "\\Perfumes.xml");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Txt_Nombre.PasswordChar = '\0';
                Txt_Apellido.PasswordChar = '\0';
            }
            else
            {
                Txt_Nombre.PasswordChar = '*';
                Txt_Apellido.PasswordChar = '*';
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
