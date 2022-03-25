using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Models;

namespace DesktopApp
{
    public partial class FormCrearUsuarios : Form
    {
        usuaris _usuaris = new usuaris();
        private usuaris usuarioAEditar;

        public FormCrearUsuarios()
        {
            InitializeComponent();
        }

        public FormCrearUsuarios(usuaris usuarioAEditar)
        {
            this.usuarioAEditar = usuarioAEditar;
            InitializeComponent();
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
        private void FormCrearUsuarios_Load(object sender, EventArgs e)
        {
            bsRols.DataSource = RolsOrm.Select();
            cbActiu.Checked = true;
            cbxSelectionPerfil.SelectedItem = null;
            tbPassword.UseSystemPasswordChar = true;
            tbRepeatPassword.UseSystemPasswordChar = true;
            if(usuarioAEditar != null)
            {
                tbName.Text = usuarioAEditar.nom;
                tbLastName.Text = usuarioAEditar.cognoms;
                tbEmail.Text = usuarioAEditar.correo;
                tbUser.Text = usuarioAEditar.nomUsuari;
                cbActiu.Checked = usuarioAEditar.actiu;
                cbxSelectionPerfil.SelectedItem = usuarioAEditar.rols;
                MessageBox.Show("Dejar el campo de contraseña en blanco para seguir utilizando la contraseña antigua","Información",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool check = false;
            bool checkPass = false;
            bool checkEmail = false;
            
            if (tbEmail.Equals("")) {
                check = true;
            }
            checkEmail = ValidarEmail(tbEmail.Text);
            
            if (tbUser.Text.Equals("")) {
                check = true;
            }
            if (tbPassword.Text.Equals("")) {
                check = true;
            }
            if (tbPassword.Text.Equals(tbRepeatPassword.Text)) {
                checkPass = true;
            }
            if (tbLastName.Text.Equals("")) {
                check = true;
            }
            if (tbName.Text.Equals("")) {
                check = true;
            }

            if (cbxSelectionPerfil.SelectedIndex == -1) {
                checkPass = true;
            }
            if (check == false && checkPass == true && checkEmail == true) {
                _usuaris.correo = tbEmail.Text;
                _usuaris.contrasenya = BCrypt.Net.BCrypt.EnhancedHashPassword(tbPassword.Text,hashType: BCrypt.Net.HashType.SHA512);
                _usuaris.rols= (rols)cbxSelectionPerfil.SelectedItem;
                _usuaris.nom = tbName.Text;
                _usuaris.cognoms = tbLastName.Text;
                _usuaris.nomUsuari = tbUser.Text;
                _usuaris.actiu = cbActiu.Checked;
                _usuaris.imagen = null;
                String missatge = UsuarisOrm.Insert(_usuaris);
                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }
        public static bool ValidarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void cbLookPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLookPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void cbRepeatPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRepeatPassword.Checked)
            {
                tbRepeatPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbRepeatPassword.UseSystemPasswordChar = true;
            }
        }
        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
