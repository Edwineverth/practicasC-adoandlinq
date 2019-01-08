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
    public partial class frmEditProveedor : Form
    {
        public frmEditProveedor()
        {
            InitializeComponent();
        }

        /*-----------------Metodos Personalizados-----------------*/
        
        public void limpiarCajasTexto()
        {
            txtcedula.Text = "";
            txtId.Text = "";
            txtNom.Text = "";
            txtRep.Text = "";
            txtDir.Text = "";
            txttel.Text = "";
            txtfax.Text = "";
            txtciud.Text = "";
            txtId.Focus();
        }

        public string OPTION = "";

        private void tool_grabar_Click(object sender, EventArgs e)
        {
            if ( txtcedula.Text == "" || txtNom.Text == "" || txtRep.Text == "" || txtDir.Text == "" || txtciud.Text == "" || txttel.Text == "" || txtfax.Text == "")
            {
                MessageBox.Show("Los datos Marcados con (*) son datos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                return;
            }
            else
            {
                OPTION = "OK";
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tool_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
