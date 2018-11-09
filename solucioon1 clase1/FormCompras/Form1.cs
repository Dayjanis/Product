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

namespace FormCompras
{
    public partial class Form1 : Form
    {
        public Form1()
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
                }

                else { MessageBox.Show("Error al agregar proveedor"); }
            }
            catch
            {
                MessageBox.Show("Errorrrrrrr");
            }

        }
    }
}
