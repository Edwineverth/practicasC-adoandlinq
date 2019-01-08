using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Seguridad
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void productotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inventario.frmProducto frm = new Inventario.frmProducto();
            frm.ShowDialog();
        }

        private void CategoriatoolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Inventario.frmCategoria frm = new Inventario.frmCategoria();
            frm.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario.frmProveedor frm = new Inventario.frmProveedor();
            frm.ShowDialog();
        }
    }
}
