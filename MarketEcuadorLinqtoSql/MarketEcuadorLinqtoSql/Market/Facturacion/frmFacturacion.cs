using Entidades.Facturacion;
using LogicaNegocio.Facturacion;
using Market.Inventario;
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
    public partial class frmFacturacion : Form
    {
        GuiaLN OPGuiaLN = new GuiaLN();
        GuiaDetalleLN OPGuiaDetalleLN = new GuiaDetalleLN();
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            lbl_DATE.Text = fecha;
            txtidguia.Text = ""+OPGuiaLN.getnextguia();
        }

        private void docleclickcelda(object sender, DataGridViewCellEventArgs e)
        {
             seleccionarproducto();
        }
        private void seleccionarproducto()
        {
            DialogResult resul = new DialogResult();
            frmProducto frprod = new frmProducto();
            frprod.SELECCION = true;
            resul = frprod.ShowDialog();
            if (frprod.OPTION == "OK")
            {
                dataGridView1.CurrentRow.Cells[0].Value = dataGridView1.RowCount;
                dataGridView1.CurrentRow.Cells[1].Value = frprod.idproducto;
                dataGridView1.CurrentRow.Cells[2].Value = frprod.nombreproducto;                
                dataGridView1.CurrentRow.Cells[4].Value = frprod.precio;
                dataGridView1.CurrentRow.Cells[3].Value = 1;
                cellendedit(null,null);

            }
        }

        private void cellendedit(object sender, DataGridViewCellEventArgs e)
        {


                if ((dataGridView1.CurrentRow.Cells[3].Value.ToString() != "" && dataGridView1.CurrentRow.Cells[4].Value.ToString() != "") && (dataGridView1.CurrentRow.Cells[3].Value != null && dataGridView1.CurrentRow.Cells[4].Value != null))
                {

                    dataGridView1.CurrentRow.Cells[5].Value = double.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) * double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());

                }
                
                btnCalcularCosto_Click(null,null);

           // }
        }

        

        private void btnAlmacenarclick(object sender, EventArgs e)
        {
            Guia tem= new Guia();
            tem.idGuia=int.Parse(txtidguia.Text);
            tem.idLocal=int.Parse(txtidlocal.Text);            
            tem.fechaSalida=DateTime.Parse(lbl_DATE.Text);
            tem.idTransportista = int.Parse(lblidtrans.Text);
            tem.total = decimal.Parse(lbl_Total.Text);
            OPGuiaLN.InsertarGuia(tem);

            for (int i = 0; i < dataGridView1.RowCount - 1;i++ )
            {
                Guia_Detalle guiadetalle = new Guia_Detalle();
                guiadetalle.idGuia=tem.idGuia;
                guiadetalle.idProducto=int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                guiadetalle.cantidad=short.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                guiadetalle.precioventa=decimal.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                OPGuiaDetalleLN.InsertarGuiaDetalle(guiadetalle);
                
            }
        }

      

      
        private void btselectlocalClick(object sender, EventArgs e)
        {
            DialogResult resul = new DialogResult();
            frmLocal frlocal = new frmLocal();
            frlocal.modoseleccion = true;
            resul = frlocal.ShowDialog();
            if (frlocal.OPTION == "OK")
            {
                txtidlocal.Text =""+ frlocal.idlocal;

            }
        }

        private void btnselecttransportista_Click(object sender, EventArgs e)
        {
            DialogResult resul = new DialogResult();
            frmTransportista frtrans = new frmTransportista();
            frtrans.modoseleccion = true;
            resul = frtrans.ShowDialog();
            if (frtrans.OPTION == "OK")
            {
                lblTransportista.Text = "" + frtrans.transportistanombre;
                lblidtrans.Text =""+frtrans.idtrans;
            }
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            
            double suma = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
               suma += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
               
            }
            lb_monto2.Text = "" + suma;
            lb_iva2.Text = ""+(suma * 0.12);
            lbl_Total.Text = "" + (suma + (suma * 0.12));

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+double.Parse("4,5,4"));
        }

        private void cellenter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
