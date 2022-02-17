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
        private List<Color> colores = new List<Color>() {Color.Red,Color.Blue,Color.Green,Color.Black,Color.Orange,Color.White};

        public FormSkill()
        {
            InitializeComponent();
        }

        public FormSkill(List<skills> skills)
        {
            InitializeComponent();
            this._skills = skills;
        }


        private void FormSkill_Load(object sender, EventArgs e)
        {
           

            foreach (skills skill in _skills)
            {
                CrearBotonSkills(skill);
            }
            
        }

        private void SeleccionarSkill_Click(object sender, EventArgs e, RadioButton btnSkill, skills S)
        {
            _skill = S;

            txtNameSkill.Text = S.nom;
            char[] letras = S.nom.ToCharArray();
            txtWordSkill.Text = letras[0].ToString();
            txtBcolor.BackColor = Color.FromArgb(S.colorFondo);
            txtTcolor.BackColor = Color.FromArgb(S.colorTexto);
           
        }


        private void CrearBotonSkills(skills _skill)
        {
            RadioButton btnSkill = new RadioButton();
            btnSkill.Appearance = Appearance.Button;
            char[] letra = _skill.nom.ToCharArray();
            btnSkill.Text = letra[0].ToString();
            String nombre = btnSkill.Text;
            btnSkill.FlatStyle = FlatStyle.Flat;
            btnSkill.TextAlign = ContentAlignment.MiddleCenter;
            btnSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 20, FontStyle.Bold);
            btnSkill.BackColor = Color.FromArgb(_skill.colorFondo);
            btnSkill.ForeColor = Color.FromArgb(_skill.colorTexto);
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

            missatge = SkillsOrm.Update(_skill, txtNameSkill.Text, true,txtBcolor.BackColor.ToArgb(),txtTcolor.BackColor.ToArgb());

            if (missatge != "")
            {
                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Datos actualizados");
            }

        }
    }
}
