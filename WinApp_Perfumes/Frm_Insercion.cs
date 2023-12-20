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
    public partial class Frm_Insercion : Form
    {
        public Frm_Insercion()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txBxCodigo.Clear();
            txBxNombre.Clear();
            CboxTipos.SelectedIndex = -1;
            rchtxtBxDescripcion.Clear();
            txBxPrecio.Clear();
            txBxCantidad.Clear();
            txBxIva.Clear();
            txBxFactura.Clear();
            CboxE_entrega.SelectedIndex = -1;
        }

        private void ManejarPulsacionEnter(TextBox textBox, Control siguienteControl, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("El campo no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (string.IsNullOrWhiteSpace(txBxCodigo.Text))
                    {
                        MessageBox.Show("Código no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        e.Handled = true;
                    }
                    else
                    {
                        rchtxtBxDescripcion.Focus();
                    }
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
                        MessageBox.Show("Código no puede estar vacío.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Error al procesar la entrada del campo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txBxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    ManejarPulsacionEnter(txBxPrecio, txBxCantidad, e);
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

        private void txBxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    txBxIva.Focus();
                }
                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Ingrese solo números enteros en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al procesar la entrada del campo: " + ex.Message);
            }
        }

        private void txBxIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    CalcularYActualizarTotal();
                    txBxFactura.Focus();
                }
                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Por favor, ingrese solo números enteros en el campo de IVA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string nuevoTexto = txBxIva.Text + e.KeyChar;

                    if (!string.IsNullOrEmpty(nuevoTexto) && !int.TryParse(nuevoTexto, out _))
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarError("Se produjo un error al procesar la entrada del campo: " + ex.Message);
            }
        }

        private void CalcularYActualizarTotal()
        {
            try
            {
                double precio = double.TryParse(txBxPrecio.Text, out double parsedPrecio) ? parsedPrecio : 0.0;
                int cantidad = int.TryParse(txBxCantidad.Text, out int parsedCantidad) ? parsedCantidad : 0;
                double iva = double.TryParse(txBxIva.Text, out double parsedIVA) ? parsedIVA : 0.0;

                ClsOperaciones operaciones = new ClsOperaciones();
                operaciones.EstablecerPrecio(precio);
                operaciones.EstablecerCantidad(cantidad);
                operaciones.EstablecerIVA(iva);

                double totalConIVA = operaciones.CalcularTotalConIVA();
                lblTotal.Text = $" {totalConIVA.ToString("C")}";
            }
            catch (Exception ex)
            {
                MostrarError("Se produjo un error al calcular el total: " + ex.Message);
            }
        }

        private void txBxFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    CboxE_entrega.Focus();
                }
                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Ingrese solo números en el campo de cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al procesar la entrada del campo: " + ex.Message);
            }
        }

        private void CboxE_entrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btnIngresar.Focus();
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al procesar la entrada del campo: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Código para el botón Ingresar
        }

        
    }
}
