namespace FormCompras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblregistro = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblprecioC = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtprecioC = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblregistro
            // 
            this.lblregistro.AutoSize = true;
            this.lblregistro.Location = new System.Drawing.Point(111, 29);
            this.lblregistro.Name = "lblregistro";
            this.lblregistro.Size = new System.Drawing.Size(100, 13);
            this.lblregistro.TabIndex = 0;
            this.lblregistro.Text = "Registro de Compra";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(12, 67);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(37, 13);
            this.lblfecha.TabIndex = 1;
            this.lblfecha.Text = "Fecha";
            // 
            // lblprecioC
            // 
            this.lblprecioC.AutoSize = true;
            this.lblprecioC.Location = new System.Drawing.Point(12, 109);
            this.lblprecioC.Name = "lblprecioC";
            this.lblprecioC.Size = new System.Drawing.Size(44, 13);
            this.lblprecioC.TabIndex = 2;
            this.lblprecioC.Text = "PrecioC";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(12, 164);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 3;
            this.lblcantidad.Text = "Cantidad";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(77, 60);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 4;
            // 
            // txtprecioC
            // 
            this.txtprecioC.Location = new System.Drawing.Point(77, 106);
            this.txtprecioC.Name = "txtprecioC";
            this.txtprecioC.Size = new System.Drawing.Size(100, 20);
            this.txtprecioC.TabIndex = 5;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(77, 157);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 6;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(102, 210);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
           
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecioC);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblprecioC);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblregistro);
            this.Name = "Form1";
            this.Text = "Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregistro;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblprecioC;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtprecioC;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnguardar;
    }
}

