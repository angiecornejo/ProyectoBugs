using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoBugs.Formularios;


namespace ProyectoBugs
{
    public partial class frmConsultaGralBugs : Form
    {

        Datos oBD = new Datos();

        public frmConsultaGralBugs()
        {
            InitializeComponent();
        }

        private void frmConsultaGralBugs_Load(object sender, EventArgs e)
        {
            dtpFechaDesde.Value = DateTime.Today;
            dtpFechaHasta.Value = DateTime.Today;

            cboEstado.DataSource = oBD.consultar("SELECT * FORM estados")
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
