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
                txtNewKPI.Text = "";
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.updatedItems.Count == 0)
            {
                MessageBox.Show("No se ha hecho ningun cambio");
                return;
            }
            String missatge = "";



            List<int> old_ids = new List<int>();
            foreach (kpis kpi in this.skill.kpis)
            {
                old_ids.Add(kpi.id);
            }

            foreach (kpis newkpi in this.updatedItems)
            {
                if (old_ids.Contains(newkpi.id))
                {
                    KpisOrm.Update(KpisOrm.SelectSingleId(newkpi.id),newkpi.nom,newkpi.skills_id,newkpi.actiu);// update
                }
                else
                {
                    //MessageBox.Show(newkpi.ToString());
                    missatge = KpisOrm.Insert(newkpi);


                }


            }

            if (missatge != "")
            {
                MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this.updatedItems.Count+" KPI's actualizados");
                this.updatedItems.Clear();
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("updateditems count"+this.updatedItems.Count);
            if (this.updatedItems.Count != 0)
            {
                DialogResult dr = MessageBox.Show("Tienes elementos por guardar, estas segur@ que quieres cancelar", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else this.Close();
        }

        private void dataGridView1_UserDeletingRow_1(object sender, DataGridViewRowCancelEventArgs e)
        {
            kpis deletedKpi = (kpis)e.Row.DataBoundItem;
            deletedKpi.actiu = false;

            this.updatedItems.Add(deletedKpi);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            kpis editedKpi = (kpis)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            Console.WriteLine(editedKpi.nom);
            this.updatedItems.Add(editedKpi);
        }
    }
}
