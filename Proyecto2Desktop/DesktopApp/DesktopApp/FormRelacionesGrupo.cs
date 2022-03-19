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
        private usuaris _usuari;
        private List<usuaris> _ListUsuaris;
        private String gruposStatus;
        private cursos _curs;
        private List<cursos> _cursos;

        private grups_has_llistes_skills _grupsLListes;
        private grups_has_docents _grupsDocents;
        private grups_has_alumnes _grupsAlumnes;

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
            dgvListSkills.ClearSelection();
            dgvUsers.ClearSelection();
            FormCursos formCursos = new FormCursos(gruposStatus);
            formCursos.ShowDialog();
            cargarCursos();
           
        }

        private void lbgroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbgroups.SelectedItem != null)
            {
                _grup = (grups)lbgroups.SelectedItem;

                if (gruposStatus.Equals("GuposListasSkills"))
                {
                    lblDates.Text = "Skills de:";
                    lblDataSelect.Text = _grup.nom;
                    cargarListasDeGrupo(_grup.id);
                }
                else
                {                   
                    lblRelationType.Text = "Usuaris de:";
                    lblData.Text = _grup.nom;
                    cargarUsuariosDocentesDeGrupo(_grup.id);
                    cargarUsuariosAlumnosDeGrupo(_grup.id);

                }


                
                
            }
            
        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            //Si hay una sola row seleccionada  mostrar en la listbox las Listas del grupo seleccionado

            //if (dgvGroups.SelectedRows.Count == 1)
            //{
            //    _grup = CogerGrupoSeleccionado();                
            //    lblDates.Text = "Skills de:";
            //    lblDataSelect.Text = _grup.nom;
            //    cargarListasDeGrupo(_grup.id);
            //}
        }


        private void dgvListSkills_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListSkills.SelectedRows.Count == 1)
            {
                _llistaSkill = CogerListaSkillSeleccionada();                
                lblDates.Text = "Grupos de:";
                lblDataSelect.Text = _llistaSkill.nom;
                cargarGruposDeLista(_llistaSkill.id);

            }

        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 1)
            {
                _usuari = CogerUsuarioSeleccionado();
                
                lblRelationType.Text = "Grupos de:";
                lblData.Text = _usuari.nom;
                cargarUsuariosDocentesDeGrupo(_usuari.id);
                cargarUsuariosAlumnosDeGrupo(_usuari.id);



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

            if (cbxCourses.Items.Count != 0)
            {
                cursos curs = (cursos)cbxCourses.SelectedItem;

                foreach (DataGridViewRow item in dgvUsers.Rows)
                {
                    item.Cells[2].Value = curs.nom;
                }
            }
                      


        }


        private void cargarGrupos()
        {
            
            _grups = GrupsOrm.SelectActivos();

            //foreach (grups grup in _grups)
            //{
            //    dgvGroups.Rows.Add(grup.nom);
            //}

            bindingSourceGroups.DataSource = null;
            bindingSourceGroups.DataSource = _grups;
            lbgroups.ClearSelected();
        }


        private void cargarListasSkills()
        {
            _llistesSkills = Llistes_SkillsOrm.Select();

            foreach (llistes_skills ls in _llistesSkills)
            {
                dgvListSkills.Rows.Add(ls.nom);
            }
            dgvListSkills.ClearSelection();


            if (cbxCourses.Items.Count != 0)
            {
                cursos curs = (cursos)cbxCourses.SelectedItem;

                foreach (DataGridViewRow item in dgvListSkills.Rows)
                {
                    item.Cells[1].Value = curs.nom;
                }
            }
            


        }

        private void cargarListasDeGrupo(int id) 
        {
            bindingSourceGrupsHasSkills.DataSource = null;
            lbGroupsHasSkills.DataSource = null;
            lbGroupsHasSkills.Items.Clear();
            List<grups_has_llistes_skills> _GrupsLlistesSKills = GrupsHasLlistesSkillsOrm.Select(id);

            bindingSourceGrupsHasSkills.DataSource = _GrupsLlistesSKills;
            lbGroupsHasSkills.DataSource = bindingSourceGrupsHasSkills;
            lbGroupsHasSkills.DisplayMember = "llistes_skills_id";
            lbGroupsHasSkills.ValueMember = "grups_id";

            //foreach (grups_has_llistes_skills item in _GrupsLlistesSKills)
            //{
            //    llistes_skills _llistes = Llistes_SkillsOrm.SelectListaSkill(item.llistes_skills_id);
            //    lbGroupsHasSkills.Items.Add(_llistes.nom);
            //}

            //foreach (grups_has_llistes_skills item in lbGroupsHasSkills.Items)
            //{
            //    MessageBox.Show(item.llistes_skills_id.ToString());

            //}



        }

        private void cargarGruposDeLista(int id) 
        {
            bindingSourceGrupsHasSkills.DataSource = null;
            lbGroupsHasSkills.DataSource = null;
            lbGroupsHasSkills.Items.Clear();
            List<grups_has_llistes_skills> _GrupsLlistesSKills = GrupsHasLlistesSkillsOrm.SelectGrupsOfLists(id);


            bindingSourceGrupsHasSkills.DataSource = _GrupsLlistesSKills;
            lbGroupsHasSkills.DataSource = bindingSourceGrupsHasSkills;
            lbGroupsHasSkills.DisplayMember = "grups_id";
            lbGroupsHasSkills.ValueMember = "grups_id";


            //foreach (grups_has_llistes_skills item in _GrupsLlistesSKills)
            //{
            //    grups _grup = GrupsOrm.SelectGrup(item.grups_id);
            //    lbGroupsHasSkills.Items.Add(_grup.nom);
            //}
        }


        private void cargarUsuariosDocentesDeGrupo(int id) 
        {
            bindingSourceGroupsHasTeachers.DataSource = null;
            lbTeachers.DataSource = null;

            lbTeachers.Items.Clear();
           
            if (lblRelationType.Text.Equals("Usuaris de:"))
            {
                List<grups_has_docents> _GrupsDocents = GrupsHasDocentsOrm.Select(id);

                bindingSourceGroupsHasTeachers.DataSource = _GrupsDocents;
                lbTeachers.DataSource = bindingSourceGroupsHasTeachers;
                lbTeachers.DisplayMember = "usuaris_id";
                lbTeachers.ValueMember = "grups_id";
            }
            else
            {
                List<grups_has_docents> _UsersGroup = GrupsHasDocentsOrm.SelectGroupOfUser(id);
                bindingSourceGroupsHasTeachers.DataSource = _UsersGroup;
                lbTeachers.DataSource = bindingSourceGroupsHasTeachers;
                lbTeachers.DisplayMember = "grups_id";
                lbTeachers.ValueMember = "usuaris_id";
            }




            //foreach (grups_has_docents item in _GrupsDocents)
            //{
            //    usuaris _user = UsuarisOrm.SelectUsuari(item.usuaris_id);
            //    lbTeachers.Items.Add(_user.nom);
            //}

        }

        private void cargarUsuariosAlumnosDeGrupo(int id)
        {
            
            bindingSourceGrupsHasStudents.DataSource = null;
            lbStudents.DataSource = null;

            lbStudents.Items.Clear();

            if (lblRelationType.Text.Equals("Usuaris de:"))
            {
                
                List<grups_has_alumnes> _GrupsStudents = GrupsHasAlumnesOrm.Select(id);
                bindingSourceGrupsHasStudents.DataSource = _GrupsStudents;
                lbStudents.DataSource = bindingSourceGrupsHasStudents;
                lbStudents.DisplayMember = "usuaris_id";
                lbStudents.ValueMember = "grups_id";
            }
            else
            {
                List<grups_has_alumnes> _UsersGroup = GrupsHasAlumnesOrm.SelectGroupOfUser(id);
                bindingSourceGrupsHasStudents.DataSource = _UsersGroup;
                lbStudents.DataSource = bindingSourceGrupsHasStudents;
                lbStudents.DisplayMember = "grups_id";
                lbStudents.ValueMember = "usuaris_id";
            }








            //foreach (grups_has_alumnes item in _GrupsStudents)
            //{              
            //    usuaris _user = UsuarisOrm.SelectUsuari(item.usuaris_id);
            //    lbStudents.Items.Add(_user.nom);                
            //}

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string missatge = "";

            if (lbgroups.SelectedItems.Count == 1)
            {
                if (gruposStatus.Equals("GuposListasSkills") && dgvListSkills.SelectedRows.Count >=1)
                {
                    List<grups_has_llistes_skills> Lista_grups_LListes = new List<grups_has_llistes_skills>();

                    //Solo un grupo seleccionado, Recorrer la cantidad de rows de listas seleleccionadas
                    foreach (DataGridViewRow rowLListes in dgvListSkills.SelectedRows)
                    {
                        //por cada row filtrar por la lista de skills cargadas anteriormente
                        foreach (llistes_skills llista in _llistesSkills)
                        {
                            // filtrar por nombre para encontrar los ids de la lista
                            if (rowLListes.Cells[0].Value.Equals(llista.nom))
                            {
                                //Crear objeto grups_hasllistesSkills de las rows seleccionadas con los ids de la lista y el id del grupo seleccionado
                                grups_has_llistes_skills Select_grupsLListes = new grups_has_llistes_skills();
                                Select_grupsLListes.grups_id = _grup.id;
                                Select_grupsLListes.llistes_skills_id = llista.id;
                                Select_grupsLListes.curs_id = cogerIdCursoDataGridViewCombo(rowLListes, 1);

                                //Finalmente añadir el objeto a una lista de grups_has_llistes_skills
                                Lista_grups_LListes.Add(Select_grupsLListes);
                                

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
                else if(dgvUsers.SelectedRows.Count >= 1)
                {
                    List<grups_has_docents> Lista_grups_Docents = new List<grups_has_docents>();
                    List<grups_has_alumnes> Lista_grups_Alumnes = new List<grups_has_alumnes>();

                    foreach (DataGridViewRow rowUsuaris in dgvUsers.SelectedRows)
                    {
                        DataGridViewCheckBoxCell chkchecking = rowUsuaris.Cells[1] as DataGridViewCheckBoxCell;
                        string UserText = rowUsuaris.Cells[0].Value.ToString();

                        bool EsProfesor = Convert.ToBoolean(chkchecking.Value);
                        if (EsProfesor)
                        {
                            //añadir en grups_has_docents                            

                            foreach (usuaris usuari in _ListUsuaris)
                            {
                                if (UserText.Equals(usuari.nom))
                                {
                                    grups_has_docents Select_GrupsDocents = new grups_has_docents();
                                    Select_GrupsDocents.grups_id = _grup.id;
                                    Select_GrupsDocents.usuaris_id = usuari.id;
                                    Select_GrupsDocents.curs_id = cogerIdCursoDataGridViewCombo(rowUsuaris, 2);
                                    Lista_grups_Docents.Add(Select_GrupsDocents);


                                }
                            }

                        }
                        else
                        {
                            //añadir en grups_has_alumnes                            

                            foreach (usuaris usuari in _ListUsuaris)
                            {
                                if (UserText.Equals(usuari.nom))
                                {
                                    grups_has_alumnes Select_GrupsAlumnes = new grups_has_alumnes();
                                    Select_GrupsAlumnes.grups_id = _grup.id;
                                    Select_GrupsAlumnes.usuaris_id = usuari.id;
                                    Select_GrupsAlumnes.curs_id = cogerIdCursoDataGridViewCombo(rowUsuaris, 2);
                                    Lista_grups_Alumnes.Add(Select_GrupsAlumnes);


                                }
                            }


                        }

                    }

                    if (Lista_grups_Docents.Count >= 1)
                    {
                        foreach (grups_has_docents GrupsDocents in Lista_grups_Docents)
                        {
                            missatge = GrupsHasDocentsOrm.Insert(GrupsDocents);

                            if (missatge != "")
                            {
                                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        MessageBox.Show("Profesores añadidos al grupo");
                    }

                    if (Lista_grups_Alumnes.Count >= 1)
                    {
                        foreach (grups_has_alumnes GrupsAlumnes in Lista_grups_Alumnes)
                        {
                            missatge = GrupsHasAlumnesOrm.Insert(GrupsAlumnes);

                            if (missatge != "")
                            {
                                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        MessageBox.Show("Alumnos añadidos al grupo");
                    }


                }
                else
                {
                    MessageBox.Show("No se puede hacer la relacion");
                }
            }
            else
            {
                MessageBox.Show("No se puede hacer la relacion");
            }


        }

        private void cbxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCourses.Items.Count > 0)
            {
                if (dgvListSkills.SelectedRows.Count > 0 || dgvUsers.SelectedRows.Count > 0)
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

            }

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

        private usuaris CogerUsuarioSeleccionado() 
        {
            usuaris usuari = new usuaris();

            foreach (DataGridViewRow item in dgvUsers.SelectedRows)
            {
                String nombre = (string)item.Cells[0].Value;
                usuari.nom = nombre;

                foreach (usuaris lusuaris in _ListUsuaris)
                {
                    if (lusuaris.nom.Equals(nombre))
                    {
                        usuari.id = lusuaris.id;
                        usuari.rols_id = lusuaris.rols_id;
                        usuari.actiu = lusuaris.actiu;
                        usuari.correo = lusuaris.correo;
                        usuari.contrasenya = lusuaris.contrasenya;

                    }
                }
            }
            return usuari;


        }




        private int cogerIdCursoDataGridViewCombo(DataGridViewRow fila, int celda) 
        {
            //pasar a String el combobox de la datagridview seleccionado
            String nomCurs = (string)fila.Cells[celda].Value;

            int idCurs = 0;
            //Recorrer todos los datos de los cursos y filtrar para coger el id del seleccionado y añdirlo al ultimo dato del objeto
            foreach (cursos cursos in _cursos)
            {
                if (nomCurs.Equals(cursos.nom))
                {
                    idCurs = cursos.id;
                }
            }


            return idCurs;
             
        }

        private void btnManagmentGroups_Click(object sender, EventArgs e)
        {
            dgvListSkills.ClearSelection();
            dgvUsers.ClearSelection();
            FormGestionGrupo formGestionGrupo = new FormGestionGrupo(gruposStatus);
            formGestionGrupo.ShowDialog();
            cargarGrupos();
        }

        private void lbGroupsHasSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             _grupsLListes = (grups_has_llistes_skills)lbGroupsHasSkills.SelectedItem;
            

        }

        private void lbGroupsHasSkills_Format(object sender, ListControlConvertEventArgs e)
        {
            

        }

        private void btnDeleteRelation_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_grupsLListes != null)
            {
                missatge = GrupsHasLlistesSkillsOrm.Delete(_grupsLListes);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Relacion Eliminada");
                    _grupsLListes = null;


                    if (lblDates.Text.Equals("Grupos de:"))
                    {
                        cargarGruposDeLista(_llistaSkill.id);
                    }
                    else
                    {
                        cargarListasDeGrupo(_grup.id);
                    }


                }


            }
            else
            {
                MessageBox.Show("Selecciona un item");
            }

        }

        private void dgvListSkills_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvListSkills.Rows[0].Selected = false;
        }

        private void btnDropTeachersRelation_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_grupsDocents != null)
            {                              
                missatge = GrupsHasDocentsOrm.Delete(_grupsDocents);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Relacion Eliminada");
                    _grupsDocents = null;

                    if (lblRelationType.Text.Equals("Usuaris de:"))
                    {

                        cargarUsuariosDocentesDeGrupo(_grup.id);
                    }
                    else
                    {
                        cargarUsuariosDocentesDeGrupo(_usuari.id);
                    }


                }

            }
            else
            {
                MessageBox.Show("Selecciona un item");
            }



        }

        private void lbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
           _grupsDocents = (grups_has_docents)lbTeachers.SelectedItem;
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            _grupsAlumnes = (grups_has_alumnes)lbStudents.SelectedItem;
        }

        private void btnDropStudentsRelation_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_grupsAlumnes != null)
            {
                missatge = GrupsHasAlumnesOrm.Delete(_grupsAlumnes);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Relacion Eliminada");
                    _grupsAlumnes = null;

                    if (lblRelationType.Text.Equals("Usuaris de:"))
                    {

                        cargarUsuariosAlumnosDeGrupo(_grup.id);
                    }
                    else
                    {
                        cargarUsuariosAlumnosDeGrupo(_usuari.id);
                    }


                }

            }
            else
            {
                MessageBox.Show("Selecciona un item");
            }
        }


    }
}
