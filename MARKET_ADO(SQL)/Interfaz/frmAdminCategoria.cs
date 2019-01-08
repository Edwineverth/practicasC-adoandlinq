using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Objetos;
using LogicaNegocio;

namespace Interfaz
{
    public partial class frmAdminCategoria : Form
    {
        public frmAdminCategoria()
        {
            InitializeComponent();
        }

        /*------------------Métodos Personalizados--------------*/
        Categoria c = new Categoria();
        frmCategoria frmC = new frmCategoria();
        LNCategoria lnC = new LNCategoria();
        int opc = 0;

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            opc = 1;
            frmC.limpiarCajasTexto();
            frmC.ShowDialog();
            if (frmC.guardar == true)
            {
                try
                {
                    lnC.Insertar(getCategoria());
                    MessageBox.Show("Se ha insertado los datos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                mostrarCategorias();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            opc = 2;
            frmC.limpiarCajasTexto();
            llenarCampos();
            frmC.ShowDialog();

            if (frmC.guardar == true)
            {
                lnC.Actualizar(getCategoria());
                MessageBox.Show("Se han actualizado los datos");
                mostrarCategorias();
            }
        }

        private void llenarCampos()
        {
            int indiceFila = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1[0, indiceFila].Value.ToString();
            string nom = dataGridView1[1, indiceFila].Value.ToString();
            string des = dataGridView1[2, indiceFila].Value.ToString();
           
            frmC.txtId.Text = id;
            frmC.txtNom.Text = nom;
            frmC.txtRep.Text = des;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = lnC.ListarFiltro(txtBuscar.Text);
            dataGridView1.DataSource = dt;
        }

        private Categoria getCategoria()
        {
            Categoria p = new Categoria();
            if (opc == 2)
                p.Id_cat = int.Parse(frmC.txtId.Text);
            p.Categoria_cat = frmC.txtNom.Text;
            p.Descripcion_cat = frmC.txtRep.Text;

            return p;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);

            if (res.ToString().Equals("Yes"))
            {
                int indiceFila = dataGridView1.CurrentCell.RowIndex;
                string id = dataGridView1[0, indiceFila].Value.ToString();
                lnC.Eliminar(int.Parse(id));
                MessageBox.Show("Se han eliminado los datos!");
                mostrarCategorias();
            }
        }

        private void mostrarCategorias()
        {
            try
            {
                dataGridView1.DataSource = lnC.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmAdminCategoria_Load(object sender, EventArgs e)
        {
            mostrarCategorias();
        }
    }
}
