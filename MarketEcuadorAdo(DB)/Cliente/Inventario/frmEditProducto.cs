using Entidades;
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
    public partial class frmEditProducto : Form
    {
        public frmEditProducto()
        {
            InitializeComponent();
        }

        /*-----------------Metodos Personalizados-----------------*/
        public string OPTION = "";
        frmListaProveedores frmP = new frmListaProveedores();
        public Proveedor prov = new Proveedor();
        
        public void limpiarCajasTexto()
        {
            txtId.Text = "";
            cbxCat.SelectedItem = "";
            txtNombre.Text = "";
            txtUni.Text = "";
            txtUni.Text = "";
            txtProve.Text = "";
            txtPrecP.Text = "";
            txtStA.Text = "";
            txtStM.Text = "";
            txtId.Focus();
        }

        public void seleccionarListas(int idCat, int idProv)
        {
            Categoria cat = null;
            foreach (Categoria c in cbxCat.Items)
            {
                if (c.Id_cat == idCat)
                    cat = c;
            }

            Proveedor prov = null;
            foreach (Proveedor p in frmP.listBox1.Items)
            {
                if (p.IdProveedor == idProv)
                    prov = p;
            }

            cbxCat.SelectedItem = cat;
            frmP.listBox1.SelectedItem = prov;
            txtProve.Text = prov.Nombre;
        }

        public void llenarListas(List<Proveedor> lstP, List<Categoria> lstC)
        {
            if (cbxCat.Items.Count == 0)
            {
                cbxCat.ValueMember = "Id_cat";
                cbxCat.DisplayMember = "Categoria_cat";

                frmP.listBox1.ValueMember = "IdProveedor";
                frmP.listBox1.DisplayMember = "Nombre";

                frmP.listBox1.DataSource = lstP;
                cbxCat.DataSource = lstC;
                MessageBox.Show(cbxCat.Items.Count + "this" + lstC.Count);
            }
        }

        private void tool_grabar_Click(object sender, EventArgs e)
        {
            if (cbxCat.SelectedItem.ToString().Trim().Length < 1 || txtNombre.Text.Trim().Length < 1 ||
                txtUni.Text.Trim().Length < 1 || txtProve.Text.Trim().Length < 1 || txtPrecP.Text.Trim().Length < 1 ||
                txtStA.Text.Trim().Length < 1 || txtStM.Text.Trim().Length < 1)
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
            OPTION = "NOT";
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmP.ShowDialog();
            if (frmP.ok == true)
            {
                try
                {
                    prov = (Proveedor)frmP.listBox1.SelectedItem;
                    txtProve.Text = prov.Nombre;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
