using CapaDatos;
using Entidades;
using LogicaNegocio.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Seguridad
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        UsuarioLN OPLN = new UsuarioLN();
        Usuario Op = new Usuario();
        public void mostrarUsuarios()
        {
            DtgUsuarios.DataSource = OPLN.ListarUsuarios(txtbuscar.Text);
        }
        private void tool_nuevo_Click(object sender, EventArgs e)
        {
            frmEditUsuario fp = new frmEditUsuario();
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {

                    // Op.IdProveedor = int.Parse(fp.txtId.Text);
                    Op.cedula = fp.txtcedula.Text;
                    Op.nombres = fp.txtnombre.Text;
                    Op.direccion = fp.txtdireccion.Text;
                    Op.telefono = fp.txttelefono.Text;
                    Op.login = fp.txtlogin.Text;
                    Op.clave = fp.txtclave.Text;
                    Op.foto = fp.pict_foto.Image;
                    OPLN.InsertarUsuario(Op);
                    mostrarUsuarios();

                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }

        }
            
            
         
        private void tool_editar_Click(object sender, EventArgs e)
        {
            frmEditUsuario mpp = new frmEditUsuario();
            DialogResult resul = new DialogResult();
            mpp.MODIFICAR = true;
            
            mpp.foto = OPLN.getImageById(DtgUsuarios.CurrentRow.Cells[0].Value.ToString());
            mpp.txtidusuario.Text = DtgUsuarios.CurrentRow.Cells[0].Value.ToString();
            mpp.txtcedula.Text = DtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            mpp.txtnombre.Text = DtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            mpp.txtdireccion.Text = DtgUsuarios.CurrentRow.Cells[3].Value.ToString();
            mpp.txttelefono.Text = DtgUsuarios.CurrentRow.Cells[4].Value.ToString();
            mpp.txtlogin.Text = DtgUsuarios.CurrentRow.Cells[5].Value.ToString();
            mpp.txtclave.Text = DtgUsuarios.CurrentRow.Cells[6].Value.ToString();
           // mpp.txtIdcat.Text = dtgCategoria.CurrentRow.Cells[0].Value.ToString();
           // mpp.txtcategoria.Text = dtgCategoria.CurrentRow.Cells[1].Value.ToString();
           // mpp.txtdescripcion.Text = dtgCategoria.CurrentRow.Cells[2].Value.ToString();

            resul = mpp.ShowDialog();

            if (mpp.OPTION == "OK")
            {
                try
                {
                    //Op.Idcategoria = int.Parse(mpp.txtIdcat.Text);
                    //Op.Categoria1 = mpp.txtcategoria.Text;
                    //Op.Descripcion = mpp.txtdescripcion.Text;

                    //OPLN.ModificarCategoria(Op);
                    //MostrarProvedores();
                    Op.idusuario =int.Parse( mpp.txtidusuario.Text);
                    Op.cedula = mpp.txtcedula.Text;
                    Op.nombres = mpp.txtnombre.Text;
                    Op.direccion = mpp.txtdireccion.Text;
                    Op.telefono = mpp.txttelefono.Text;
                    Op.login = mpp.txtlogin.Text;
                    Op.clave = mpp.txtclave.Text;
                    Op.foto = mpp.pict_foto.Image;
                    OPLN.ModificarUsuario(Op);
                    mostrarUsuarios();
                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void tool_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void tool_salir_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }
    }
}
