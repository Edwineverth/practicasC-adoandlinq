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
    public partial class frmEditCategoria : Form
    {
        public frmEditCategoria()
        {
            InitializeComponent();
        }
        public bool modificar;
        public string OPTION = "";
        CategoriaLN Opln = new CategoriaLN();
        private void tool_grabar_Click(object sender, EventArgs e)
        {
            if (txtcategoria.Text == "" || txtdescripcion.Text == "" )
            {
                MessageBox.Show("Los datos Marcados con (*) son datos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtcategoria.Focus();
                return;
            }
            else
            {
                string cat = txtcategoria.Text;

                if (modificar)
                {
                    modificar = false;
                    OPTION = "OK";
                    this.Close();

                }
                else
                {
                    if (Opln.existeCategoria(cat))
                    {
                        MessageBox.Show("Cedula ya esta Registrado");
                        txtcategoria.Focus();
                        return;

                    }
                    else
                    {
                        OPTION = "OK";
                        this.Close();

                    }

                }

            }
        }

        private void frmEditCategoria_Load(object sender, EventArgs e)
        {

        }
    }
}
