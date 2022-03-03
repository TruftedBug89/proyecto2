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
    public partial class FormGestionGrupo : Form
    {
        private llistes_skills _llistaSkill;        
        private List<llistes_skills> _llistesSkills;
        private grups _grup;
        private List<grups> _grups;
        private usuaris _usuaris;
        private List<usuaris> _ListUsuaris;
        private String gruposStatus;
        private cursos _curs;
        private List<cursos> _cursos;

        public FormGestionGrupo(String gruposStatus)
        {
            InitializeComponent();
            this.gruposStatus = gruposStatus;
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGestionGrupo_Load(object sender, EventArgs e)
        {
            actualizarGrupos();
                        

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_grup != null)
            {
                //update
            }
            else
            {
                grups Grup = new grups();
                Grup.nom = txtNameGroup.Text;

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

            actualizarGrupos();

        }

        private void cargarCursos() 
        {
            bindingSourceCourses.DataSource = null;
            bindingSourceCourses.DataSource = CursosOrm.Select();

        }



        private void actualizarGrupos()
        {
            lbGroups.Items.Clear();

            _grups = GrupsOrm.Select();

            foreach (grups grp in _grups)
            {
                lbGroups.Items.Add(grp.nom);
            }

        }



        private void btnManagmentCourses_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();
            formCursos.ShowDialog();
            cargarCursos();
        }
    }
}
