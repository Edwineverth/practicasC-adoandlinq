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
    public partial class frmEditProducto : Form
    {
        public string OPTION = "";
        public bool MODIFICAR = false;

        public frmEditProducto()
        {
            InitializeComponent();
        }

        private void frmEditProducto_Load(object sender, EventArgs e)
        {
            if (!MODIFICAR)
            {
                ProveedorLN j = new ProveedorLN();
                cmbproveedor.DataSource = j.getnombresprov();
            }
        }
        
        private void tool_grabar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtcategoria.Text == "" || cmbproveedor.SelectedIndex ==-1 || txtUnidadMedida.Text == "" || txtPrecioProv.Text == "" || txtStockActual.Text == "" || txtStockMinimo.Text == "")
            {
                MessageBox.Show("Los datos Marcados con (*) son datos obligatorios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return;
            }
            else
            {

                if (MODIFICAR)
                {
                    MODIFICAR = false;                    
                    this.Close();
                }
                else
                {                    
                    this.Close();                                       
                }
                OPTION = "OK";
            }
        }

        private void btnselectcategoria_Click(object sender, EventArgs e)
        {
            frmCategoria fec = new frmCategoria();
            DialogResult resul = new DialogResult();
            fec.modoseleccion = true;
            resul = fec.ShowDialog();
            if (fec.OPTION == "OK")
            { 
                txtcategoria.Text = fec.categorianom;            
            }
            
        }

        private void tool_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
