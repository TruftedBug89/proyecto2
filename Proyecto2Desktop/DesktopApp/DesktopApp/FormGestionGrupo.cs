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
    public partial class FormGestionGrupo : Form
    {
        private llistes_skills _llistaSkill;        
        private List<llistes_skills> _llistesSkills;
        private grups _grup;
        private List<grups> _grups;
        private usuaris _usuaris;
        private List<usuaris> _ListUsuaris;
        private cursos _curs;
        private List<cursos> _cursos;
        public String gruposStatus;

        public FormGestionGrupo(String status)
        {
            InitializeComponent();
            this.gruposStatus = status;
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FormGestionGrupo_Load(object sender, EventArgs e)
        {
            actualizarGrupos();

        }


        private void actualizarGrupos()
        {
                    
            bindingSourceGroups.DataSource = null;
            bindingSourceGroups.DataSource = GrupsOrm.Select();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_grup != null)
            {
                missatge = GrupsOrm.Update(_grup,txtNameGroup.Text,cboActivate.Checked);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Grupo actualizado");
                }

            }
            else
            {
                if (txtNameGroup.Text.Equals(""))
                {
                    MessageBox.Show("Introduce un nombre del grupo");
                }
                else
                {
                    grups Grup = new grups();
                    Grup.nom = txtNameGroup.Text;
                    Grup.actiu = cboActivate.Checked;

                    missatge = GrupsOrm.Insert(Grup);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Grupo añadido");
                    }
                }
              

            }

            actualizarGrupos();
            VaciarCampos();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
           _grup = (grups)lbGroups.SelectedItem;

            if (_grup != null)
            {
                txtNameGroup.Text = _grup.nom;
                cboActivate.Checked = (bool)_grup.actiu;
            }
            
        }

        private void VaciarCampos() 
        {
            _grup = null;
            lbGroups.SelectedItem = null;
            txtNameGroup.Text = "";
            cboActivate.Checked = false;          

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            VaciarCampos();
        }

        private void pb_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
