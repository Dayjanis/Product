namespace formCompra
{
    partial class FormCompra
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
            this.lblidcompra = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnguardarcom = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtprecioC = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblprecioC = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblregcompra = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.dgvcompra = new System.Windows.Forms.DataGridView();
            this.btneliminarc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompra)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(541, 333);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblidcompra);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Controls.Add(this.btnguardarcom);
            this.tabPage1.Controls.Add(this.txtcantidad);
            this.tabPage1.Controls.Add(this.txtprecioC);
            this.tabPage1.Controls.Add(this.txtfecha);
            this.tabPage1.Controls.Add(this.lblcantidad);
            this.tabPage1.Controls.Add(this.lblprecioC);
            this.tabPage1.Controls.Add(this.lblfecha);
            this.tabPage1.Controls.Add(this.lblregcompra);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblidcompra
            // 
            this.lblidcompra.AutoSize = true;
            this.lblidcompra.Location = new System.Drawing.Point(41, 48);
            this.lblidcompra.Name = "lblidcompra";
            this.lblidcompra.Size = new System.Drawing.Size(18, 13);
            this.lblidcompra.TabIndex = 17;
            this.lblidcompra.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 16;
            // 
            // btnguardarcom
            // 
            this.btnguardarcom.Location = new System.Drawing.Point(107, 204);
            this.btnguardarcom.Name = "btnguardarcom";
            this.btnguardarcom.Size = new System.Drawing.Size(75, 23);
            this.btnguardarcom.TabIndex = 15;
            this.btnguardarcom.Text = "Guardar";
            this.btnguardarcom.UseVisualStyleBackColor = true;
            this.btnguardarcom.Click += new System.EventHandler(this.btnguardarcom_Click_1);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(124, 151);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(48, 20);
            this.txtcantidad.TabIndex = 14;
            // 
            // txtprecioC
            // 
            this.txtprecioC.Location = new System.Drawing.Point(124, 109);
            this.txtprecioC.Name = "txtprecioC";
            this.txtprecioC.Size = new System.Drawing.Size(100, 20);
            this.txtprecioC.TabIndex = 13;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(124, 74);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 12;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(22, 158);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(49, 13);
            this.lblcantidad.TabIndex = 11;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblprecioC
            // 
            this.lblprecioC.AutoSize = true;
            this.lblprecioC.Location = new System.Drawing.Point(22, 116);
            this.lblprecioC.Name = "lblprecioC";
            this.lblprecioC.Size = new System.Drawing.Size(44, 13);
            this.lblprecioC.TabIndex = 10;
            this.lblprecioC.Text = "PrecioC";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(22, 81);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(37, 13);
            this.lblfecha.TabIndex = 9;
            this.lblfecha.Text = "Fecha";
            // 
            // lblregcompra
            // 
            this.lblregcompra.AutoSize = true;
            this.lblregcompra.Location = new System.Drawing.Point(104, 12);
            this.lblregcompra.Name = "lblregcompra";
            this.lblregcompra.Size = new System.Drawing.Size(105, 13);
            this.lblregcompra.TabIndex = 8;
            this.lblregcompra.Text = "Registro de Compras";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneliminarc);
            this.tabPage2.Controls.Add(this.btneditar);
            this.tabPage2.Controls.Add(this.btnbuscar);
            this.tabPage2.Controls.Add(this.txtbuscar);
            this.tabPage2.Controls.Add(this.lblbuscar);
            this.tabPage2.Controls.Add(this.dgvcompra);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(336, 33);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(75, 23);
            this.btneditar.TabIndex = 4;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(239, 35);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(95, 37);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(24, 37);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(40, 13);
            this.lblbuscar.TabIndex = 1;
            this.lblbuscar.Text = "Buscar";
            // 
            // dgvcompra
            // 
            this.dgvcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompra.Location = new System.Drawing.Point(6, 91);
            this.dgvcompra.Name = "dgvcompra";
            this.dgvcompra.Size = new System.Drawing.Size(384, 201);
            this.dgvcompra.TabIndex = 0;
            // 
            // btneliminarc
            // 
            this.btneliminarc.Location = new System.Drawing.Point(444, 33);
            this.btneliminarc.Name = "btneliminarc";
            this.btneliminarc.Size = new System.Drawing.Size(75, 23);
            this.btneliminarc.TabIndex = 5;
            this.btneliminarc.Text = "Eliminar";
            this.btneliminarc.UseVisualStyleBackColor = true;
            this.btneliminarc.Click += new System.EventHandler(this.btneliminarc_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblidcompra;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnguardarcom;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtprecioC;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblprecioC;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblregcompra;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.DataGridView dgvcompra;
        private System.Windows.Forms.Button btneliminarc;

    }
}