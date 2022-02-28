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
        public FormGestionPerfil()
        {
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
            else
            {
                rols _rol = new rols();
                _rol.nom = tbPerfilName.Text;
                _rol.GestionarKPIs = ckbKPIGestion.Checked;
                _rol.GestionarListaSkills = ckbListSkilsGestion.Checked;
                _rol.GestionarSkills = ckbListSkilsGestion.Checked;
                _rol.GestionarUsuarios = ckbUsersGestion.Checked;
                _rol.GestionarPerfiles = ckbPerfilGestion.Checked;
                _rol.GestionarGrupos = ckbGroupGestion.Checked;
                RolsOrm.Insert(_rol);
                tbPerfilName.Text = "";
                FormGestionPerfil_Load(_rol, e);
            }

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            String missatge = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Estàs segur que vols borrar aquest curs?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    RolsOrm.Delete((rols)dataGridView1.SelectedRows[0].DataBoundItem);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                rols rolsObject = (rols)dataGridView1.SelectedRows[0].DataBoundItem;
                rolsObject.nom = tbPerfilName.Text;
            }
        }
        //
    }
}
