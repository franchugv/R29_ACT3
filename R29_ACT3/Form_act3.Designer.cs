namespace R29_ACT3
{
    partial class Form_act3
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.TextEntradaNombre = new System.Windows.Forms.TextBox();
            this.TextEntradaApellidos = new System.Windows.Forms.TextBox();
            this.TextEntradaEdad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(28, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(114, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre del Usuario/a:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(28, 63);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(119, 13);
            this.labelApellidos.TabIndex = 1;
            this.labelApellidos.Text = "Apellidos del Usuario/a:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(28, 105);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(102, 13);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "Edad del Usuario/a:";
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(175, 147);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(118, 23);
            this.botonAceptar.TabIndex = 3;
            this.botonAceptar.Text = "ACEPTAR";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // TextEntradaNombre
            // 
            this.TextEntradaNombre.Location = new System.Drawing.Point(175, 22);
            this.TextEntradaNombre.Name = "TextEntradaNombre";
            this.TextEntradaNombre.Size = new System.Drawing.Size(225, 20);
            this.TextEntradaNombre.TabIndex = 4;
            this.TextEntradaNombre.TextChanged += new System.EventHandler(this.Validacion_TextBox);
            // 
            // TextEntradaApellidos
            // 
            this.TextEntradaApellidos.Location = new System.Drawing.Point(175, 60);
            this.TextEntradaApellidos.Name = "TextEntradaApellidos";
            this.TextEntradaApellidos.Size = new System.Drawing.Size(225, 20);
            this.TextEntradaApellidos.TabIndex = 5;
            this.TextEntradaApellidos.TextChanged += new System.EventHandler(this.Validacion_TextBox);
            // 
            // TextEntradaEdad
            // 
            this.TextEntradaEdad.Location = new System.Drawing.Point(175, 105);
            this.TextEntradaEdad.Name = "TextEntradaEdad";
            this.TextEntradaEdad.Size = new System.Drawing.Size(225, 20);
            this.TextEntradaEdad.TabIndex = 6;
            this.TextEntradaEdad.TextChanged += new System.EventHandler(this.Validacion_TextBox);
            // 
            // Form_act3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 182);
            this.Controls.Add(this.TextEntradaEdad);
            this.Controls.Add(this.TextEntradaApellidos);
            this.Controls.Add(this.TextEntradaNombre);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Name = "Form_act3";
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox TextEntradaNombre;
        private System.Windows.Forms.TextBox TextEntradaApellidos;
        private System.Windows.Forms.TextBox TextEntradaEdad;
    }
}

