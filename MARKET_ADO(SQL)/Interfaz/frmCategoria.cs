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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        /*-----------------Metodos Personalizados-----------------*/
        public bool guardar = false;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar = true;
            this.Close();
        }

        public void limpiarCajasTexto()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtRep.Text = "";
            txtId.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            guardar = false;
            this.Close();
        }

    }
}
