﻿using DesktopApp.Models;
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
        List<llistes_skills> _llistes_Skills;
        List<skills> _skills;
        private llistes_skills _llistesSkills;
        private skills _skill;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            _llistes_Skills = Llistes_SkillsOrm.SelectActivate();

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
            limpiarPanelSkills();
            _llistesSkills = null;
        }


        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SeleccionarLista_Click(object sender, EventArgs e, RadioButton btnListSkill, llistes_skills llistesS)
        {
            limpiarPanelSkills();
            dgvSkill.Columns.Clear();
            btnManagmentKPI.Visible = false;
            _llistesSkills = llistesS;

            _skills = SkillsOrm.SelectActivate(_llistesSkills.id);

            foreach (skills skill in _skills)
            {
                CrearBotonSkills(skill);
            }
        }

        private void SeleccionarSkill_Click(object sender, EventArgs e, RadioButton btnSkill, skills S)
        {
            _skill = S;
            btnManagmentKPI.Visible = true;
            dgvSkill.Columns.Clear();
            dgvSkill.DataSource = null;
            dgvSkill.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
            dgvSkill.Columns.Add(S.nom, S.nom);
            dgvSkill.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);

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

            btnListSkill.Click += (sender2, e2) => SeleccionarLista_Click(sender2, e2, btnListSkill, ls);

        }


        private void CrearBotonSkills(skills _skills)
        {
            RadioButton btnSkill = new RadioButton();
            btnSkill.Appearance = Appearance.Button;
            char[] letra = _skills.nom.ToCharArray();
            btnSkill.Text = letra[0].ToString();
            String nombre = btnSkill.Text;
            btnSkill.FlatStyle = FlatStyle.Flat;
            btnSkill.FlatAppearance.BorderSize = 0;
            btnSkill.TextAlign = ContentAlignment.MiddleCenter;
            btnSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 30, FontStyle.Bold);
            btnSkill.BackColor = Color.FromArgb(_skills.colorFondo);
            btnSkill.ForeColor = Color.FromArgb(_skills.colorTexto);
            btnSkill.Size = new Size(85, 75);
            btnSkill.FlatAppearance.CheckedBackColor = Color.FromArgb(100, Color.FromArgb(_skills.colorFondo));
            btnSkill.Margin = new Padding(120, 15, 4, 4);
            flpSkills.Controls.Add(btnSkill);

            btnSkill.Click += (sender2, e2) => SeleccionarSkill_Click(sender2, e2, btnSkill, _skills);
        }


        private void ActualizarPanelListasSkills()
        {
           //Elimino todos los Controles menos el primero
            while (flpListSkills.Controls.Count > 1)
            {
                flpListSkills.Controls.RemoveAt(1);
            }

            List<llistes_skills> _llistes_Skills = Llistes_SkillsOrm.SelectActivate();

            foreach (llistes_skills lSkills in _llistes_Skills)
            {
                CrearBotonListaSkill(lSkills);
            }
        }


        private void limpiarPanelSkills()
        {
            //Elimino todos los Controles menos el primero
            while (flpSkills.Controls.Count > 1)
            {
                flpSkills.Controls.RemoveAt(1);
            }
        }


        private void btnManagmentSkills_Click(object sender, EventArgs e)
        {
            if (_llistesSkills != null)
            {
                FormSkill formSkill = new FormSkill(_llistesSkills);
                formSkill.ShowDialog();
                ActualizarPanelListasSkills();
                limpiarPanelSkills();
            }
            else
            {
                MessageBox.Show("Selecciona una lista de Skills");
            }
          }

        private void btnManagmentKPI_Click(object sender, EventArgs e)
        {
            FormKPI FormKPI = new FormKPI(_skill);
            FormKPI.ShowDialog();
        }
    }
}
