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
using System.Runtime.InteropServices;//Mover ventana

namespace DesktopApp
{
    public partial class FormGestionPerfil : Form
    {
        rols _rol;
        bool checkModificar = false;
        public FormGestionPerfil(){
            InitializeComponent();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Para mover la pestaña
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);
        private void pnBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ckbAllPermision_CheckedChanged(object sender, EventArgs e)
        {
            ckbEmptyPermision.Checked = false;
            ckbKPIGestion.Checked = true;
            ckbListSkilsGestion.Checked = true;
            ckbSkillsGestion.Checked = true;
            ckbUsersGestion.Checked = true;
            ckbPerfilGestion.Checked = true;
            ckbGroupGestion.Checked = true;
        }

        private void ckbEmptyPermision_CheckedChanged(object sender, EventArgs e)
        {
            ckbAllPermision.Checked = false;
            ckbKPIGestion.Checked = false;
            ckbListSkilsGestion.Checked = false;
            ckbSkillsGestion.Checked = false;
            ckbUsersGestion.Checked = false;
            ckbPerfilGestion.Checked = false;
            ckbGroupGestion.Checked = false;

        }

        private void FormGestionPerfil_Load(object sender, EventArgs e)
        {
            bsRols.DataSource = RolsOrm.Select();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (tbPerfilName.Text == "")
            {
                check = true;
            }

            if (check == true)
            {
                MessageBox.Show("El nombre del perfil esta vacio");
            }
            else if (checkModificar == true) {

                _rol.nom = tbPerfilName.Text;
                _rol.actiu = ckbActiu.Checked;
                _rol.GestionarGrupos = ckbGroupGestion.Checked;
                _rol.GestionarKPIs = ckbKPIGestion.Checked;
                _rol.GestionarListaSkills = ckbListSkilsGestion.Checked;
                _rol.GestionarPerfiles = ckbPerfilGestion.Checked;
                _rol.GestionarSkills = ckbSkillsGestion.Checked;
                _rol.GestionarUsuarios = ckbUsersGestion.Checked;
                _rol.actiu = ckbActiu.Checked;
                RolsOrm.Update(_rol);
                tbPerfilName.Text = "";
                ckbActiu.Checked = false;
                ckbGroupGestion.Checked = false;
                ckbKPIGestion.Checked = false;
                ckbListSkilsGestion.Checked = false;
                ckbPerfilGestion.Checked = false;
                ckbSkillsGestion.Checked = false;
                ckbUsersGestion.Checked = false;
                ckbActiu.Checked = false;
                FormGestionPerfil_Load(_rol, e);
            }
            else
            {
                _rol = new rols();
                _rol.nom = tbPerfilName.Text;
                _rol.GestionarKPIs = ckbKPIGestion.Checked;
                _rol.GestionarListaSkills = ckbListSkilsGestion.Checked;
                _rol.GestionarSkills = ckbListSkilsGestion.Checked;
                _rol.GestionarUsuarios = ckbUsersGestion.Checked;
                _rol.GestionarPerfiles = ckbPerfilGestion.Checked;
                _rol.GestionarGrupos = ckbGroupGestion.Checked;
                _rol.actiu = true;
                RolsOrm.Insert(_rol);
                tbPerfilName.Text = "";
                ckbActiu.Checked=false;
                ckbGroupGestion.Checked = false;
                ckbKPIGestion.Checked = false;
                ckbListSkilsGestion.Checked = false;
                ckbPerfilGestion.Checked = false;
                ckbSkillsGestion.Checked = false;
                ckbUsersGestion.Checked = false;
                ckbActiu.Checked = false;
                FormGestionPerfil_Load(_rol, e);
            }
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ckbActiu.Visible = true;
                checkModificar = true;
                btnNew.Visible = true;
                _rol = (rols)dataGridView1.SelectedRows[0].DataBoundItem;
                tbPerfilName.Text = _rol.nom;
                ckbActiu.Checked = _rol.actiu;
                ckbGroupGestion.Checked = _rol.GestionarGrupos;
                ckbKPIGestion.Checked = _rol.GestionarKPIs;
                ckbListSkilsGestion.Checked = _rol.GestionarListaSkills;
                ckbPerfilGestion.Checked = _rol.GestionarPerfiles;
                ckbSkillsGestion.Checked = _rol.GestionarSkills;
                ckbUsersGestion.Checked = _rol.GestionarUsuarios;
                ckbActiu.Checked = _rol.actiu;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbPerfilName.Text = "";
            ckbActiu.Checked = false;
            ckbGroupGestion.Checked = false;
            ckbKPIGestion.Checked = false;
            ckbListSkilsGestion.Checked = false;
            ckbPerfilGestion.Checked = false;
            ckbSkillsGestion.Checked = false;
            ckbUsersGestion.Checked = false;
            ckbActiu.Checked = false;
            checkModificar = false;
        }
    }
}