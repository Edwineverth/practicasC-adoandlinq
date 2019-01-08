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
    public partial class frmEditCategoria : Form
    {
        public frmEditCategoria()
        {
            InitializeComponent();
        }

        /*-----------------Metodos Personalizados-----------------*/

        public void limpiarCajasTexto()
        {
            txtCategoria.Text = "";
            txtId.Text = "";
            txtDes.Text = "";
            txtId.Focus();
        }

        public string OPTION = "";

        private void tool_grabar_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "" || txtDes.Text == "" )
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

        private void tool_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
