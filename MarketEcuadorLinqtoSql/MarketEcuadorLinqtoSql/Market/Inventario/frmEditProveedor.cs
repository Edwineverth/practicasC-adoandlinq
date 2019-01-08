using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Inventario;
using LogicaNegocio;
using Entidades;


namespace Market.Inventario
{
    public partial class frmEditProveedor : Form
    {
        public frmEditProveedor()
        {
            InitializeComponent();
        }
        public string OPTION = "";
        Validaciones val = new Validaciones();
        ProveedorLN Opln = new ProveedorLN();
        Proveedor Op = new Proveedor();
        public bool modificar = false;
        private void tool_grabar_Click(object sender, EventArgs e)
        {
            if (txtcedula.Text == "" || txtNom.Text == "" || txtRep.Text == "" || txtDir.Text == "" || txtciud.Text == "" || txttel.Text == "" || txtfax.Text == "")
            {
                MessageBox.Show("Los datos Marcados con (*) son datos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNom.Focus();
                return;
            }
           else
            {
                string ced = txtcedula.Text;

                if (modificar)
                {
                    modificar = false;
                    OPTION = "OK";
                    this.Close();

                }
                else
                {   if (Opln.existeProveedor(ced))
                    {
                        MessageBox.Show("Cedula ya esta Registrado");
                        txtId.Focus();
                        return;

                    }
                    else
                    {
                        OPTION = "OK";
                        this.Close();
              
                }

                }
                
        }}

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
            val.Enter(e, txtcedula);
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
            val.Enter(e, txtNom);
        }

        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
            val.Enter(e, txtRep);
        }

        private void txtRep_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
            val.Enter(e, txtDir);
        }

        private void txtDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
            val.Enter(e, txtciud);
        }

        private void txtciud_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.Letras(e);
            val.Enter(e, txttel);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.numeros(e);
            val.Enter(e, txtfax);
        }

        private void txtfax_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcedula_Validated(object sender, EventArgs e)
        {
            if (txtcedula.Text != "")
            {
                if (val.esCedulaValida(txtcedula.Text) == false)
                {
                    errorProvider1.SetError(txtcedula, "Cedula no Valida");
                    txtcedula.Focus();
                }
                else
                    errorProvider1.SetError(txtcedula, "");
            }
        }

        private void tool_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmEditProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
