﻿using System;
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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void inserciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Insercion objInsertar = new Frm_Insercion();
            objInsertar.Show();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Factura objFactura = new Frm_Factura();
            objFactura.Show();
        }

        private void eliminacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EliminacionBusqueda objEliminacion = new Frm_EliminacionBusqueda();
            objEliminacion.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscarEditar objBE = new Frm_BuscarEditar();
            objBE.Show();
        }
    }
}
