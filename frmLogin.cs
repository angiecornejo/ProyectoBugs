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
    public partial class frmLogin : Form
    {
        //string user = "admin";
        //string pass = "1234";
    
        public frmLogin()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Button1 es Aceptar
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar usuario...");
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtClave.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una clave...");
                this.txtClave.Focus();
                return;

            }

            // Validar usuario y clave

            string m = "Login Ok"; 
            string n = "Usuario y/o clave incorrectos";

            if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pass)
                MessageBox.Show(m, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show(n, "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }


        // Button2 es close
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
