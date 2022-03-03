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
    public partial class FormGestionUsuarios : Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();
            bindingSource1.DataSource = Models.UsuarisOrm.Select();

        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            FormGestionGrupo gr = new FormGestionGrupo("");
            gr.ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FormGestionPerfil gr = new FormGestionPerfil();
            gr.ShowDialog();
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            FormCrearUsuarios fcu = new FormCrearUsuarios();
            fcu.ShowDialog();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {

        }

        private void pbSearch_Click(object sender, EventArgs e)
        {

        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Models.UsuarisOrm.SelectByName(textBox1.Text);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 8)
            {
                Models.usuaris u = (Models.usuaris)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                e.Value = u.rols.nom;
                
            }
        }
    }
}
