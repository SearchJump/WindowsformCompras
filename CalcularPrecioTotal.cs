using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    public class CalcularPrecioTotal
    {
        public static double Resultado;
        public double Calcular(int cantidadProducto, double precioProducto)
        {
            Resultado = cantidadProducto * precioProducto;
            return cantidadProducto * precioProducto;
        }
    }
}