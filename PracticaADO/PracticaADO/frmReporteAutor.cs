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
    public partial class frmReporteAutor : Form
    {
        public frmReporteAutor()
        {
            InitializeComponent();
        }

        private void frmReporteAutor_Load(object sender, EventArgs e)
        {
            AutorLN aut = new AutorLN();
            DSAutor ds = new DSAutor();
            try
            {

                prueba1 rpt = new prueba1();
                rpt.SetDataSource(aut.obtenerAutor());
                crystalReportViewer1.ReportSource = rpt;


            }
            catch (Exception men){
                MessageBox.Show(men.ToString());
            }
            
        }
    }
}
