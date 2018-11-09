namespace formProd_prove
{
    partial class FormProd_prove
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblidpp = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnGuardarpp = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblProd_prove = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.dgvpp = new System.Windows.Forms.DataGridView();
            this.btneliminarpp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpp)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(548, 304);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblidpp);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.btnGuardarpp);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Controls.Add(this.txtPrecio);
            this.tabPage1.Controls.Add(this.lblcantidad);
            this.tabPage1.Controls.Add(this.lblprecio);
            this.tabPage1.Controls.Add(this.lblProd_prove);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblidpp
            // 
            this.lblidpp.AutoSize = true;
            this.lblidpp.Location = new System.Drawing.Point(37, 53);
            this.lblidpp.Name = "lblidpp";
            this.lblidpp.Size = new System.Drawing.Size(18, 13);
            this.lblidpp.TabIndex = 13;
            this.lblidpp.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(122, 47);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 12;
            // 
            // btnGuardarpp
            // 
            this.btnGuardarpp.Location = new System.Drawing.Point(96, 204);
            this.btnGuardarpp.Name = "btnGuardarpp";
            this.btnGuardarpp.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarpp.TabIndex = 11;
            this.btnGuardarpp.Text = "Guardar";
            this.btnGuardarpp.UseVisualStyleBackColor = true;
            this.btnGuardarpp.Click += new System.EventHandler(this.btnGuardarpp_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(122, 118);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(122, 80);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(36, 125);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 8;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(36, 88);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 7;
            this.lblprecio.Text = "Precio";
            // 
            // lblProd_prove
            // 
            this.lblProd_prove.AutoSize = true;
            this.lblProd_prove.Location = new System.Drawing.Point(75, 21);
            this.lblProd_prove.Name = "lblProd_prove";
            this.lblProd_prove.Size = new System.Drawing.Size(162, 13);
            this.lblProd_prove.TabIndex = 6;
            this.lblProd_prove.Text = "Registro de Producto_Proveedor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneliminarpp);
            this.tabPage2.Controls.Add(this.btneditar);
            this.tabPage2.Controls.Add(this.btnbuscar);
            this.tabPage2.Controls.Add(this.txtbuscar);
            this.tabPage2.Controls.Add(this.lblbuscar);
            this.tabPage2.Controls.Add(this.dgvpp);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(540, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(359, 32);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(260, 33);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(102, 33);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(34, 36);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 1;
            this.lblbuscar.Text = "Buscar";
            // 
            // dgvpp
            // 
            this.dgvpp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpp.Location = new System.Drawing.Point(46, 86);
            this.dgvpp.Name = "dgvpp";
            this.dgvpp.Size = new System.Drawing.Size(378, 150);
            this.dgvpp.TabIndex = 0;
            // 
            // btneliminarpp
            // 
            this.btneliminarpp.Location = new System.Drawing.Point(450, 33);
            this.btneliminarpp.Name = "btneliminarpp";
            this.btneliminarpp.Size = new System.Drawing.Size(75, 23);
            this.btneliminarpp.TabIndex = 5;
            this.btneliminarpp.Text = "Eliminar";
            this.btneliminarpp.UseVisualStyleBackColor = true;
            this.btneliminarpp.Click += new System.EventHandler(this.btneliminarpp_Click);
            // 
            // FormProd_prove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 363);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProd_prove";
            this.Text = "FormProd_prove";
            this.Load += new System.EventHandler(this.FormProd_prove_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblidpp;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnGuardarpp;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblProd_prove;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.DataGridView dgvpp;
        private System.Windows.Forms.Button btneliminarpp;

    }
}