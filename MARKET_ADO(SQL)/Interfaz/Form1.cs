using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        frmAdminProducto frmPr = new frmAdminProducto();
        frmAdminProveedor frmProv = new frmAdminProveedor();
        frmAdminCategoria frmCa = new frmAdminCategoria();

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPr.Visible == true)
            {
                return;
            }

            frmPr.MdiParent = this;
            frmPr.Show();
        }

        private void administrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCa.Visible == true)
            {
                return;
            }

            frmCa.MdiParent = this;
            frmCa.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmProv.Visible == true)
            {
                return;
            }

            frmProv.MdiParent = this;
            frmProv.Show();
        }
    }
}
