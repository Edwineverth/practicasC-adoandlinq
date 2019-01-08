using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Entidades;

namespace Cliente.Inventario
{
    public partial class frmProveedor : Form
    {
        public frmProveedor()
        {
            InitializeComponent();
        }
        frmEditProveedor fp = new frmEditProveedor();
        ProveedorLN Opln = new ProveedorLN();
        Proveedor Op = new Proveedor();
        int opc = 0;

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            mostrarProveedores();
        }

        private void mostrarProveedores()
        {
            DtgProveedores.DataSource = Opln.ObtenerProveedoresSP();
        }

        private void tool_eliminar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if (res.ToString().Equals("Yes"))
            {
                int indiceFila = DtgProveedores.CurrentCell.RowIndex;
                string id = DtgProveedores[0, indiceFila].Value.ToString();
                Opln.EliminarProveedor(id);
                MessageBox.Show("Se han eliminado los datos!");
                mostrarProveedores();
            }
        }

        private void tool_nuevo_Click(object sender, EventArgs e)
        {
            opc = 1;
            
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {

                    Op.IdProveedor = int.Parse(fp.txtId.Text);
                    Op.CedProveedor = fp.txtcedula.Text;
                    Op.Nombre = fp.txtNom.Text;
                    Op.Representante = fp.txtRep.Text;
                    Op.Direccion = fp.txtDir.Text;
                    Op.Ciudad = fp.txtciud.Text;
                    Op.Telefono = fp.txttel.Text;
                    Op.Fax = fp.txtfax.Text;
                    Opln.InsertarProveedor(Op);
                    mostrarProveedores();


                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void tool_editar_Click(object sender, EventArgs e)
        {
            opc = 2;
            fp.limpiarCajasTexto();
            llenarCampos();
            fp.ShowDialog();

            if (fp.OPTION == "OK")
            {
                Opln.ModificarProveedor(getProveedor());
                MessageBox.Show("Se han actualizado los datos");
                mostrarProveedores();
            }
        }

        private Proveedor getProveedor()
        {
            Proveedor p = new Proveedor();
            if (opc == 2)
                p.IdProveedor = int.Parse(fp.txtId.Text);
            p.CedProveedor = fp.txtcedula.Text;
            p.Nombre = fp.txtNom.Text;
            p.Representante = fp.txtRep.Text;
            p.Fax = fp.txtfax.Text;
            p.Direccion = fp.txtDir.Text;
            p.Ciudad = fp.txtciud.Text;
            p.Telefono = fp.txttel.Text;

            return p;
        }

        private void llenarCampos()
        {
            int indiceFila = DtgProveedores.CurrentCell.RowIndex;
            string id = DtgProveedores[0, indiceFila].Value.ToString();
            Proveedor p = Opln.ObtenerProveedor(id).First();

            fp.txtId.Text = p.IdProveedor + "";
            fp.txtcedula.Text = p.CedProveedor;
            fp.txtNom.Text = p.Nombre;
            fp.txtRep.Text = p.Representante;
            fp.txtDir.Text = p.Direccion;
            fp.txtciud.Text = p.Ciudad;
            fp.txttel.Text = p.Telefono;
            fp.txtfax.Text = p.Fax;

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Opln.filtrar(txtbuscar.Text);
                DtgProveedores.DataSource = dt;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void tool_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
