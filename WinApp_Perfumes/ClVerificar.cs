using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Perfumes
{
    internal class ClVerificar
    {
        string ci;
        public ClVerificar(string cedula)
        {
            this.ci = cedula;
        }
        public bool Validacion()
        {
            if (ci.Length != 10)
            {
                MessageBox.Show("La Cédula debe tener 10 dígitos");
            }
            string digitos = ci.Substring(0, 9);
            int suma = 0;
            for (int i = 0; i < 9; i++)
            {
                int digito = int.Parse(digitos[i].ToString());
                if (i % 2 == 0)
                {
                    digito *= 2;
                    if (digito > 9)
                    {
                        digito -= 9;
                    }
                }
                suma += digito;
            }

            int residuo = suma % 10;
            int digitoVerificador = (residuo == 0) ? 0 : 10 - residuo;
            return digitoVerificador == int.Parse(ci[9].ToString());
        }
    }
}
