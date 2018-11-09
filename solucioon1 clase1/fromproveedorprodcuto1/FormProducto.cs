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


namespace formProducto
{
    public partial class FormProducto : Form
    {
        logicaNegocioProducto lN = new logicaNegocioProducto();
        public FormProducto()
        {
            InitializeComponent();
        }

  private void btnguardarpr_Click_1(object sender, EventArgs e)
        {
             logicaNegocioProducto lN = new logicaNegocioProducto();

            try
            {
                producto objProducto = new producto ();
                objProducto.descripcion = txtdescripcion.Text;
                

                if (lN.insertarProducto(objProducto) > 0)
                {
                    MessageBox.Show("Agregado con éxito!");
                    txtdescripcion.Text = "";
                
                }

                else { MessageBox.Show("Error al agregar producto"); }
            }
            catch
            {
                MessageBox.Show("Errorrrrrrr");
            }

        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            logicaNegocioProducto lN = new logicaNegocioProducto();
            txtid.Visible = false;
            lblid.Visible = false;
            dgvproducto.DataSource = lN.ListarProducto();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            logicaNegocioProducto lN = new logicaNegocioProducto();
            List<producto> lista = lN.BuscaProductoDatos(txtbuscar.Text);
            dgvproducto.DataSource = lista;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            txtid.Enabled = false;
            lblid.Visible = true;

            txtdescripcion.Text = dgvproducto.CurrentRow.Cells["descripcion"].Value.ToString();
            txtid.Text = dgvproducto.CurrentRow.Cells["idProducto"].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
            btnguardarpr.Text = "Actualizar";
        }
        private void btGuardar_Click_1(object sender, EventArgs e)
        {
            logicaNegocioProducto lN = new logicaNegocioProducto();
            producto objProducto = new producto();

            try
            {
                if (btnguardarpr.Text == "Guardar")
                {

                    objProducto.descripcion = txtdescripcion.Text;
                   

                    if (lN.insertarProducto(objProducto) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvproducto.DataSource = lN.ListarProducto();
                        txtdescripcion.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al agregar producto"); }
                }
                if (btnguardarpr.Text == "Actualizar")
                {

                    objProducto.idProducto = Convert.ToInt32(txtid.Text);
                    objProducto.descripcion= txtdescripcion.Text;
                }

                if (lN.EditarProducto(objProducto) > 0)
                {
                    MessageBox.Show("Actualizado con exito");
                    dgvproducto.DataSource = lN.ListarProducto();
                    txtdescripcion.Text = "";
                    tabControl1.SelectedTab = tabPage2;
                }
                else { MessageBox.Show("Error al actualizar producto"); }

                btnguardarpr.Text = "Guardar";

            }

            catch
            {
                MessageBox.Show("Errorrrrrr!");
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(dgvproducto.CurrentRow.Cells["idProducto"].Value.ToString());

            try
            {
                if (lN.EliminarProducto(idProducto) > 0)
                {
                    MessageBox.Show("Eliminado con exito!");
                    dgvproducto.DataSource = lN.ListarProducto();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar producto");
            }
        }

            
        }
    }

