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

        private void btnSave_Click(object sender, EventArgs e)
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

            if (lbGroups.SelectedItems.Count > 1)
            {
                MessageBox.Show("Mas de un grupo seleccionado");
            }
            else
            {
                MessageBox.Show("Solo un grupo");
            }

        }



        private void cargarUsuarios()         
        {
            _ListUsuaris = UsuarisOrm.Select();
                        
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


        private void actualizarGrupos()
        {
            lbGroups.Items.Clear();

            _grups = GrupsOrm.Select();
            lbGroups.Items.Add("Todas las relaciones");

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

        private void btnAdd_Click(object sender, EventArgs e)
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

        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbGroups.SelectedItems.Count > 1)
            {
                MessageBox.Show("Mas de un grupo seleccionado");
                lbListSkills.SelectionMode = SelectionMode.One;
                dgvUsers.MultiSelect = false;
            }
            else
            {
                MessageBox.Show("Solo un grupo");
                lbListSkills.SelectionMode = SelectionMode.MultiExtended;
                dgvUsers.MultiSelect = true;
            }
        }

        private void lbListSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbListSkills.SelectedItems.Count > 1)
            {
                MessageBox.Show("Mas de una skill seleccionado");
                lbGroups.SelectionMode = SelectionMode.One;
            }
            else
            {
                MessageBox.Show("Solo una skill");
                lbGroups.SelectionMode = SelectionMode.MultiExtended;
            }
        }
    }
}
