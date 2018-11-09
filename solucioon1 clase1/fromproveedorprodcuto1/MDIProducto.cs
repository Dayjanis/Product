using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using formCliente;
using formProducto;
using formCompra;
using formProd_prove;


namespace fromproveedorprodcuto1
{
    public partial class MDIProducto : Form
    {
        
        private int childFormNumber = 0;

        public MDIProducto()
        {
            InitializeComponent();
        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Ventana " + childFormNumber++;
        //    childForm.Show();
        //}

        //private void OpenFile(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = usuarioBarToolStripMenuItem.Checked;
        }

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = RespaldoBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProveedor fp = new FormProveedor();
            fp.Show();
        }

        private void salirMenu_Click(object sender, EventArgs e)
        {
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
        }
        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("¿Esta seguro de que quiere cerrar la aplicacion?",
                                                                      "Cerrar la Aplicacion", MessageBoxButtons.YesNo,
                                                                      MessageBoxIcon.Question);
            return res;
        }

        private void RespaldoBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logicaNegocioRespaldo lN = new logicaNegocioRespaldo();
            try
            {
                if (lN.respaldarBD() > 0)
                {
                    MessageBox.Show("Respaldo realizado con exito!");
                }
            }
            catch { MessageBox.Show("Error al realizar respaldo"); }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente cli = new FormCliente();
            cli.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProducto pro = new FormProducto();
            pro.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompra com = new FormCompra();
            com.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProd_prove pp = new FormProd_prove();
            pp.Show();

        }


    }
}
