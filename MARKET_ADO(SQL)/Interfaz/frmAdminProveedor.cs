using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Objetos;
using LogicaNegocio;

namespace Interfaz
{
    public partial class frmAdminProveedor : Form
    {
        public frmAdminProveedor()
        {
            InitializeComponent();
        }
        
        /*------------------Métodos Personalizados--------------*/
        Proveedor p = new Proveedor();
        frmProveedor frmP = new frmProveedor();
        LNProveedor lnP = new LNProveedor();
        int opc = 0;

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            opc = 1;
            frmP.limpiarCajasTexto();
            frmP.ShowDialog();
            if (frmP.guardar == true)
            {
                try
                {
                    lnP.Insertar(getProveedor());
                    MessageBox.Show("Se ha insertado los datos");
                }catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
                mostrarProveedores();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            opc = 2;
            frmP.limpiarCajasTexto();
            llenarCampos();
            frmP.ShowDialog();

            if (frmP.guardar == true)
            {
                lnP.Actualizar(getProveedor());
                MessageBox.Show("Se han actualizado los datos");
                mostrarProveedores();
            }
        }

        private void llenarCampos()
        {
            int indiceFila = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1[0, indiceFila].Value.ToString();
            string ced = dataGridView1[1, indiceFila].Value.ToString();
            string nombre = dataGridView1[2, indiceFila].Value.ToString();
            string rep = dataGridView1[3, indiceFila].Value.ToString();
            string dir = dataGridView1[4, indiceFila].Value.ToString();
            string ciu = dataGridView1[5, indiceFila].Value.ToString();
            string tel = dataGridView1[6, indiceFila].Value.ToString();
            string fax = dataGridView1[7, indiceFila].Value.ToString();

            frmP.txtId.Text = id;
            frmP.txtCed.Text = ced;
            frmP.txtNom.Text = nombre;
            frmP.txtRep.Text = rep;
            frmP.txtDir.Text = dir;
            frmP.cmbCiu.SelectedItem = ciu;
            frmP.txtTel.Text = tel;
            frmP.txtFax.Text = fax;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = lnP.ListarFiltro(txtBuscar.Text);
            dataGridView1.DataSource = dt;
        }

        private Proveedor getProveedor()
        {
            Proveedor p = new Proveedor();
            if (opc == 2)
                p.Id_pro = int.Parse(frmP.txtId.Text);
            p.Cedula_pro = frmP.txtCed.Text;
            p.Nombre_pro = frmP.txtNom.Text;
            p.Representante_pro = frmP.txtRep.Text;
            p.Fax_pro = frmP.txtFax.Text;
            p.Direccion_pro = frmP.txtDir.Text;
            p.Ciudad_pro = frmP.cmbCiu.SelectedItem.ToString().ToUpper();
            p.Telefono_pro = frmP.txtTel.Text;

            return p;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);
            
            if (res.ToString().Equals("Yes"))
            {
                int indiceFila = dataGridView1.CurrentCell.RowIndex;
                string id = dataGridView1[0, indiceFila].Value.ToString();
                lnP.Eliminar(int.Parse(id));
                MessageBox.Show("Se han eliminado los datos!");
                mostrarProveedores();
            }
        }

        private void mostrarProveedores()
        {
            try
            {
                dataGridView1.DataSource = lnP.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAdminProveedor_Load(object sender, EventArgs e)
        {
            mostrarProveedores();
        }
    }
}
