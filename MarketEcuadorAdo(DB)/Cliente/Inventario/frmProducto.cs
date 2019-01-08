using Entidades;
using LogicaNegocio;
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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }
        /// <summary>
        /// DECLARACIONES GLOBALES
        /// </summary>
        frmEditProducto fp = new frmEditProducto();
        ProductoLN Opln = new ProductoLN();
        ProveedorLN lnProv = new ProveedorLN();
        CategoriaLN lnCat = new CategoriaLN();
        Producto Op = new Producto();
        int opc = 0;

        private void tool_nuevo_Click(object sender, EventArgs e)
        {
            opc = 1;
            fp.limpiarCajasTexto();
            List<Proveedor> lstPr= lnProv.ObtenerProveedores();
            List<Categoria> lstCa = lnCat.obtenerCategorias();
            fp.llenarListas(lstPr, lstCa);
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {
                    Opln.insertar(getProducto());
                    MessageBox.Show("Se han insertado los datos");
                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
                mostrarProductos();
            }
        }

        private void llenarCampos()
        {
            int indiceFila = DtgProveedores.CurrentCell.RowIndex;
            string id = DtgProveedores[0, indiceFila].Value.ToString();
            try
            {
                Producto p = Opln.obtenerProducto(id);
                fp.txtId.Text = p.Id_pro + "";
                fp.txtNombre.Text = p.Nombre_pro;
                fp.txtUni.Text = p.UnidadMedida_pro;
                fp.txtPrecP.Text = p.PrecioProveedor_pro + "";
                fp.txtStA.Text = p.StockAnual_pro + "";
                fp.txtStM.Text = p.StockMinimo_pro + "";
                fp.seleccionarListas(p.IdCategoria_pro, p.IdProveedor_pro);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private Producto getProducto()
        {
            Producto p = new Producto();
            if (opc == 2)
                p.Id_pro = int.Parse(fp.txtId.Text);

            Categoria cat = (Categoria)fp.cbxCat.SelectedItem;
            p.IdCategoria_pro = cat.Id_cat;
            p.IdProveedor_pro = Convert.ToInt32(fp.prov.IdProveedor);
            p.Nombre_pro = fp.txtNombre.Text;
            p.UnidadMedida_pro = fp.txtUni.Text;
            p.PrecioProveedor_pro = double.Parse(fp.txtPrecP.Text);
            p.StockAnual_pro = int.Parse(fp.txtStA.Text);
            p.StockMinimo_pro = int.Parse(fp.txtStM.Text);

            return p;
        }

        private void mostrarProductos()
        {
            try
            {
                DtgProveedores.DataSource = Opln.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tool_editar_Click(object sender, EventArgs e)
        {
            fp.limpiarCajasTexto();
            List<Proveedor> lstPr = lnProv.ObtenerProveedores();
            List<Categoria> lstCa = lnCat.obtenerCategorias();
            fp.llenarListas(lstPr, lstCa);
            llenarCampos();
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {
                    Opln.actualizar(getProducto());
                    MessageBox.Show("Se han actualizado los datos");
                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
                mostrarProductos();
            }
        }

        private void tool_eliminar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if (res.ToString().Equals("Yes"))
            {
                int indiceFila = DtgProveedores.CurrentCell.RowIndex;
                string id = DtgProveedores[0, indiceFila].Value.ToString();
                try
                {
                    Opln.eliminar(int.Parse(id));
                    MessageBox.Show("Se han eliminado los datos!");
                    mostrarProductos();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            mostrarProductos();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = Opln.filtrar(txtbuscar.Text);
            DtgProveedores.DataSource = dt;

        }

        private void tool_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
