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
    public partial class FormListaSkills : Form
    {
        private String NombreSkill;

        public FormListaSkills()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            llistes_skills _llistes_Skills = new llistes_skills();
            _llistes_Skills.nom = "Nueva Lista";
            _llistes_Skills.skills = null;
            _llistes_Skills.actiu = true;

            CrearBotonListaSkill(_llistes_Skills);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void SeleccionarLista_Click(object sender, EventArgs e, RadioButton btnListSkill, String nombre)         
        {
            NombreSkill = nombre;
            MessageBox.Show(NombreSkill);
        }

        private void FormListaSkills_Load(object sender, EventArgs e)
        {
            List<llistes_skills> _llistes_Skills = Llistes_SkillsOrm.Select();

            if (_llistes_Skills.Count() >= 1)            
            {
                foreach (llistes_skills lSkills in _llistes_Skills)
                {
                    CrearBotonListaSkill(lSkills);
                }
            }


        }

        private void btnBuildTable_Click(object sender, EventArgs e)
        {
            dgvListaSkills.Columns.Clear();
            dgvListaSkills.DataSource = null;
            dgvListaSkills.DefaultCellStyle.Font = new Font("Microsoft Sans Serif",15,FontStyle.Bold);
            dgvListaSkills.Columns.Add("Letra", "Letra");
            dgvListaSkills.Columns.Add("Skill","Skill");

            Char[] letras = txtNameListSkill.Text.ToCharArray();             

            for(int i = 0; i < letras.Length; i++)
            {
                dgvListaSkills.Rows.Add(letras[i].ToString().ToUpper(), "");                
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";
           

            llistes_skills _llistes_Skills = new llistes_skills();
            _llistes_Skills.nom = txtNameListSkill.Text.ToUpper();
            _llistes_Skills.skills = null;
            _llistes_Skills.actiu = true;

            missatge = Llistes_SkillsOrm.Insert(_llistes_Skills);

            if (missatge != "")
            {
                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataGridViewRow row in dgvListaSkills.Rows)
                {

                    skills _skill = new skills();
                    _skill.nom = row.Cells["Skill"].Value.ToString();
                    _skill.llistes_skills_id = _llistes_Skills.id;
                    _skill.actiu = true;
                    _skill.colorFondo = Color.Black.ToArgb();
                    _skill.colorTexto = Color.White.ToArgb();

                    missatge = SkillsOrm.Insert(_skill);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }

            
           

            this.Close();

        }


        private void CrearBotonListaSkill(llistes_skills ls)         
        {
            
            RadioButton btnListSkill = new RadioButton();
            btnListSkill.Appearance = Appearance.Button;
            btnListSkill.Text = ls.nom;
            String nombre = btnListSkill.Text;
            btnListSkill.FlatStyle = FlatStyle.Flat;
            btnListSkill.TextAlign = ContentAlignment.MiddleCenter;
            btnListSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 20, FontStyle.Bold);
            btnListSkill.BackColor = Color.Black;
            btnListSkill.ForeColor = Color.White;
            btnListSkill.Size = new Size(200, 55);
            btnListSkill.FlatAppearance.CheckedBackColor = Color.Blue;
            btnListSkill.Margin = new Padding(24, 8, 4, 4);
            flpListSkills.Controls.Add(btnListSkill);


            btnListSkill.Click += (sender2, e2) => SeleccionarLista_Click(sender2, e2, btnListSkill, nombre);

        }



    }
}
