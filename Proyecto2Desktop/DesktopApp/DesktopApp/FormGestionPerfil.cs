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
            ckbManagmentCourses.Checked = true;
            cxbRelationsGroups.Checked = true;
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
            ckbManagmentCourses.Checked = false;
            cxbRelationsGroups.Checked = false;

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
                _rol.gestionarGrupos = ckbGroupGestion.Checked;
                _rol.gestionarKPIs = ckbKPIGestion.Checked;
                _rol.gestionarListaSkills = ckbListSkilsGestion.Checked;
                _rol.gestionarPerfiles = ckbPerfilGestion.Checked;
                _rol.gestionarSkills = ckbSkillsGestion.Checked;
                _rol.gestionarUsuarios = ckbUsersGestion.Checked;
                _rol.gestionarCursos = ckbManagmentCourses.Checked;
                _rol.gestionarRelacionesGrupos = cxbRelationsGroups.Checked;
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
                ckbManagmentCourses.Checked = false;
                cxbRelationsGroups.Checked = false;
                ckbActiu.Checked = false;
                FormGestionPerfil_Load(_rol, e);
            }
            else
            {
                _rol = new rols();
                _rol.nom = tbPerfilName.Text;
                _rol.gestionarKPIs = ckbKPIGestion.Checked;
                _rol.gestionarListaSkills = ckbListSkilsGestion.Checked;
                _rol.gestionarSkills = ckbListSkilsGestion.Checked;
                _rol.gestionarUsuarios = ckbUsersGestion.Checked;
                _rol.gestionarPerfiles = ckbPerfilGestion.Checked;
                _rol.gestionarGrupos = ckbGroupGestion.Checked;
                _rol.gestionarCursos = ckbManagmentCourses.Checked;
                _rol.gestionarRelacionesGrupos = cxbRelationsGroups.Checked;
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
                ckbManagmentCourses.Checked = false;
                cxbRelationsGroups.Checked = false;
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
                ckbGroupGestion.Checked = _rol.gestionarGrupos;
                ckbKPIGestion.Checked = _rol.gestionarKPIs;
                ckbListSkilsGestion.Checked = _rol.gestionarListaSkills;
                ckbPerfilGestion.Checked = _rol.gestionarPerfiles;
                ckbSkillsGestion.Checked = _rol.gestionarSkills;
                ckbUsersGestion.Checked = _rol.gestionarUsuarios;
                ckbManagmentCourses.Checked = _rol.gestionarCursos;
                cxbRelationsGroups.Checked = _rol.gestionarRelacionesGrupos;
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
            ckbManagmentCourses.Checked = false;
            cxbRelationsGroups.Checked = false;
            ckbActiu.Checked = false;
            checkModificar = false;
        }

        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
