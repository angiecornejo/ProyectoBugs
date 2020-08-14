using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBugs
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin fl;
            // fl pasa a ser una variable que es del tipo formLogin. Luego la inicializo. 
            fl = new frmLogin();
            
            fl.ShowDialog();
            // Show es un evento que me permite mostrar.
            // Show dialog me permite mostrarlo sin que se pueda cerrar




            // fl.Dispose() -- Libera los recursos de memoria
        }
    }
}
