namespace fromproveedorprodcuto1
{
    partial class FormProveedor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneliminar1 = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.lblid);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.lbNombre);
            this.tabPage1.Controls.Add(this.lbDireccion);
            this.tabPage1.Controls.Add(this.lbtelefono);
            this.tabPage1.Controls.Add(this.btGuardar);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(699, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(77, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(170, 20);
            this.txtid.TabIndex = 17;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(33, 41);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 16;
            this.lblid.Text = "ID";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(74, 130);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(77, 95);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 20);
            this.txtDireccion.TabIndex = 14;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(19, 68);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(49, 13);
            this.lbNombre.TabIndex = 13;
            this.lbNombre.Text = "Nombres";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(19, 95);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 12;
            this.lbDireccion.Text = "Direccion\r\n";
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Location = new System.Drawing.Point(19, 137);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(49, 13);
            this.lbtelefono.TabIndex = 11;
            this.lbtelefono.Text = "Telefono";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(67, 173);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 10;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(170, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registro de Proveedores";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneliminar1);
            this.tabPage2.Controls.Add(this.btneditar);
            this.tabPage2.Controls.Add(this.btnbuscar);
            this.tabPage2.Controls.Add(this.txtbuscar);
            this.tabPage2.Controls.Add(this.lblBuscar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(699, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btneliminar1
            // 
            this.btneliminar1.Location = new System.Drawing.Point(544, 20);
            this.btneliminar1.Name = "btneliminar1";
            this.btneliminar1.Size = new System.Drawing.Size(75, 23);
            this.btneliminar1.TabIndex = 6;
            this.btneliminar1.Text = "Eliminar";
            this.btneliminar1.UseVisualStyleBackColor = true;
            this.btneliminar1.Click += new System.EventHandler(this.btneliminar1_Click);
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(433, 20);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(339, 20);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(75, 24);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(220, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(17, 24);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 455);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btneliminar1;

    }
}

