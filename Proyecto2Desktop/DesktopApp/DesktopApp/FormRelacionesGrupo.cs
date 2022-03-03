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
    public partial class FormRelacionesGrupo : Form
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

        public FormRelacionesGrupo()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManagmentCourses_Click(object sender, EventArgs e)
        {
            FormCursos formCursos = new FormCursos();
            formCursos.ShowDialog();
            cargarCursos();
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 1)
            {

                lbGroups.SelectionMode = SelectionMode.One;
            }
            else
            {
                lbGroups.SelectionMode = SelectionMode.MultiExtended;
            }
        }

        private void lbListSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbListSkills.SelectedItems.Count > 1)
            {
                lbGroups.SelectionMode = SelectionMode.One;
            }
            else
            {
                lbGroups.SelectionMode = SelectionMode.MultiExtended;
            }
        }

        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGroups.SelectedItems.Count > 1)
            {
                lbListSkills.SelectionMode = SelectionMode.One;
                dgvUsers.MultiSelect = false;
            }
            else
            {
                lbListSkills.SelectionMode = SelectionMode.MultiExtended;
                dgvUsers.MultiSelect = true;
            }
        }

        private void FormRelacionesGrupo_Load(object sender, EventArgs e)
        {
            actualizarGrupos();
            cargarCursos();

            if (gruposStatus.Equals("GuposListasSkills"))
            {
                cargarListasSkills();
                lbListSkills.Visible = true;
                pnlSearchUsers.Visible = false;
                dgvUsers.Visible = false;
                lbListSkills.Visible = true;
            }
            else
            {
                cargarUsuarios();
                lbListSkills.Visible = false;
                pnlSearchUsers.Visible = true;
                dgvUsers.Visible = true;
                lbListSkills.Visible = false;
            }
        }


        private void cargarCursos()
        {
            bindingSourceCourses.DataSource = null;
            bindingSourceCourses.DataSource = CursosOrm.Select();

        }

        private void cargarUsuarios()
        {
            _ListUsuaris = UsuarisOrm.Select();

            if (_ListUsuaris != null)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Docent";
                checkBoxColumn.Name = "checkBox";



                dgvUsers.DataSource = null;
                dgvUsers.Columns.Add("Usuari", "Usuari");
                dgvUsers.Columns["Usuari"].ReadOnly = true;
                dgvUsers.Columns.Add(checkBoxColumn);

                foreach (usuaris item in _ListUsuaris)
                {
                    dgvUsers.Rows.Add(item.nom);
                }
            }



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


        private void cargarListasSkills()
        {
            _llistesSkills = Llistes_SkillsOrm.Select();

            foreach (llistes_skills ls in _llistesSkills)
            {
                lbListSkills.Items.Add(ls.nom);
            }
        }

    }
}
