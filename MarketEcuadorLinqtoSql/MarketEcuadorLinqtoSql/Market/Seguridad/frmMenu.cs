using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Inventario;
using Market.Facturacion;
using Market.Reportes;
namespace Market.Seguridad

{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void addPanel(object form)
        {
            if (this.panelMenu.Controls.Count > 0)
                this.panelMenu.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(fh);
            this.panelMenu.Tag = fh;
            fh.Show();
        }

      

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string op = treeView1.SelectedNode.Text;
            switch (op)
            {
                case "Administrar Proveedores":
                    frmProveedor fp = new frmProveedor();
                    addPanel(fp);
                    break;
                case "Administrar Producto":
                    frmProducto fpr = new frmProducto();
                    addPanel(fpr);
                    break;
                case "Administrar Categoria":
                    frmCategoria fcr = new frmCategoria();
                    addPanel(fcr);
                    break;
                case "Administrar Local":
                    frmLocal flr = new frmLocal();
                    addPanel(flr);
                    break;
                case "Administrar Usuarios":
                    frmUsuarios fur = new frmUsuarios();
                    addPanel(fur);
                    break;
                case "Factura":
                    frmFacturacion fac = new frmFacturacion();
                    addPanel(fac);
                    break;

                case "Reporte Proveedores":
                    FrmCRProveedores i = new FrmCRProveedores();
                    addPanel(i);
                    break;
                case "Reporte Producto":
                    FrmCRProductosFiltro l = new FrmCRProductosFiltro();
                    addPanel(l);
                    break;
                case "Transportista":
                    frmTransportista t = new frmTransportista();
                    addPanel(t);
                    break;

            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
