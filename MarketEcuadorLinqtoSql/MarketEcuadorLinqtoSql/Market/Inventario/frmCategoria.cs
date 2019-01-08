using Entidades;
using LogicaNegocio.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Inventario
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        public bool modoseleccion = false;
        public string idcat = "";
        public string categorianom = "";
        //public bool seleccionar = false;
        public string OPTION = "";
        Categoria Op = new Categoria();
        CategoriaLN OPLN = new CategoriaLN();
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarProvedores();
        }

        private void dtgcelldoubleclick(object sender, DataGridViewCellEventArgs e)
        {
 
  
            if (modoseleccion)
            {
                idcat=dtgCategoria.CurrentRow.Cells[0].Value.ToString();
                categorianom = dtgCategoria.CurrentRow.Cells[1].Value.ToString();
                modoseleccion = false;                
                this.Hide();
                OPTION = "OK";

            }
        }
        private void MostrarProvedores()
        {
            dtgCategoria.DataSource = OPLN.ListarCategorias(txtbuscar.Text);
        }
        private void tool_nuevo_Click(object sender, EventArgs e)
        {
            frmEditCategoria fp = new frmEditCategoria();
            DialogResult resul = new DialogResult();
            resul = fp.ShowDialog();
            if (fp.OPTION == "OK")
            {
                try
                {

                    // Op.IdProveedor = int.Parse(fp.txtId.Text);
                    Op.Categoria1 = fp.txtcategoria.Text;
                    Op.Descripcion = fp.txtdescripcion.Text;
                    
                    OPLN.InsertarCategoria(Op);
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
            frmEditCategoria mpp = new frmEditCategoria();
            DialogResult resul = new DialogResult();
            mpp.modificar = true;
            mpp.txtIdcat.Text = dtgCategoria.CurrentRow.Cells[0].Value.ToString();
            mpp.txtcategoria.Text = dtgCategoria.CurrentRow.Cells[1].Value.ToString();
            mpp.txtdescripcion.Text = dtgCategoria.CurrentRow.Cells[2].Value.ToString();
            
            resul = mpp.ShowDialog();

            if (mpp.OPTION == "OK")
            {
                try
                {
                    Op.Idcategoria = int.Parse(mpp.txtIdcat.Text);
                    Op.Categoria1 = mpp.txtcategoria.Text;
                    Op.Descripcion = mpp.txtdescripcion.Text;
                   
                    OPLN.ModificarCategoria(Op);
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
                    int cod = int.Parse(dtgCategoria.CurrentRow.Cells[0].Value.ToString());
                    Op.Idcategoria = cod;
                    OPLN.EliminarCategoria(Op);
                    MostrarProvedores();
                }

                catch (Exception mes)
                {
                    MessageBox.Show(mes.Message);
                }
            }
        }

        private void tool_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarProvedores();
        }

      
    }
}
