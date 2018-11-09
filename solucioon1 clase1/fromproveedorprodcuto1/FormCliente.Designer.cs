namespace formCliente
{
    partial class FormCliente
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
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnguardarcli = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblregistrclient = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dgvcliente = new System.Windows.Forms.DataGridView();
            this.btneliminar2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblid);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Controls.Add(this.btnguardarcli);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.txtNombres);
            this.tabPage1.Controls.Add(this.lbltelefono);
            this.tabPage1.Controls.Add(this.lbldireccion);
            this.tabPage1.Controls.Add(this.lblnombres);
            this.tabPage1.Controls.Add(this.lblregistrclient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(38, 58);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 17;
            this.lblid.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(109, 55);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 16;
            // 
            // btnguardarcli
            // 
            this.btnguardarcli.Location = new System.Drawing.Point(109, 227);
            this.btnguardarcli.Name = "btnguardarcli";
            this.btnguardarcli.Size = new System.Drawing.Size(75, 23);
            this.btnguardarcli.TabIndex = 15;
            this.btnguardarcli.Text = "Guardar";
            this.btnguardarcli.UseVisualStyleBackColor = true;
            this.btnguardarcli.Click += new System.EventHandler(this.btnguardarcli_Click_1);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(109, 171);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(109, 142);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 13;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(109, 103);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(100, 20);
            this.txtNombres.TabIndex = 12;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(25, 171);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(49, 13);
            this.lbltelefono.TabIndex = 11;
            this.lbltelefono.Text = "Telefono";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(22, 142);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(52, 13);
            this.lbldireccion.TabIndex = 10;
            this.lbldireccion.Text = "Direccion";
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(25, 103);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(49, 13);
            this.lblnombres.TabIndex = 9;
            this.lblnombres.Text = "Nombres";
            // 
            // lblregistrclient
            // 
            this.lblregistrclient.AutoSize = true;
            this.lblregistrclient.Location = new System.Drawing.Point(93, 16);
            this.lblregistrclient.Name = "lblregistrclient";
            this.lblregistrclient.Size = new System.Drawing.Size(101, 13);
            this.lblregistrclient.TabIndex = 8;
            this.lblregistrclient.Text = "Registro de Clientes";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneliminar2);
            this.tabPage2.Controls.Add(this.btneditar);
            this.tabPage2.Controls.Add(this.btnbuscar);
            this.tabPage2.Controls.Add(this.lblbuscar);
            this.tabPage2.Controls.Add(this.txtbuscar);
            this.tabPage2.Controls.Add(this.dgvcliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(320, 32);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 5;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(233, 31);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 4;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(24, 37);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 3;
            this.lblbuscar.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(89, 31);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dgvcliente
            // 
            this.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcliente.Location = new System.Drawing.Point(24, 78);
            this.dgvcliente.Name = "dgvcliente";
            this.dgvcliente.Size = new System.Drawing.Size(371, 188);
            this.dgvcliente.TabIndex = 0;
            // 
            // btneliminar2
            // 
            this.btneliminar2.Location = new System.Drawing.Point(429, 31);
            this.btneliminar2.Name = "btneliminar2";
            this.btneliminar2.Size = new System.Drawing.Size(75, 23);
            this.btneliminar2.TabIndex = 6;
            this.btneliminar2.Text = "Eliminar";
            this.btneliminar2.UseVisualStyleBackColor = true;
            this.btneliminar2.Click += new System.EventHandler(this.btneliminar2_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 418);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnguardarcli;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblregistrclient;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dgvcliente;
        private System.Windows.Forms.Button btneliminar2;

    }
}