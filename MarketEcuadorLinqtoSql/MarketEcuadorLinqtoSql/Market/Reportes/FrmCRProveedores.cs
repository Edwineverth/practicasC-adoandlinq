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


namespace Market.Reportes
{
    public partial class FrmCRProveedores : Form
    {
        public FrmCRProveedores()
        {
            InitializeComponent();
        }

        private void FrmCRProveedores_Load(object sender, EventArgs e)
        {
            ProveedorLN OP = new ProveedorLN();
            DSReporteMarket ds = new DSReporteMarket();
            try
            {
                List<CapaDatos.PROVEEDOR> lp = OP.ListarProveedoresTodos();
                foreach (CapaDatos.PROVEEDOR p in lp)
                {

                    ds.PROVEEDOR.AddPROVEEDORRow(p.CedProveedor, p.Nombre, p.Representante, p.Direccion, p.Ciudad, p.Telefono, p.Fax);
                }
                CRProveedores rpt = new CRProveedores();
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
            }
            catch (Exception men)
            {
                MessageBox.Show(men.ToString());
            }
        }
    }
}
