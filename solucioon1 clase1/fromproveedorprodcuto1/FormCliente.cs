﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using capaNegocio;


namespace formCliente
{
    public partial class FormCliente : Form
    {
        
        public FormCliente()
        {
            InitializeComponent();
        }
        logicaNegocioCliente lN = new logicaNegocioCliente();

        private void FormCliente_Load(object sender, EventArgs e)
        {
            
            txtid.Visible = false;
            lblid.Visible = false;
            dgvcliente.DataSource = lN.ListarClientes();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            
            List<cliente> lista = lN.BuscaClienteDatos(txtbuscar.Text);
            dgvcliente.DataSource = lista;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            txtid.Enabled = false;
            lblid.Visible = true;

            txtNombres.Text = dgvcliente.CurrentRow.Cells["nombres"].Value.ToString();
            txtDireccion.Text = dgvcliente.CurrentRow.Cells["direccion"].Value.ToString();
            txtTelefono.Text = dgvcliente.CurrentRow.Cells["telefono"].Value.ToString();
            txtid.Text = dgvcliente.CurrentRow.Cells["idcliente"].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
            btnguardarcli.Text = "Actualizar";
        }

        private void btnguardarcli_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (btnguardarcli.Text == "Guardar")
                {
                    cliente objcliente = new cliente();
                    objcliente.nombres = txtNombres.Text;
                    objcliente.direccion = txtDireccion.Text;
                    objcliente.telefono = txtTelefono.Text;

                    if (lN.insertarCliente(objcliente) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvcliente.DataSource = lN.ListarClientes();
                        txtDireccion.Text = "";
                        txtNombres.Text = "";
                        txtTelefono.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al agregar cliente"); }
                }
                if (btnguardarcli.Text == "Actualizar")
                {
                    cliente objcliente = new cliente();
                    objcliente.idcliente = Convert.ToInt32(txtid.Text);
                    objcliente.nombres = txtNombres.Text;
                    objcliente.direccion = txtDireccion.Text;
                    objcliente.telefono = txtTelefono.Text;


                    if (lN.EditarCliente(objcliente) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dgvcliente.DataSource = lN.ListarClientes();
                        txtDireccion.Text = "";
                        txtNombres.Text = "";
                        txtTelefono.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al actualizar cliente"); }

                    btnguardarcli.Text = "Guardar";

                }
            }
            catch
            {
                MessageBox.Show("Errorrrrrr!");
            }
        
        }

        private void btneliminar2_Click(object sender, EventArgs e)
        {
            int idcliente = Convert.ToInt32(dgvcliente.CurrentRow.Cells["idcliente"].Value.ToString());

            try
            {
                if (lN.EliminarCliente(idcliente) > 0)
                {
                    MessageBox.Show("Eliminado con exito!");
                    dgvcliente.DataSource = lN.ListarClientes();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar cliente");
            }
        }
    }
}
