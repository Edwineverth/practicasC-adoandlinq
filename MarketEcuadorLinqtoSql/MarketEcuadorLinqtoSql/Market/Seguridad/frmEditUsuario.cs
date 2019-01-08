using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Seguridad
{
    public partial class frmEditUsuario : Form
    {
        public string OPTION = "";
        public frmEditUsuario()
        {
            InitializeComponent();
        }
        public byte[] foto = null;
        public bool MODIFICAR = false;
        private void tool_grabar_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            
            if (this.txtcedula.Text == "") { errorProvider1.SetError(this.txtcedula, "Ingrese el Número de Cédula"); return; }
            if (this.txtnombre.Text == "") { errorProvider1.SetError(this.txtnombre, "Ingrese el Nombre del Usuario"); return; }
            if (this.txtdireccion.Text == "") { errorProvider1.SetError(this.txtdireccion, "Ingrese la Dirección del Usuario"); return; }
            if (this.txttelefono.Text == "") { errorProvider1.SetError(this.txttelefono, "Ingrese el teléfono del usuario"); return; }
            if (this.txtlogin.Text == "") { errorProvider1.SetError(this.txtlogin, "Ingrese el Login del usuario"); return; }
            if (this.txtclave.Text == "")
            {
                errorProvider1.SetError(this.txtclave, "Ingrese la clave del usuario"); return;

            }
            else
            {
                OPTION = "OK";
                this.Close();
            }

        }

        private void tool_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.openFileDialog1.InitialDirectory = "C:/";
            this.openFileDialog1.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg";
            this.openFileDialog1.FilterIndex = 4;

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pict_foto.Image = Image.FromFile(this.openFileDialog1.FileName);
                this.pict_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pict_foto.BorderStyle = BorderStyle.Fixed3D;
                this.pict_foto.Tag = this.openFileDialog1.FileName;

            }
        }

        private void frmEditUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                byte[] imageData = foto.ToArray();
                Image newImage;
                using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                {
                    ms.Write(imageData, 0, imageData.Length);
                    newImage = Image.FromStream(ms, true);
                }
                pict_foto.SizeMode = PictureBoxSizeMode.StretchImage;
                pict_foto.Image = newImage;

                }catch(Exception ){
                    
                }

        }
    }
}
