using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using LogicaNegocio.Inventario;
using Entidades;
namespace Market.Inventario
{
    public partial class frmLocal : Form
    {
        LocalLN Opln = new LocalLN();
        Local Op = new Local();
        public bool modoseleccion = false;
        public int idlocal ;
        public string OPTION="";        
        public frmLocal()
        {
            InitializeComponent();
        }

        private void tool_nuevo_Click(object sender, EventArgs e)
        {
            frmEditLocal fp = new frmEditLocal();
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {

                    // Op.IdProveedor = int.Parse(fp.txtId.Text);
                    Op.direccion = fp.txtdireccion.Text;
                    Op.ciudad = fp.txtciudad.Text;
                    Op.telefono = fp.txtTelefono.Text;
                    Op.fax = fp.txtFax.Text;
                    
                    Opln.InsertarLocal(Op);
                    mostrarLocal();


                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }


            }
        }

        public void mostrarLocal()
        {
            DtgProveedores.DataSource = Opln.ListarLocales(txtbuscar.Text);
        }
        private void frmLocal_Load(object sender, EventArgs e)
        {
            mostrarLocal();
        }

        private void tool_editar_Click(object sender, EventArgs e)
        {
            frmEditLocal mpp = new frmEditLocal();
            DialogResult resul = new DialogResult();
            mpp.MODIFICAR = true;
            mpp.txtIdLocal.Text = DtgProveedores.CurrentRow.Cells[0].Value.ToString();
            mpp.txtdireccion.Text = DtgProveedores.CurrentRow.Cells[1].Value.ToString();
            mpp.txtciudad.Text = DtgProveedores.CurrentRow.Cells[2].Value.ToString();
            mpp.txtTelefono.Text = DtgProveedores.CurrentRow.Cells[3].Value.ToString();
           
            mpp.txtFax.Text = DtgProveedores.CurrentRow.Cells[4].Value.ToString();
            
            resul = mpp.ShowDialog();

            if (mpp.OPTION == "OK")
            {
                try
                {
                    Op.idLocal = int.Parse(mpp.txtIdLocal.Text);
                    Op.direccion = mpp.txtdireccion.Text;
                    Op.ciudad = mpp.txtciudad.Text;
                    Op.telefono = mpp.txtTelefono.Text;
                    Op.fax = mpp.txtFax.Text;
                    
                    Opln.ModificarLocal(Op);
                    mostrarLocal();

                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void tool_salir_Click(object sender, EventArgs e)
        {
            
        }

        private void tool_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resul;

            resul = MessageBox.Show("Esta seguro de eliminar registro", "Informacion del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resul == DialogResult.Yes)
            {
                try
                {
                    int cod = int.Parse(DtgProveedores.CurrentRow.Cells[0].Value.ToString());
                    Op.idLocal = cod;
                    Opln.EliminarLocal(Op);
                    mostrarLocal();
                }

                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarLocal();
        }

        private void dtgdoubleclick(object sender, EventArgs e)
        {
            if(modoseleccion){
               idlocal = int.Parse(DtgProveedores.CurrentRow.Cells[0].Value.ToString());
               modoseleccion = false;
               OPTION = "OK";
               this.Close();

            }

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
