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

        private grups_has_llistes_skills _grupsLListes;
        private List<grups_has_llistes_skills> Lista_grups_LListes;


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


            //foreach (DataGridViewRow item in dgvUsers.SelectedRows)
            //{

            //}
            
        }


        private void dgvListSkills_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListSkills.SelectedRows.Count > 1)
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
            _grup = (grups)lbGroups.SelectedItem;

            if (lbGroups.SelectedItems.Count > 1)
            {
                dgvListSkills.MultiSelect = false;
                dgvUsers.MultiSelect = false;
            }
            else
            {
                dgvListSkills.MultiSelect = true;
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
                dgvListSkills.Visible = true;
                pnlSearchUsers.Visible = false;
                dgvUsers.Visible = false;
            }
            else
            {
                cargarUsuarios();
                dgvListSkills.Visible = false;
                pnlSearchUsers.Visible = true;
                dgvUsers.Visible = true;
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
                dgvListSkills.Rows.Add(ls.nom);
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

                  
                    foreach (DataGridViewRow rowLListes in dgvListSkills.SelectedRows)
                    {
                        
                        foreach (llistes_skills llista in _llistesSkills)
                        {

                            if (rowLListes.Cells[0].Value.Equals(llista.nom))
                            {
                                

                                grups_has_llistes_skills Select_grupsLListes = new grups_has_llistes_skills();
                                Select_grupsLListes.grups_id = _grup.id;
                                Select_grupsLListes.llistes_skills_id = llista.id;

                                cursos curs = new cursos();
                                DataGridViewComboBoxCell comboBoxCell = rowLListes.Cells[1] as DataGridViewComboBoxCell;
                                
                                //Select_grupsLListes.curs_id = curs.id;
                                Lista_grups_LListes.Add(Select_grupsLListes);
                            }
                        }
                    }


                    //foreach (grups_has_llistes_skills gLlistes in Lista_grups_LListes)
                    //{
                    //    MessageBox.Show("IdGrup: " + gLlistes.grups_id + ", idSkill: " + gLlistes.llistes_skills_id + ", idCurs: " + gLlistes.curs_id);
                    //}

                   
                }
                else
                {
                    //Mas de un grupo seleccionado
                }
            }
            else
            {
                foreach (DataGridViewRow rowUsuaris in dgvUsers.SelectedRows)
                {
                    DataGridViewCheckBoxCell chkchecking = rowUsuaris.Cells[1] as DataGridViewCheckBoxCell;
                    string UserText = rowUsuaris.Cells[0].Value.ToString();

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
            //int indexCurs = cbxCourses.SelectedIndex;

            if (gruposStatus.Equals("GuposListasSkills"))
            {
                foreach (DataGridViewRow item in dgvListSkills.SelectedRows)
                {
                    DataGridViewComboBoxCell comboBoxCell = item.Cells[1] as DataGridViewComboBoxCell;                                      
                    comboBoxCell.Value = curs.nom;
                }
            }
            else
            {
                foreach (DataGridViewRow item in dgvUsers.SelectedRows)
                {
                    DataGridViewComboBoxCell comboBoxCell = item.Cells[2] as DataGridViewComboBoxCell;
                    comboBoxCell.Value = curs.nom;

                }
            }

            


        }

        private void dgvListSkills_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == 0)
            //{
            //    llistes_skills _llistes = (llistes_skills)dgvListSkills.Rows[e.RowIndex].DataBoundItem;
            //    e.Value = _llistes.nom;
            //}
        }
    }
}
