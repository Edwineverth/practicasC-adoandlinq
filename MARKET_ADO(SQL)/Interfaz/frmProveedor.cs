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
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }

        /*-----------------Metodos Personalizados-----------------*/
        public bool guardar = false;

        public void limpiarCajasTexto()
        {
            txtCed.Text = "";
            txtId.Text = "";
            txtNom.Text = "";
            txtRep.Text = "";
            txtDir.Text = "";
            txtTel.Text = "";
            txtFax.Text = "";
            txtId.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar = true;
            this.Close();
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            guardar = false;
            this.Close();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }
    }
}
