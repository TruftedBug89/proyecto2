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
        private DataGridViewComboBoxColumn SelectedcomboBoxColumn;
        private List<DataGridViewComboBoxColumn> DataCombosSelecionados = new List<DataGridViewComboBoxColumn>();

        public FormRelacionesGrupo(String status)
        {
            InitializeComponent();
            this.gruposStatus = status;
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
                        
            foreach (DataGridViewComboBoxColumn item in DataCombosSelecionados)
            {
                DataCombosSelecionados.Add(item);
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
            cargarGrupos();
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
            bindingSourceCourses.DataSource = CursosOrm.SelectActius();

        }

        private void cargarUsuarios()
        {
            _ListUsuaris = UsuarisOrm.Select();

            if (_ListUsuaris != null)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Docent";
                checkBoxColumn.Name = "checkBox";


                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.HeaderText = "Curso";
                comboBoxColumn.Name = "combobox";



                dgvUsers.DataSource = null;
                dgvUsers.Columns.Add("Usuari", "Usuari");
                dgvUsers.Columns["Usuari"].ReadOnly = true;
                dgvUsers.Columns.Add(checkBoxColumn);
                dgvUsers.Columns.Add(comboBoxColumn);

                comboBoxColumn.DataSource = CursosOrm.SelectActius();
                comboBoxColumn.DisplayMember = "nom";
                comboBoxColumn.ValueMember = "id";
                

                foreach (usuaris item in _ListUsuaris)
                {
                    dgvUsers.Rows.Add(item.nom);
                }
            }



        }


        private void cargarGrupos()
        {
            //lbGroups.Items.Clear();

            //_grups = GrupsOrm.Select();

            //foreach (grups grp in _grups)
            //{
            //    lbGroups.Items.Add(grp.nom);
            //}
            
            bindingSourceGroups.DataSource = null;
            bindingSourceGroups.DataSource = GrupsOrm.Select();

        }


        private void cargarListasSkills()
        {
            _llistesSkills = Llistes_SkillsOrm.Select();

            foreach (llistes_skills ls in _llistesSkills)
            {
                lbListSkills.Items.Add(ls.nom);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (gruposStatus.Equals("GuposListasSkills"))
            {
                int gruposSelec = lbGroups.SelectedItems.Count;
                if (gruposSelec <= 1)
                {
                    //Solo un grupo seleccionado
                    foreach (llistes_skills llistes in lbListSkills.SelectedItems)
                    {

                    }
                }
                else
                {
                    //Mas de un grupo seleccionado
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvUsers.SelectedRows)
                {
                    DataGridViewCheckBoxCell chkchecking = row.Cells[1] as DataGridViewCheckBoxCell;
                    string UserText = row.Cells[0].Value.ToString();

                    bool EsProfesor = Convert.ToBoolean(chkchecking.Value);
                    if (EsProfesor)
                    {
                        MessageBox.Show("Docent: " + UserText);
                        //añadir en grups_has_docents
                    }
                    else
                    {
                        MessageBox.Show("Alumno: " + UserText);
                        //añadir en grups_has_alumnes
                    }

                }
            }


          


        }

        private void cbxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cursos curs = (cursos)cbxCourses.SelectedItem;

            foreach (DataGridViewComboBoxColumn item in DataCombosSelecionados)
            {
                item.DefaultCellStyle.NullValue = curs.nom;
            }

        }
    }
}
