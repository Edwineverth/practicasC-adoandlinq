using LogicaNegocio.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Inventario
{
    public partial class frmEditLocal : Form
    {
        public string OPTION = "";
        public bool MODIFICAR = false;
        LocalLN OPLN = new LocalLN();
        public frmEditLocal()
        {
            InitializeComponent();
        }

        private void frmEditLocal_Load(object sender, EventArgs e)
        {

        }

        private void tool_grabar_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtciudad.Text == "" || txtTelefono.Text=="" || txtFax.Text=="")
            {
                MessageBox.Show("Los datos Marcados con (*) son datos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdireccion.Focus();
                return;
            }
            else
            {
                string cat = txtdireccion.Text;

                if (MODIFICAR)
                {
                    MODIFICAR = false;
                    OPTION = "OK";
                    this.Close();

                }
                else
                {                   
                    OPTION = "OK";
                    this.Close();                   

                }

            }


        }

        private void tool_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
