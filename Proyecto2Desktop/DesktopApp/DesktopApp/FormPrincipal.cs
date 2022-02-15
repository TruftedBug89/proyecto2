using DesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class FormPrincipal : Form
    {
        private String NombreSkill;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            List<llistes_skills> _llistes_Skills = Llistes_SkillsOrm.Select();

            foreach (llistes_skills lSkills in _llistes_Skills)
            {
                CrearBotonListaSkill(lSkills);
            }
        }
                
        private void btnManagmentListSkills_Click(object sender, EventArgs e)
        {
           
            FormListaSkills formListaSkills = new FormListaSkills();
            formListaSkills.ShowDialog();
            ActualizarPanelListasSkills();
        }

       

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionarLista_Click(object sender, EventArgs e, RadioButton btnListSkill, String nombre)
        {
            NombreSkill = nombre;
            MessageBox.Show(NombreSkill);
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

        private void ActualizarPanelListasSkills() 
        {
            //flpListSkills.Controls.Clear();
            while (flpListSkills.Controls.Count > 1) 
            {
                flpListSkills.Controls.RemoveAt(1);
            }

            List<llistes_skills> _llistes_Skills = Llistes_SkillsOrm.Select();

            foreach (llistes_skills lSkills in _llistes_Skills)
            {
                CrearBotonListaSkill(lSkills);
            }
        }

        private void btnManagmentSkills_Click(object sender, EventArgs e)
        {
            FormSkill formSkill = new FormSkill();
            formSkill.ShowDialog();
        }
    }
}
