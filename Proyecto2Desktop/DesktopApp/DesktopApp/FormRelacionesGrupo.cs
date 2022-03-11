﻿using System;
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


        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            //Si hay una sola row seleccionada y el combobox de la relacion de un grupo tiene muchas listas esta activada mostrar en 
            //la listbox las Listas del grupo seleccionado
            if (dgvGroups.SelectedRows.Count == 1 && rdbOneGroupHasListUsers.Checked)
            {
                _grup = CogerGrupoSeleccionado();                
                lblDates.Text = "Skills de:";
                lblDataSelect.Text = _grup.nom;
                cargarListasDeGrupo(_grup.id);
            }
        }


        private void dgvListSkills_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListSkills.SelectedRows.Count == 1 && rdbOneListUserHasGroups.Checked)
            {
                _llistaSkill = CogerListaSkillSeleccionada();                
                lblDates.Text = "Grupos de:";
                lblDataSelect.Text = _llistaSkill.nom;
                cargarGruposDeLista(_llistaSkill.id);

            }

        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 1)
            {

                
            }
            else
            {
                
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
                pnlGroupsHasSkills.Visible = true;
                pnlGrupsStudTeach.Visible = false;
               
                
                
            }
            else
            {
                cargarUsuarios();
                dgvListSkills.Visible = false;
                pnlSearchUsers.Visible = true;
                dgvUsers.Visible = true;
                pnlGroupsHasSkills.Visible = false;
                pnlGrupsStudTeach.Visible = true;
            }
        }


        private void cargarCursos()
        {
            _cursos = CursosOrm.SelectActius();

            bindingSourceCourses.DataSource = null;
            bindingSourceCourses.DataSource = _cursos;

            bindingSourceCoursesListSkillsUsers.DataSource = null;
            bindingSourceCoursesListSkillsUsers.DataSource = _cursos;

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
            dgvUsers.ClearSelection();


        }


        private void cargarGrupos()
        {
            //lbGroups.Items.Clear();

            _grups = GrupsOrm.Select();

            foreach (grups grup in _grups)
            {
                dgvGroups.Rows.Add(grup.nom);
            }

            ////bindingSourceGroups.DataSource = null;
            //bindingSourceGroups.DataSource = GrupsOrm.Select();
            //lbGroups.ClearSelected();
        }


        private void cargarListasSkills()
        {
            _llistesSkills = Llistes_SkillsOrm.Select();

            foreach (llistes_skills ls in _llistesSkills)
            {
                dgvListSkills.Rows.Add(ls.nom);
            }
            dgvListSkills.ClearSelection();
        }

        private void cargarListasDeGrupo(int id) 
        {
            lbGroupsHasSkills.Items.Clear();
            List<grups_has_llistes_skills> _GrupsLlistesSKills = GrupsHasLlistesSkillsOrm.Select(id);

            foreach (grups_has_llistes_skills item in _GrupsLlistesSKills)
            {
                llistes_skills _llistes = Llistes_SkillsOrm.SelectListaSkill(item.llistes_skills_id);
                lbGroupsHasSkills.Items.Add(_llistes.nom);
            }

        }

        private void cargarGruposDeLista(int id) 
        {
            lbGroupsHasSkills.Items.Clear();
            List<grups_has_llistes_skills> _GrupsLlistesSKills = GrupsHasLlistesSkillsOrm.SelectGrupsOfLists(id);        

            foreach (grups_has_llistes_skills item in _GrupsLlistesSKills)
            {
                grups _grup = GrupsOrm.SelectGrup(item.grups_id);
                lbGroupsHasSkills.Items.Add(_grup.nom);
            }
        }

        



        private void btnSave_Click(object sender, EventArgs e)
        {
            string missatge = "";

            List<grups_has_llistes_skills> Lista_grups_LListes = new List<grups_has_llistes_skills>();

            if (gruposStatus.Equals("GuposListasSkills"))
            {
                int gruposSelec = dgvGroups.SelectedRows.Count;

                if (gruposSelec <= 1)
                {
                    //Solo un grupo seleccionado     
                    
                    foreach (DataGridViewRow rowLListes in dgvListSkills.SelectedRows)
                    {
                        
                        foreach (llistes_skills llista in _llistesSkills)
                        {

                            if (rowLListes.Cells[0].Value.Equals(llista.nom))
                            {
                                //Crear objeto grups_hasllistesSkills de las rows seleccionadas
                                grups_has_llistes_skills Select_grupsLListes = new grups_has_llistes_skills();
                                Select_grupsLListes.grups_id = _grup.id;
                                Select_grupsLListes.llistes_skills_id = llista.id;
                                                                
                                DataGridViewComboBoxCell comboBoxCell = rowLListes.Cells[1] as DataGridViewComboBoxCell;
                                                                
                                //pasar a String el combobox de la datagridview seleccionado
                                String nomCurs = (string)comboBoxCell.Value;

                                if (nomCurs != null)
                                {

                                    int idCurs = 0;
                                    //Recorrer todos los dadots de los cursos y filtrar para coger el id del seleccionado
                                    foreach (cursos cursos in _cursos)
                                    {
                                        if (nomCurs.Equals(cursos.nom))
                                        {
                                            idCurs = cursos.id;
                                        }
                                    }

                                    Select_grupsLListes.curs_id = idCurs;
                                    Lista_grups_LListes.Add(Select_grupsLListes);
                                }

                            }
                        }
                    }

                    //Si la lista tiene al menos un elemento añadir a la base de datos
                    if (Lista_grups_LListes.Count >= 1)
                    {
                        //Una vez guardados los datos seleccionados añadirlos a la tabla de Grups_has_llistes_skillls
                        foreach (grups_has_llistes_skills gLlistes in Lista_grups_LListes)
                        {
                           
                            missatge = GrupsHasLlistesSkillsOrm.Insert(gLlistes);

                            if (missatge != "")
                            {
                                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }

                        MessageBox.Show("Listas añadidas al grupo");
                    }

                   


                }
                else
                {
                    //Mas de un grupo seleccionado

                    foreach (DataGridViewRow rowGrups in dgvGroups.SelectedRows)
                    {
                        foreach (grups grup in _grups)
                        {

                            if (rowGrups.Cells[0].Value.Equals(grup.nom))
                            {
                                //Crear objeto grups_hasllistesSkills de las rows seleccionadas
                                grups_has_llistes_skills Select_grupsLListes = new grups_has_llistes_skills();
                                Select_grupsLListes.grups_id = grup.id;
                                Select_grupsLListes.llistes_skills_id = _llistaSkill.id;

                                DataGridViewComboBoxCell comboBoxCell = rowGrups.Cells[1] as DataGridViewComboBoxCell;

                                //pasar a String el combobox de la datagridview seleccionado
                                String nomCurs = (string)comboBoxCell.Value;

                                if (nomCurs != null)
                                {
                                    int idCurs = 0;
                                    //Recorrer todos los datos de los cursos y filtrar para coger el id del seleccionado
                                    foreach (cursos cursos in _cursos)
                                    {
                                        if (nomCurs.Equals(cursos.nom))
                                        {
                                            idCurs = cursos.id;
                                        }
                                    }

                                    Select_grupsLListes.curs_id = idCurs;
                                    Lista_grups_LListes.Add(Select_grupsLListes);



                                }
                            }
                        }
                    }

                    //Si la lista tiene al menos un elemento añadir a la base de datos
                    if (Lista_grups_LListes.Count >= 1)
                    {
                        //Una vez guardados los datos seleccionados añadirlos a la tabla de Grups_has_llistes_skillls
                        foreach (grups_has_llistes_skills gLlistes in Lista_grups_LListes)
                        {

                            missatge = GrupsHasLlistesSkillsOrm.Insert(gLlistes);

                            if (missatge != "")
                            {
                                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }

                        MessageBox.Show("grupos añadidos a las listas");
                    }

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

            if (gruposStatus.Equals("GuposListasSkills"))
            {
                foreach (DataGridViewRow item in dgvListSkills.SelectedRows)
                {                  
                    item.Cells[1].Value = curs.nom;
                }
            }
            else
            {
                foreach (DataGridViewRow item in dgvUsers.SelectedRows)
                {                   
                    item.Cells[2].Value = curs.nom;
                }
            }

            


        }


        private grups CogerGrupoSeleccionado() 
        {
            grups grup = new grups();

            foreach (DataGridViewRow item in dgvGroups.SelectedRows)
            {
                String nombre = (string)item.Cells[0].Value;
                grup.nom = nombre;

                foreach (grups itemGrup in _grups)
                {
                    if (itemGrup.nom.Equals(nombre))
                    {
                        grup.id = itemGrup.id;
                        grup.actiu = itemGrup.actiu;
                    }
                }
            }

            return grup;

        }



        private llistes_skills CogerListaSkillSeleccionada() 
        {
            llistes_skills llistes_Skills = new llistes_skills();

            foreach (DataGridViewRow item in dgvListSkills.SelectedRows)
            {               
                String nombre = (string)item.Cells[0].Value;
                llistes_Skills.nom = nombre;
                
                foreach (llistes_skills lskils in _llistesSkills)
                {
                    if (lskils.nom.Equals(nombre))
                    {
                        llistes_Skills.id = lskils.id;
                        llistes_Skills.actiu = lskils.actiu;
                    }
                }
            }


            return llistes_Skills;
        }



        private void cbxGroupsCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            cursos curs = (cursos)cbxGroupsCourses.SelectedItem;

            foreach (DataGridViewRow item in dgvGroups.SelectedRows)
            {
                item.Cells[1].Value = curs.nom;
              
            }

        }

        private void rdbOneGroupHasListUsers_CheckedChanged(object sender, EventArgs e)
        {
            dgvGroups.MultiSelect = false;
            dgvListSkills.MultiSelect = true;
            dgvUsers.MultiSelect = true;
        }

        private void rdbOneListUserHasGroups_CheckedChanged(object sender, EventArgs e)
        {
            dgvGroups.MultiSelect = true;
            dgvListSkills.MultiSelect = false;
            dgvUsers.MultiSelect = false;
        }
    }
}
