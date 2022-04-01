using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private void pb_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);
        private void pnBarra_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbTitulo_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pcIcono_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }//

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            Boolean entrar;
            String user = txtBoxUsername.Text;
            String contrasenya = txtBoxContrasenya.Text;
            entrar = UsuarisOrm.SelectLogin(user, contrasenya);
            if (entrar)
            {
                FormPrincipal formPrincipal = new FormPrincipal();
                this.Hide();
                formPrincipal.ShowDialog();   
            }
            else
            {
                txtBoxUsername.Text = "";
                txtBoxContrasenya.Text = "";
                pbError.Visible = true;
                txtError.Visible = true;
                linkForgetPassword.Visible = true;
            }
        }
        private void ckbLookPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLookPass.Checked)
            {
                txtBoxContrasenya.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxContrasenya.UseSystemPasswordChar = true;
            }
        }
    }
}