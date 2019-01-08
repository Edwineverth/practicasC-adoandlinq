using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Inventario
{
    public partial class frmListaProveedores : Form
    {
        public frmListaProveedores()
        {
            InitializeComponent();
        }
        //
        public bool ok = false;

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ok = true;
            this.Close();
        }

    }
}
