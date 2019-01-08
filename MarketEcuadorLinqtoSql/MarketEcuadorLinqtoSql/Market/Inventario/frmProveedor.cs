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
using Entidades;

namespace Market.Inventario
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }
        ProveedorLN Opln = new ProveedorLN();
        Proveedor Op = new Proveedor();
        public bool modoseleccion = false;
        public string nombreprov = "";
        public string idprov="";
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            MostrarProvedores();
        }

        private void MostrarProvedores()
        {
            DtgProveedores.DataSource = Opln.ListarProveedores(txtbuscar.Text);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarProvedores();
        }

        private void tool_nuevo_Click(object sender, EventArgs e)
        {
            frmEditProveedor fp = new frmEditProveedor();
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {

                    // Op.IdProveedor = int.Parse(fp.txtId.Text);
                    Op.CedProveedor = fp.txtcedula.Text;
                    Op.Nombre = fp.txtNom.Text;
                    Op.Representante = fp.txtRep.Text;
                    Op.Direccion = fp.txtDir.Text;
                    Op.Ciudad = fp.txtciud.Text;
                    Op.Telefono = fp.txttel.Text;
                    Op.Fax = fp.txtfax.Text;
                    Opln.InsertarProveedor(Op);
                    MostrarProvedores();


                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }


            }
        }

        private void tool_editar_Click(object sender, EventArgs e)
        {
            frmEditProveedor mpp = new frmEditProveedor();
            DialogResult resul = new DialogResult();
            mpp.modificar = true;
            mpp.txtId.Text = DtgProveedores.CurrentRow.Cells["IdProveedor"].Value.ToString();
            mpp.txtcedula.Text = DtgProveedores.CurrentRow.Cells["CedProveedor"].Value.ToString();
            mpp.txtNom.Text = DtgProveedores.CurrentRow.Cells["Nombre"].Value.ToString();
            mpp.txtRep.Text = DtgProveedores.CurrentRow.Cells["Representante"].Value.ToString();
            mpp.txtDir.Text = DtgProveedores.CurrentRow.Cells["Direccion"].Value.ToString();
            mpp.txtciud.Text = DtgProveedores.CurrentRow.Cells["Ciudad"].Value.ToString();
            mpp.txttel.Text = DtgProveedores.CurrentRow.Cells["Telefono"].Value.ToString();
            mpp.txtfax.Text = DtgProveedores.CurrentRow.Cells["Fax"].Value.ToString();

            resul = mpp.ShowDialog();

            if (mpp.OPTION == "OK")
            {
                try
                {
                    Op.IdProveedor = int.Parse(mpp.txtId.Text);
                    Op.CedProveedor = mpp.txtcedula.Text;
                    Op.Nombre = mpp.txtNom.Text;
                    Op.Representante = mpp.txtRep.Text;
                    Op.Direccion = mpp.txtDir.Text;
                    Op.Ciudad = mpp.txtciud.Text;
                    Op.Telefono = mpp.txttel.Text;
                    Op.Fax = mpp.txtfax.Text;
                    Opln.ModificarProveedor(Op);
                    MostrarProvedores();

                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void tool_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult resul;

         resul = MessageBox.Show("Esta seguro de eliminar registro", "Informacion del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
         if (resul == DialogResult.Yes)
         {
             try
             {
                 int cod = int.Parse(DtgProveedores.CurrentRow.Cells["IdProveedor"].Value.ToString());
                 Op.IdProveedor = cod;
                 Opln.EliminarProveedor(Op);
                 MostrarProvedores();
             }

             catch (Exception mes)
             {
                 MessageBox.Show(mes.Message);
             }
         }
         }

        private void cellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modoseleccion)
            {
                idprov= DtgProveedores.CurrentRow.Cells[0].Value.ToString();
                nombreprov = DtgProveedores.CurrentRow.Cells[2].Value.ToString();
                modoseleccion = false;
                this.Hide();

            }
           

        }

        private void tool_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        }
}
