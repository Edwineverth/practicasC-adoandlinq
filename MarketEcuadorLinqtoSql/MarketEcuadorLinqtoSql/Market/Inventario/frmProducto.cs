using Entidades;
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
    public partial class frmProducto : Form
    {
        ProductoLN Opln = new ProductoLN();
        ProveedorLN Oprov = new ProveedorLN();
        CategoriaLN Ocat = new CategoriaLN();
        Producto Op = new Producto();
        public bool SELECCION = false;
        public string OPTION = "";
        public string idproducto = "";
        public string nombreproducto = "";
        public string precio;
        public frmProducto()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void tool_nuevo_Click(object sender, EventArgs e)
        {
            frmEditProducto fp = new frmEditProducto();
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {

                    // Op.IdProveedor = int.Parse(fp.txtId.Text);
                    Op.Idcategoria = Ocat.getidcategoriabynombr(fp.txtcategoria.Text);
                    Op.Idproveedor = Oprov.getidproveedorbyprovnombre(fp.cmbproveedor.SelectedItem.ToString());
                    Op.Nombre = fp.txtNombre.Text;
                    Op.Unidad_medida = fp.txtUnidadMedida.Text;
                    Op.Precio_proveedor = decimal.Parse(fp.txtPrecioProv.Text.Replace(".",","));
                    Op.Stock_actual = short.Parse(fp.txtStockActual.Text);
                    Op.Stock_minimo = short.Parse(fp.txtStockMinimo.Text);
                    Opln.InsertarProducto(Op);
                    MostrarProductos();


                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }


            }
        }

        private void tool_editar_Click(object sender, EventArgs e)
        {

            frmEditProducto fep = new frmEditProducto();
            DialogResult resul = new DialogResult();
            Producto temp = getproducto();
            fep.MODIFICAR = true;
            fep.txtIdpro.Text = "" + temp.Idproducto;
            fep.txtcategoria.Text = Ocat.getcatenombbyidcat(temp.Idcategoria);
            fep.cmbproveedor.DataSource = Oprov.getnombresprov();
            fep.cmbproveedor.SelectedItem = Oprov.getnombrebyidprov(temp.Idproveedor);
            fep.txtNombre.Text = temp.Nombre;
            fep.txtUnidadMedida.Text = temp.Unidad_medida;
            fep.txtPrecioProv.Text = "" + temp.Precio_proveedor;
            fep.txtStockActual.Text = "" + temp.Stock_actual;
            fep.txtStockMinimo.Text = "" + temp.Stock_minimo;

            resul = fep.ShowDialog();
            if (fep.OPTION == "OK")
            {
                Producto a = new Producto();
                a.Idproducto = int.Parse(fep.txtIdpro.Text);
                a.Idcategoria = Ocat.getidcategoriabynombr(fep.txtcategoria.Text);
                a.Idproveedor = Oprov.getidproveedorbyprovnombre(fep.cmbproveedor.SelectedValue.ToString());
                a.Nombre = fep.txtNombre.Text;
                a.Unidad_medida = fep.txtUnidadMedida.Text;
                a.Precio_proveedor = decimal.Parse(fep.txtPrecioProv.Text.Replace(".",","));
                a.Stock_actual = short.Parse(fep.txtStockActual.Text);
                a.Stock_minimo = short.Parse(fep.txtStockMinimo.Text);
                Opln.ModificarProducto(a);
                MostrarProductos();
            }



        }

        private Producto getproducto()
        {
            Producto p = new Producto();
            p.Idproducto = int.Parse(dtgProductos.CurrentRow.Cells[0].Value.ToString());
            p.Idcategoria = Ocat.getidcategoriabynombr(dtgProductos.CurrentRow.Cells[1].Value.ToString());
            p.Idproveedor = Oprov.getidproveedorbyprovnombre(dtgProductos.CurrentRow.Cells[2].Value.ToString());
            p.Nombre = (dtgProductos.CurrentRow.Cells[3].Value.ToString());
            p.Unidad_medida = (dtgProductos.CurrentRow.Cells[4].Value.ToString());
            p.Precio_proveedor = decimal.Parse(dtgProductos.CurrentRow.Cells[5].Value.ToString());
            p.Stock_actual = short.Parse(dtgProductos.CurrentRow.Cells[6].Value.ToString());
            p.Stock_minimo = short.Parse(dtgProductos.CurrentRow.Cells[7].Value.ToString());
            return p;
        }

        private void tool_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resul;

            resul = MessageBox.Show("Esta seguro de eliminar registro", "Informacion del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    int cod = int.Parse(dtgProductos.CurrentRow.Cells[0].Value.ToString());
                    Producto ca = new Producto();
                    ca.Idproducto = cod;
                    Opln.EliminarProducto(ca);
                    MostrarProductos();
                }

                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void tool_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            dtgProductos.DataSource = Opln.ListarProductos(txtbuscar.Text);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void celldobleclick(object sender, DataGridViewCellEventArgs e)
        {
            if (SELECCION)
            {
                idproducto = dtgProductos.CurrentRow.Cells[0].Value.ToString();
                nombreproducto = dtgProductos.CurrentRow.Cells[3].Value.ToString();
                precio = dtgProductos.CurrentRow.Cells[5].Value.ToString();
                OPTION = "OK";
                this.Close();
            }
        }
    }
}
