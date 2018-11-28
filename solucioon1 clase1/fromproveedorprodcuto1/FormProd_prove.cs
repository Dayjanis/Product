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
        
        public FormProd_prove()
        {
            InitializeComponent();
        }
        logicaNegocioProd_prove lN = new logicaNegocioProd_prove();
        private void FormProd_prove_Load(object sender, EventArgs e)
        {
            
            txtid.Visible = false;
            lblidpp.Visible = false;
            dgvpp.DataSource = lN.ListarProd_prove();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            
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
            try
            {
                if ( btnGuardarpp.Text == "Guardar")
                {
                prod_prove objprod_prove = new prod_prove();
                objprod_prove.precio = float.Parse(txtPrecio.Text);
                objprod_prove.cantidad =int.Parse( txtCantidad.Text);


                if (lN.insertarProd_prove(objprod_prove) > 0)
                {
                    MessageBox.Show("Agregado con exito!");
                    dgvpp.DataSource = lN.ListarProd_prove();
                    txtPrecio.Text = "";
                    txtCantidad.Text = "";
                    tabControl1.SelectedTab = tabPage2;
                }
                else { MessageBox.Show("Error al agregar producto_proveedor"); }
                
                }
                if( btnGuardarpp.Text == "Actualizar")
                {

                    prod_prove objprodprove = new prod_prove();
                    objprodprove.id_pp = Convert.ToInt32(txtid.Text);
                    objprodprove.precio = float.Parse(txtPrecio.Text);
                    objprodprove.cantidad = int.Parse(txtCantidad.Text);

                    if (lN.EditarProd_prove(objprodprove) > 0)
                    {
                        MessageBox.Show("Actualizado con exito");
                        dgvpp.DataSource = lN.ListarProd_prove();
                        txtPrecio.Text = "";
                        txtCantidad.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al actualizar producto_proveedor"); }

                    btnGuardarpp.Text = "Guardar";
                }
                
            }
            catch 
            {
                MessageBox.Show("Errorrrrrr");
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

