using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente.Inventario
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        CategoriaLN Opln = new CategoriaLN();
        Categoria Op = new Categoria();
        frmEditCategoria fp = new frmEditCategoria();

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }

        private void mostrarCategorias()
        {
            DtgCategorias.DataSource = Opln.obtenerCategorias();
        }

        private void tool_nuevo_Click(object sender, EventArgs e)
        {
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {

                    Op.Id_cat = int.Parse(fp.txtId.Text);
                    Op.Categoria_cat = fp.txtCategoria.Text;
                    Op.Descripcion_cat = fp.txtDes.Text;
                    Opln.insertarCategoria(Op);
                    mostrarCategorias();


                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void tool_editar_Click(object sender, EventArgs e)
        {
            fp.limpiarCajasTexto();
            llenarCampos();
            fp.ShowDialog();

            if (fp.OPTION == "OK")
            {
                try
                {
                    Op.Id_cat = int.Parse(fp.txtId.Text);
                    Op.Categoria_cat = fp.txtCategoria.Text;
                    Op.Descripcion_cat = fp.txtDes.Text;
                    Opln.actualizarCategoria(Op);
                    MessageBox.Show("ID:"+Op.Id_cat+"   >CAT:"+Op.Categoria_cat+"   >DES:"+Op.Descripcion_cat);
                    mostrarCategorias();
                }
                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void llenarCampos()
        {
            int indiceFila = DtgCategorias.CurrentCell.RowIndex;
            string id = DtgCategorias[0, indiceFila].Value.ToString();
            Categoria c = Opln.obtenerCategoria(id).First();

            fp.txtId.Text = c.Id_cat + "";
            fp.txtCategoria.Text = c.Categoria_cat;
            fp.txtDes.Text = c.Descripcion_cat;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            DtgCategorias.DataSource = Opln.filtrarCategorias(txtbuscar.Text);
        }

        private void tool_eliminar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if (res.ToString().Equals("Yes"))
            {
                try
                {
                    int indiceFila = DtgCategorias.CurrentCell.RowIndex;
                    string id = DtgCategorias[0, indiceFila].Value.ToString();
                    Opln.eliminarCategoria(int.Parse(id));
                    MessageBox.Show("Se han eliminado los datos!");
                    mostrarCategorias();
                }catch(Exception er){
                    MessageBox.Show(er.Message);
                }
            }
        }

        private void tool_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
