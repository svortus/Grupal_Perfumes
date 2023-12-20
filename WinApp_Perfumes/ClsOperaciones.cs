using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_Perfumes
{
    internal class ClsOperaciones
    {
        private double iva;
        private double precio;
        private int cantidad;
        private double total;

        public ClsOperaciones() { }

        public void EstablecerIVA(double iva)
        {
            this.iva = iva;
        }

        public void EstablecerPrecio(double precio)
        {
            this.precio = precio;
        }

        public void EstablecerCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public double CalcularTotalConIVA()
        {
            double totalConIVA = precio * cantidad * (1 + (iva / 100));
            total = Math.Round(totalConIVA, 2); // Redondea a dos decimales
            return total;
        }

        public double CalcularTotalSinIVA()
        {
            total = precio * cantidad;
            return total;
        }

        public double ObtenerTotal()
        {
            return total;
        }
    }
}
