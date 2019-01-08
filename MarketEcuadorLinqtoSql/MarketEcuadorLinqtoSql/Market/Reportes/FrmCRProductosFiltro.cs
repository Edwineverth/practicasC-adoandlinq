using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Facturacion;
using LogicaNegocio.Inventario;

namespace Market.Reportes
{
    public partial class FrmCRProductosFiltro : Form
    {
        public FrmCRProductosFiltro()
        {
            InitializeComponent();
        }
        ProductoLN OP = new ProductoLN();
        CRProductosFiltro rpt = new CRProductosFiltro();
        DSProductos ds = new DSProductos();

        private void FrmCRProductosFiltro_Load(object sender, EventArgs e)
        {

            CategoriaLN cat = new CategoriaLN();
            comboBox1.DataSource = cat.getcategorias();

            try
            {
                List<CapaDatos.filtrarVistaProductoResult> lp = OP.ObtenerProductosbycategoria("GOLOSINAS");
                //MessageBox.Show(""+lp.Count);
                foreach (CapaDatos.filtrarVistaProductoResult p in lp)
                {

                    ds.VistaProducto.AddVistaProductoRow(p.IdProducto, p.Categoria, p.NombreProveedor, p.Nombreproducto, p.UnidadMedida, decimal.Parse("" + p.PrecioProveedor), short.Parse("" + p.StockActual), short.Parse("" + p.StockMinimo));
                }

                rpt.SetDataSource(ds);

                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception men)
            {
                MessageBox.Show(men.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<CapaDatos.filtrarVistaProductoResult> lp = OP.ObtenerProductosbycategoria(comboBox1.SelectedItem.ToString());
                //MessageBox.Show(""+lp.Count);
                ds.VistaProducto.Clear();
                foreach (CapaDatos.filtrarVistaProductoResult p in lp)
                {

                    ds.VistaProducto.AddVistaProductoRow(p.IdProducto, p.Categoria, p.NombreProveedor, p.Nombreproducto, p.UnidadMedida, decimal.Parse("" + p.PrecioProveedor), short.Parse("" + p.StockActual), short.Parse("" + p.StockMinimo));
                }

                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception men)
            {
                MessageBox.Show(men.ToString());
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
