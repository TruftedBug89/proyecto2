using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Models;

namespace DesktopApp
{
    public partial class FormSkill : Form
    {
        private skills _skill;
        private List<skills> _skills;
        int id_llista;
        private List<Color> colores = new List<Color>() {Color.Red,Color.Blue,Color.Green,Color.Black,Color.Orange,Color.White};

        public FormSkill()
        {
            InitializeComponent();
        }

        public FormSkill(int id)
        {
            InitializeComponent();
            this.id_llista = id;
        }


        private void FormSkill_Load(object sender, EventArgs e)
        {
            _skills = SkillsOrm.SelectIdLlista(id_llista);

            foreach (skills skill in _skills)
            {
                CrearBotonSkills(skill);
            }
            
        }

        private void SeleccionarSkill_Click(object sender, EventArgs e, RadioButton btnSkill, skills S)
        {
            _skill = S;

            if (_skill != null)
            {
                txtNameSkill.Text = _skill.nom;
                char[] letras = _skill.nom.ToCharArray();
                txtWordSkill.Text = letras[0].ToString();
                cboActivate.Checked = _skill.actiu;
                txtBcolor.BackColor = Color.FromArgb(_skill.colorFondo);
                txtTcolor.BackColor = Color.FromArgb(_skill.colorTexto);
            }
            else
            {
                vaciarCampos();
            }

            
           
        }


        private void CrearBotonSkills(skills _skill)
        {
            RadioButton btnSkill = new RadioButton();
            btnSkill.Appearance = Appearance.Button;

            if (_skill == null) 
            {
                btnSkill.Text = "n";
                btnSkill.BackColor = Color.Black;
                btnSkill.ForeColor = Color.White;
            }
            else
            {
                char[] letra = _skill.nom.ToCharArray();
                btnSkill.Text = letra[0].ToString();
                btnSkill.BackColor = Color.FromArgb(_skill.colorFondo);
                btnSkill.ForeColor = Color.FromArgb(_skill.colorTexto);
            }

            String nombre = btnSkill.Text;
            btnSkill.FlatStyle = FlatStyle.Flat;
            btnSkill.FlatAppearance.BorderSize = 0;
            btnSkill.TextAlign = ContentAlignment.MiddleCenter;
            btnSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 30, FontStyle.Bold);
            btnSkill.Size = new Size(85, 75);
            btnSkill.FlatAppearance.CheckedBackColor = Color.Blue;
            btnSkill.Margin = new Padding(120, 15, 4, 4);
            flpSkills.Controls.Add(btnSkill);

            btnSkill.Click += (sender2, e2) => SeleccionarSkill_Click(sender2, e2, btnSkill, _skill);
        }



        private void btnBColor_Click(object sender, EventArgs e)
        {
            cdBackgroundColor.ShowDialog();
            Color color = cdBackgroundColor.Color;            
            txtBcolor.BackColor = color;
        }

        private void btnTColor_Click(object sender, EventArgs e)
        {
            cdTextColor.ShowDialog();
            Color color = cdTextColor.Color;
            txtTcolor.BackColor = color;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_skill != null)
            {

                missatge = SkillsOrm.Update(_skill, txtNameSkill.Text, cboActivate.Checked, txtBcolor.BackColor.ToArgb(), txtTcolor.BackColor.ToArgb());

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Datos actualizados");
                }
            }
            else
            {
                
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _skill = null;

            CrearBotonSkills(_skill);
            vaciarCampos();

        }

        public void vaciarCampos() 
        {
            txtNameSkill.Text = "";
            txtWordSkill.Text = "";
            cboActivate.Checked = false;
            txtBcolor.BackColor = Color.White;
            txtTcolor.BackColor = Color.White;
        }



    }
}
