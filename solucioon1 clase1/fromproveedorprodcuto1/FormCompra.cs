using System;
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
using formCliente;

namespace formCompra
{
    public partial class FormCompra : Form
    {
        logicaNegocioCompra lN =new logicaNegocioCompra();
        public FormCompra()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            logicaNegocioCompra lN = new logicaNegocioCompra();

            try
            {
                Compra objCompra = new Compra();
                objCompra.fecha = txtfecha.Text;
                objCompra.precioC = int.Parse(txtprecioC.Text);
                objCompra.cantidad = int.Parse(txtcantidad.Text);

                if (lN.insertarCompra(objCompra) > 0)
                {
                    MessageBox.Show("Agregado con éxito!");
                    txtfecha.Text = "";
                    txtprecioC.Text = "";
                    txtcantidad.Text = "";
                    FormCliente cliente = new FormCliente();
                    cliente.Show();
                    Hide();
                }

                else { MessageBox.Show("Error al agregar proveedor"); }
            }
            catch
            {
                MessageBox.Show("Errorrrrrrr");
            }

        }

        private void btnguardarcom_Click(object sender, EventArgs e)
        {

        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            logicaNegocioCompra lN = new logicaNegocioCompra();
            txtID.Visible = false;
            lblidcompra.Visible = false;
            dgvcompra.DataSource = lN.ListarCompra();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            logicaNegocioCompra lN = new logicaNegocioCompra();
            List<Compra> lista = lN.BuscaCompraDatos(txtbuscar.Text);
            dgvcompra.DataSource = lista;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtID.Visible = true;
            txtID.Enabled = false;
            lblidcompra.Visible = true;

            txtfecha.Text = dgvcompra.CurrentRow.Cells["fecha"].Value.ToString();
            txtprecioC.Text = dgvcompra.CurrentRow.Cells["precioC"].Value.ToString();
            txtcantidad.Text = dgvcompra.CurrentRow.Cells["cantidad"].Value.ToString();
            txtID.Text = dgvcompra.CurrentRow.Cells["idcompra"].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
            btnguardarcom.Text = "Actualizar";
        }

        private void btnguardarcom_Click_1(object sender, EventArgs e)
        {
            logicaNegocioCompra lN = new logicaNegocioCompra();
           Compra objcompra = new Compra();

            try
            {
                if (btnguardarcom.Text == "Guardar")
                {

                    objcompra.fecha = txtfecha.Text;
                    objcompra.precioC = int.Parse(txtprecioC.Text);
                    objcompra.cantidad = int.Parse(txtcantidad.Text);

                    if (lN.insertarCompra(objcompra) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvcompra.DataSource = lN.ListarCompra();
                        txtfecha.Text = "";
                        txtprecioC.Text = "";
                        txtcantidad.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al agregar compra"); }
                }
                if (btnguardarcom.Text == "Actualizar")
                {

                    objcompra.idCompra = Convert.ToInt32(txtID.Text);
                    objcompra.fecha = txtfecha.Text;
                    objcompra.precioC = int.Parse(txtprecioC.Text);
                    objcompra.cantidad = int.Parse(txtcantidad.Text);
                }

                if (lN.EditarCompra(objcompra) > 0)
                {
                    MessageBox.Show("Actualizado con exito");
                    dgvcompra.DataSource = lN.ListarCompra();
                    txtfecha.Text = "";
                    txtprecioC.Text = "";
                    txtcantidad.Text = "";
                    tabControl1.SelectedTab = tabPage2;
                }
                else { MessageBox.Show("Error al actualizar compra"); }

                btnguardarcom.Text = "Guardar";

            }

            catch
            {
                MessageBox.Show("Errorrrrrr!");
            }
        }

        private void btneliminarc_Click(object sender, EventArgs e)
        {
            int idCompra = Convert.ToInt32(dgvcompra.CurrentRow.Cells["idCompra"].Value.ToString());

            try
            {
                if (lN.EliminarCompra(idCompra) > 0)
                {
                    MessageBox.Show("Eliminado con exito!");
                    dgvcompra.DataSource = lN.ListarCompra();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar Compra");
            }
        }

        }
    }

