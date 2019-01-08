using LogicaNegocio.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Facturacion
{
    public partial class frmTransportista : Form
    {
        TransportistaLN optrans = new TransportistaLN();
        public string OPTION = "";
        public bool modoseleccion = false;
        public string transportistanombre = "";
        public int idtrans ;
        public frmTransportista()
        {
            InitializeComponent();
        }

        private void frmTransportista_Load(object sender, EventArgs e)
        {
            MostrarTransportistas();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTransportistas();
        }

        private void MostrarTransportistas()
        {
            DtgProveedores.DataSource = optrans.ListarTransportistas(txtbuscar.Text);
        }

        private void dtgdoubleclick(object sender, EventArgs e)
        {
            if (modoseleccion)
            {
                transportistanombre = (DtgProveedores.CurrentRow.Cells[1].Value.ToString());
                idtrans = int.Parse(DtgProveedores.CurrentRow.Cells[0].Value.ToString());
                modoseleccion = false;
                OPTION = "OK";
                this.Close();

            }
        }
    }
}
