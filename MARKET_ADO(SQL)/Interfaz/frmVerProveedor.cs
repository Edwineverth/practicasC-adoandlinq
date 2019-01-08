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
    public partial class frmVerProveedor : Form
    {
        public frmVerProveedor()
        {
            InitializeComponent();
        }


        public bool ok = false;

        private void listBox1_Enter(object sender, EventArgs e)
        {
            //ok = true;
            //this.Close();
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ok = true;
            this.Close();
        }
    }
}
