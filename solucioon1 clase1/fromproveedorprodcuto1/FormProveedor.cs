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
using formCompra;


namespace fromproveedorprodcuto1
{
    public partial class FormProveedor : Form
    {
        logicaNegocioProveedors lN = new logicaNegocioProveedors();
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            logicaNegocioProveedors lN = new logicaNegocioProveedors();

            try
            {
                proveedores objProveedor = new proveedores();
                objProveedor.nombre = txtNombre.Text;
                objProveedor.direccion = txtDireccion.Text;
                objProveedor.telefono = txtTelefono.Text;

                if (lN.insertarProveedor(objProveedor) > 0)
                {
                    MessageBox.Show("Agregado con éxito!");
                    txtDireccion.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    FormCompra compra = new FormCompra();
                    compra.Show();
                    Hide();
                }

                else { MessageBox.Show("Error al agregar proveedor"); }
            }
            catch
            {
                MessageBox.Show("Errorrrrrrr");
            }

        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            logicaNegocioProveedors lN = new logicaNegocioProveedors();
            txtid.Visible = false;
            lblid.Visible = false;
            dataGridView1.DataSource = lN.ListarProveedores();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            logicaNegocioProveedors lN = new logicaNegocioProveedors();
            List<proveedores> lista = lN.BuscaProveedorDatos(txtbuscar.Text);
            dataGridView1.DataSource = lista;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtid.Visible = true;
            txtid.Enabled = false;
            lblid.Visible = true;

            txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
            txtDireccion.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells["telefono"].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells["idcodigoP"].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
            btGuardar.Text = "Actualizar";
        }

        private void btGuardar_Click_1(object sender, EventArgs e)
        {
            logicaNegocioProveedors lN = new logicaNegocioProveedors();
            proveedores objProveedor = new proveedores();

            try
            {
                if (btGuardar.Text == "Guardar")
                {

                    objProveedor.nombre = txtNombre.Text;
                    objProveedor.direccion = txtDireccion.Text;
                    objProveedor.telefono = txtTelefono.Text;

                    if (lN.insertarProveedor(objProveedor) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dataGridView1.DataSource = lN.ListarProveedores();
                        txtDireccion.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";
                        tabControl1.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al agregar proveedor"); }
                }
                if (btGuardar.Text == "Actualizar")
                {

                    objProveedor.idcodigoP = Convert.ToInt32(txtid.Text);
                    objProveedor.nombre = txtNombre.Text;
                    objProveedor.direccion = txtDireccion.Text;
                    objProveedor.telefono = txtTelefono.Text;
                }

                if (lN.EditarProveedores(objProveedor) > 0)
                {
                    MessageBox.Show("Actualizado con exito");
                    dataGridView1.DataSource = lN.ListarProveedores();
                    txtDireccion.Text = "";
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    tabControl1.SelectedTab = tabPage2;
                }
                else { MessageBox.Show("Error al actualizar proveedor"); }

                btGuardar.Text = "Guardar";

            }

            catch
            {
                MessageBox.Show("Errorrrrrr!");
            }
        }

      

     

        private void btneliminar1_Click(object sender, EventArgs e)
        {
            int idcodigoP = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idCodigoP"].Value.ToString());

            try
            {
                if (lN.EliminarProveedor(idcodigoP) > 0)
                {
                    MessageBox.Show("Eliminado con exito!");
                    dataGridView1.DataSource = lN.ListarProveedores();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar proveedor");
            }
        }
    }
}


