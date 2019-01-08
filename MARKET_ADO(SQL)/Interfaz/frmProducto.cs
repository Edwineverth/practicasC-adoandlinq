using Entidades.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        /*-----------------Metodos Personalizados-----------------*/
        public bool guardar = false;
        public Item auxProv = null;
        public Item auxCat = null;
        frmVerProveedor frmC = new frmVerProveedor();

        public void limpiarCajasTexto()
        {
            txtId.Text = "";
            txtNom.Text = "";
            txtUn.Text = "";
            txtPreP.Text = "";
            txtStA.Text = "";
            txtStM.Text = "";
            txtProv.Text = "";
        }

        public void seleccionarCombos(int idCat, int idProv)
        {
            Item cat=null;
            foreach(Item c in cbxCat.Items){
                if (Convert.ToInt32(c.Value) == idCat)
                    cat = c;
            }

            Item prov = null;
            foreach (Item p in frmC.listBox1.Items)
            {
                if (Convert.ToInt32(p.Value) == idProv)
                    prov = p;
            }

            cbxCat.SelectedItem = cat;
            frmC.listBox1.SelectedItem = prov;
            txtProv.Text = prov.Text;
        }

        public void llenarCombos(List<DataRow> c, List<DataRow> p)
        {
            if (cbxCat.Items.Count == 0)
            {
                cbxCat.DisplayMember = "Text";
                frmC.listBox1.DisplayMember = "Text";
                cbxCat.ValueMember = "Value";
                frmC.listBox1.ValueMember = "Value";

                List<Item> lst = new List<Item>();
                foreach (DataRow cat in c)
                {
                    Item item = new Item();
                    item.Text = cat[1].ToString();
                    item.Value = Convert.ToInt32(cat[0].ToString());
                    lst.Add(item);
                }
                cbxCat.DataSource = lst;

                List<Item> lstP = new List<Item>();
                foreach (DataRow prov in p)
                {
                    Item item = new Item();
                    item.Text = prov[2].ToString();
                    item.Value = Convert.ToInt32(prov[0].ToString());
                    lstP.Add(item);
                }

                frmC.listBox1.DataSource = lstP;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            auxCat = (Item)cbxCat.SelectedItem;
            guardar = true;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            guardar = false;
            this.Close();
        }

        private void btnProvBus_Click(object sender, EventArgs e)
        {
            frmC.ShowDialog();
            if (frmC.ok == true)
            {
                try
                {
                    auxProv = (Item)frmC.listBox1.SelectedItem;
                    txtProv.Text = auxProv.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
