﻿using System;
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
    public partial class MostrarDatos : Form
    {
        public MostrarDatos()
        {
            InitializeComponent();
            
        }

        private void MostrarDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            // Cierra el formulario
            this.Close();
        }

        private void MostrarDatos_Load(object sender, EventArgs e)
        {
        }
    }
}
