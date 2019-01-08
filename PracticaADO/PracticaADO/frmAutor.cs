using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;


namespace PracticaADO
{
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }
        
        AutorLN autLN = new AutorLN ();
        Autor a = new Autor();
        frmReporteAutor frrAutor = new frmReporteAutor();
        
       

        private void frmAutor_Load(object sender, EventArgs e)
        {
           DtgAutor.DataSource = autLN.obtenerAutor();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frrAutor.Show();
        }
    }
}
