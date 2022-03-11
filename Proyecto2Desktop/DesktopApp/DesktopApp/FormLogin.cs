using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Models;

namespace DesktopApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            Boolean entrar;

            String correu = textBoxUsername.Text;
            String contrasenya = textBoxContrasenya.Text;
            entrar = UsuarisOrm.SelectLogin(correu, contrasenya);
            if (entrar)
            {
                
                FormPrincipal formprincipal = new FormPrincipal();
                this.Hide();
                formprincipal.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Vuelve a introducir los credenciales");
            }
           
           

        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            
        }
    }
}
