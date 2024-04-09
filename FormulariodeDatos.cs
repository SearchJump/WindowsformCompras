using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compras
{
    public partial class FormulariodeDatos : Form
    {
        public FormulariodeDatos()
        {
            InitializeComponent();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            


            // Obtiene los datos del formulario
            string descripcionProducto = Descripcion.Text;
            double precioProducto = double.Parse(Precio.Text);
            DateTime fechaCompra = DateTime.Parse(Fecha.Text);
            string tipoProducto = Tipo.Text;
            int cantidadProducto = int.Parse(Cantidad.Text);
            double precioTotal;
            // Calcula el precio total
            CalcularPrecioTotal calc = new CalcularPrecioTotal();
            precioTotal =calc.Calcular(cantidadProducto, precioProducto);
            // Cierra el formulario
            this.Close();


            // Muestra los datos en el formulario de mostrar datos
            MostrarDatos formularioMostrarDatos = new MostrarDatos();
            formularioMostrarDatos.MostrarDescripcion.Text = descripcionProducto;
            formularioMostrarDatos.MostrarPrecio.Text = precioProducto.ToString();
            formularioMostrarDatos.MostrarFecha.Text = fechaCompra.ToString();
            formularioMostrarDatos.MostrarTipo.Text = tipoProducto;
            formularioMostrarDatos.MostrarCantidad.Text = cantidadProducto.ToString();
            formularioMostrarDatos.PrecioTotal.Text = precioTotal.ToString();
            formularioMostrarDatos.ShowDialog();


        }

        private void Descripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
