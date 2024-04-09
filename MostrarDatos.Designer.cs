namespace Compras
{
    partial class MostrarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MostrarDescripcion = new System.Windows.Forms.TextBox();
            this.MostrarPrecio = new System.Windows.Forms.TextBox();
            this.MostrarFecha = new System.Windows.Forms.TextBox();
            this.MostrarTipo = new System.Windows.Forms.TextBox();
            this.MostrarCantidad = new System.Windows.Forms.TextBox();
            this.PrecioTotal = new System.Windows.Forms.TextBox();
            this.Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MostrarDescripcion
            // 
            this.MostrarDescripcion.Location = new System.Drawing.Point(118, 113);
            this.MostrarDescripcion.Name = "MostrarDescripcion";
            this.MostrarDescripcion.Size = new System.Drawing.Size(100, 20);
            this.MostrarDescripcion.TabIndex = 0;
            this.MostrarDescripcion.TextChanged += new System.EventHandler(this.MostrarDescripcion_TextChanged);
            // 
            // MostrarPrecio
            // 
            this.MostrarPrecio.Location = new System.Drawing.Point(118, 280);
            this.MostrarPrecio.Name = "MostrarPrecio";
            this.MostrarPrecio.Size = new System.Drawing.Size(100, 20);
            this.MostrarPrecio.TabIndex = 1;
            // 
            // MostrarFecha
            // 
            this.MostrarFecha.Location = new System.Drawing.Point(338, 113);
            this.MostrarFecha.Name = "MostrarFecha";
            this.MostrarFecha.Size = new System.Drawing.Size(100, 20);
            this.MostrarFecha.TabIndex = 2;
            // 
            // MostrarTipo
            // 
            this.MostrarTipo.Location = new System.Drawing.Point(594, 113);
            this.MostrarTipo.Name = "MostrarTipo";
            this.MostrarTipo.Size = new System.Drawing.Size(100, 20);
            this.MostrarTipo.TabIndex = 3;
            // 
            // MostrarCantidad
            // 
            this.MostrarCantidad.Location = new System.Drawing.Point(594, 280);
            this.MostrarCantidad.Name = "MostrarCantidad";
            this.MostrarCantidad.Size = new System.Drawing.Size(100, 20);
            this.MostrarCantidad.TabIndex = 4;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.Location = new System.Drawing.Point(338, 376);
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.Size = new System.Drawing.Size(100, 20);
            this.PrecioTotal.TabIndex = 5;
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(594, 376);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio Total";
            // 
            // MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.PrecioTotal);
            this.Controls.Add(this.MostrarCantidad);
            this.Controls.Add(this.MostrarTipo);
            this.Controls.Add(this.MostrarFecha);
            this.Controls.Add(this.MostrarPrecio);
            this.Controls.Add(this.MostrarDescripcion);
            this.Name = "MostrarDatos";
            this.Text = "MostrarDatos";
            this.Load += new System.EventHandler(this.MostrarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox MostrarDescripcion;
        public System.Windows.Forms.TextBox MostrarPrecio;
        public System.Windows.Forms.TextBox MostrarFecha;
        public System.Windows.Forms.TextBox MostrarTipo;
        public System.Windows.Forms.TextBox MostrarCantidad;
        public System.Windows.Forms.TextBox PrecioTotal;
        public System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}