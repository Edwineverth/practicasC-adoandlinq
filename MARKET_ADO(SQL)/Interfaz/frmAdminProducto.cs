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
    public partial class frmAdminProducto : Form
    {
        public frmAdminProducto()
        {
            InitializeComponent();
        }

        /*------------------Métodos Personalizados--------------*/
        Producto p = new Producto();
        frmProducto frmP = new frmProducto();
        LNProducto lnP = new LNProducto();
        LNCategoria lnCat = new LNCategoria();
        LNProveedor lnProv = new LNProveedor();
        int opc = 0;

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            opc = 1;
            frmP.limpiarCajasTexto();
            List<DataRow> lstC = lnCat.ListarEnLista();
            List<DataRow> lstP = lnProv.ListarEnLista();
            frmP.llenarCombos(lstC, lstP);
            frmP.ShowDialog();
            if (frmP.guardar == true)
            {
                try
                {
                    lnP.Insertar(getProducto());
                    MessageBox.Show("Se ha insertado los datos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                mostrarProductos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            opc = 2;
            frmP.limpiarCajasTexto();
            List<DataRow> lstC = lnCat.ListarEnLista();
            List<DataRow> lstP = lnProv.ListarEnLista();
            frmP.llenarCombos(lstC, lstP);
            llenarCampos();
            frmP.ShowDialog();

            if (frmP.guardar == true)
            {
                lnP.Actualizar(getProducto());
                MessageBox.Show("Se han actualizado los datos");
                mostrarProductos();
            }
        }
        
        private void llenarCampos()
        {
            int indiceFila = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1[0, indiceFila].Value.ToString();
            Producto p = lnP.Buscar(id);

            frmP.txtId.Text = id;
            frmP.txtNom.Text = p.Nombre_pro;
            frmP.txtUn.Text = p.UnidadMedida_pro;
            frmP.txtPreP.Text = p.PrecioProveedor_pro+"";
            frmP.txtStA.Text = p.StockAnual_pro+"";
            frmP.txtStM.Text = p.StockMinimo_pro+"";
            frmP.seleccionarCombos(p.IdCategoria_pro, p.IdProveedor_pro);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = lnP.ListarFiltro(txtBuscar.Text);
            dataGridView1.DataSource = dt;
        }

        private Producto getProducto()
        {
            Producto p = new Producto();
            if (opc == 2)
                p.Id_pro = int.Parse(frmP.txtId.Text);
            
            p.IdCategoria_pro = Convert.ToInt32(frmP.auxCat.Value);
            p.IdProveedor_pro = Convert.ToInt32(frmP.auxProv.Value);

            p.Nombre_pro = frmP.txtNom.Text;
            p.UnidadMedida_pro = frmP.txtUn.Text;
            p.PrecioProveedor_pro = double.Parse(frmP.txtPreP.Text);
            p.StockAnual_pro = int.Parse(frmP.txtStA.Text); 
            p.StockMinimo_pro = int.Parse(frmP.txtStM.Text);

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
                mostrarProductos();
            }
        }

        private void mostrarProductos()
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

        private void frmAdminProducto_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }
    }
}
