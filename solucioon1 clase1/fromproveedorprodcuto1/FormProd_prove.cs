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


namespace formProd_prove
{
    public partial class FormProd_prove : Form

    {
        logicaNegocioProd_prove lN = new logicaNegocioProd_prove();
        public FormProd_prove()
        {
            InitializeComponent();
        }

      

        private void FormProd_prove_Load(object sender, EventArgs e)
        {
            logicaNegocioProd_prove lN = new logicaNegocioProd_prove();
            txtid.Visible = false;
            lblidpp.Visible = false;
            dgvpp.DataSource = lN.ListarProd_prove();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            logicaNegocioProd_prove lN = new logicaNegocioProd_prove();
            List<prod_prove> lista = lN.BuscaProd_proveDatos(txtbuscar.Text);
            dgvpp.DataSource = lista;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            txtid.Enabled = false;
            lblidpp.Visible = true;

            txtPrecio.Text = dgvpp.CurrentRow.Cells["Precio"].Value.ToString();
            txtCantidad.Text = dgvpp.CurrentRow.Cells["cantidad"].Value.ToString();
            txtid.Text = dgvpp.CurrentRow.Cells["idpp"].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
            btnGuardarpp.Text = "Actualizar";
        }

        private void btnGuardarpp_Click(object sender, EventArgs e)
        {

            logicaNegocioProd_prove lN = new logicaNegocioProd_prove();

            try
            {
                prod_prove objprod_prove = new prod_prove();
                objprod_prove.precio = int.Parse(txtPrecio.Text);
                objprod_prove.cantidad =int.Parse( txtCantidad.Text);


                if (lN.insertarProd_prove(objprod_prove) > 0)
                {
                    MessageBox.Show("Agregado con exito!");
                    txtPrecio.Text = "";
                    txtCantidad.Text = "";
                }
                else { MessageBox.Show("Error al agregar prod_prove"); }
            }
            catch 
            {
                MessageBox.Show("Errorrrrrr");
            }
        }

        private void btnGuardarpp_Click(object sender, EventArgs e)
        {

        logicaNegocioProd_prove lN = new logicaNegocioProd_prove();
            prod_prove objprod_prove = new prod_prove();

            try
            {
                if (btnGuardarpp.Text == "Guardar")
                {

                    objprod_prove.precio = int.Parse(txtPrecio.Text);
                    objprod_prove.cantidad = int.Parse(txtCantidad.Text);
                    

                    if (lN.insertarProd_prove(objprod_prove) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvpp.DataSource = lN.ListarProd_prove();
                        txtPrecio.Text = "";
                        txtCantidad.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al agregar prod_prove"); }
                }
                if (btnGuardarpp.Text == "Actualizar")
                {

                    objprod_prove.id_pp = Convert.ToInt32(txtid.Text);
                    objprod_prove.precio = int.Parse(txtPrecio.Text);
                    objprod_prove.cantidad = int.Parse(txtCantidad.Text);
                    
                }

                if (lN.EditarProd_prove(objprod_prove) > 0)
                {
                    MessageBox.Show("Actualizado con exito");
                    dgvpp.DataSource = lN.ListarProd_prove();
                    txtPrecio.Text = "";
                    txtCantidad.Text = "";
                    tabControl1.SelectedTab = tabPage2;
                }
                else { MessageBox.Show("Error al actualizar prod_prove"); }

                btnGuardarpp.Text = "Guardar";

            }

            catch
            {
                MessageBox.Show("Errorrrrrr!");
            }
        }

        private void btneliminarpp_Click(object sender, EventArgs e)
        {
            int id_pp = Convert.ToInt32(dgvpp.CurrentRow.Cells["id_pp"].Value.ToString());

            try
            {
                if (lN.EliminarProd_prove(id_pp) > 0)
                {
                    MessageBox.Show("Eliminado con exito!");
                    dgvpp.DataSource = lN.ListarProd_prove();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar producto_proveedor");
            }
        }
        }
    }

