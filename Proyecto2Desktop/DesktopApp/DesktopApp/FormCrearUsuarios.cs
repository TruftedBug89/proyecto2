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
            bool campoVacio = false;
            bool contrasIguales = false;
            bool emailValido = false;

            if (String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                campoVacio = true;
            }
            else {
                emailValido = ValidarEmail(tbEmail.Text);   
            }
            

            if (String.IsNullOrWhiteSpace(tbUser.Text)) {
                campoVacio = true;
            }
            if (String.IsNullOrWhiteSpace(tbPassword.Text)) {
                contrasIguales = true;
            }
            if (tbPassword.Text.Equals(tbRepeatPassword.Text)) {
                contrasIguales = true;
            }
            if (String.IsNullOrWhiteSpace(tbLastName.Text)) {
                campoVacio = true;
            }
            if (String.IsNullOrWhiteSpace(tbName.Text)) {
                campoVacio = true;
            }
            if (cbxSelectionPerfil.SelectedIndex == -1) {
                campoVacio = true;
            }
            if (usuarioAEditar != null && !campoVacio && emailValido)
            {
                usuarioAEditar.nom = tbName.Text;
                usuarioAEditar.cognoms = tbLastName.Text;
                usuarioAEditar.nomUsuari = tbUser.Text;
                usuarioAEditar.actiu = cbActiu.Checked;
                rols rolselect = (rols)cbxSelectionPerfil.SelectedItem;
                usuarioAEditar.rols_id = rolselect.id;
                usuarioAEditar.correo = tbEmail.Text;
                if (!String.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    if ((tbPassword.Text).Equals(tbRepeatPassword.Text)) {
                        usuarioAEditar.contrasenya = BCrypt.Net.BCrypt.EnhancedHashPassword(tbPassword.Text, hashType: BCrypt.Net.HashType.SHA512);
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no son iguales");
                        return;
                    }
                }
                Models.UsuarisOrm.Update(usuarioAEditar);
                MessageBox.Show("Usuari "+ usuarioAEditar.nom +" actualizado correctamente");
                this.Close();
                return;
            }
            if (campoVacio == false && contrasIguales == true && emailValido == true) {

                _usuaris.correo = tbEmail.Text;
                _usuaris.contrasenya = BCrypt.Net.BCrypt.EnhancedHashPassword(tbPassword.Text,hashType: BCrypt.Net.HashType.SHA512);

                //esto si
                rols rolselect = (rols)cbxSelectionPerfil.SelectedItem;
                _usuaris.rols_id = rolselect.id;

                //_usuaris.rols = (rols)cbxSelectionPerfil.SelectedItem;
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
            MessageBox.Show("Nothing happended");
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

        private void btnGroupManagment_Click(object sender, EventArgs e)
        {
            FormGestionGrupo fgg = new FormGestionGrupo("");
            fgg.ShowDialog();
        }
        private void pb_minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
