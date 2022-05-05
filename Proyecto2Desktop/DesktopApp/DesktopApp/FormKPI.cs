using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            bindingSourceKPI.DataSource = Models.KpisOrm.Select(false, this.skillId);
            lblKPIName.Text = this.skill.nom;
            setActiveCheck();
        }
        //Mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);
        private void pnBarra_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lbTitulo_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pcIcono_MouseDown(object sender, MouseEventArgs e)//Para poder mover la ventana des de la TitleBar
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }//
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
            setActiveCheck();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.updatedItems.Count == 0)
            {
                MessageBox.Show("No se ha hecho ningun cambio");                
            }
            else 
            {

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
                        KpisOrm.Update(KpisOrm.SelectSingleId(newkpi.id), newkpi.nom, newkpi.skills_id, newkpi.actiu);// update
                    }
                    else
                    {
                        missatge = KpisOrm.Insert(newkpi);
                    }
                }
                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(this.updatedItems.Count + " KPI's actualizados");
                    this.updatedItems.Clear();
                }
            }



            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("updateditems count" + this.updatedItems.Count);
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

            
            editedKpi.actiu = (bool)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
            Console.WriteLine(editedKpi.nom,editedKpi.id,editedKpi.skills_id,editedKpi.actiu);
            this.updatedItems.Add(editedKpi);
        }
        private void setActiveCheck()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Models.kpis uae = (Models.kpis)row.DataBoundItem;
                row.Cells[6].Value = uae.actiu;
            }
        }
        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pb_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
} 