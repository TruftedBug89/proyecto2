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
    public partial class FormKPI : Form
    {
        private Models.skills skill;
        private int skillId;
        private List<Models.kpis> updatedItems;
        public FormKPI(Models.skills skill)
        {
            this.updatedItems = new List<Models.kpis>();
            this.skillId = skill.id;
            this.skill = skill;
            InitializeComponent();
        }

        private void FormKPI_Load(object sender, EventArgs e)
        {
            bindingSourceKPI.DataSource = Models.KpisOrm.Select(true, this.skillId);
            lblKPIName.Text = this.skill.nom;
        }

        private void btnAddKpi_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtNewKPI.Text))
            {
                MessageBox.Show("Introduce una descripción para el nuevo SubSkill", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Models.kpis _kpi = new Models.kpis();
                _kpi.nom = txtNewKPI.Text;
                _kpi.skills_id = this.skillId;
                _kpi.actiu = true;
                this.updatedItems.Add(_kpi);
                bindingSourceKPI.Add(_kpi);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";



            List<int> old_ids = new List<int>();
            foreach (kpis kpi in this.skill.kpis)
            {
                old_ids.Add(kpi.id);
            }

            foreach (kpis newkpi in this.updatedItems)
            {
                MessageBox.Show(newkpi.id.ToString());
                //if (old_ids.Contains(newkpi.id))
                //{
                //   // update
                //}
                //else
                //{
                //    missatge = KpisOrm.Insert(newkpi);


                //}

            }

            if (missatge != "")
            {
                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("KPI Añadida");
            }

        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            DataRowVersion.

        }
    }
}
