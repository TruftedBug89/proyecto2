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
            RadioButton btnListSkill = new RadioButton();

            btnListSkill.Appearance = Appearance.Button;
            btnListSkill.Text = "Nueva Lista";
            String nombre = btnListSkill.Text;
            btnListSkill.FlatStyle = FlatStyle.Flat;
            btnListSkill.TextAlign = ContentAlignment.MiddleCenter; 
            btnListSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"),20,FontStyle.Bold);
            btnListSkill.BackColor = Color.Black;
            btnListSkill.ForeColor = Color.White;
            btnListSkill.Size = new Size(180, 55);
            btnListSkill.FlatAppearance.CheckedBackColor = Color.Blue;
            btnListSkill.Margin = new Padding(24,8,4,4);
            flpListSkills.Controls.Add(btnListSkill);

           
            btnListSkill.Click += (sender2, e2) => SeleccionarLista_Click(sender2, e2, btnListSkill, nombre);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void SeleccionarLista_Click(object sender, EventArgs e, RadioButton btnListSkill, String nombre)         
        {
            MessageBox.Show(nombre);
        }

        private void FormListaSkills_Load(object sender, EventArgs e)
        {
            //RadioButton btnListSkill = new RadioButton();
            //btnListSkill.Appearance = Appearance.Button;
            //btnListSkill.Text = "Nueva Lista";
            //btnListSkill.FlatStyle = FlatStyle.Flat;
            //btnListSkill.TextAlign = ContentAlignment.MiddleCenter;
            //btnListSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 20, FontStyle.Bold);
            //btnListSkill.BackColor = Color.Black;
            //btnListSkill.ForeColor = Color.White;
            //btnListSkill.Size = new Size(180, 55);
            //btnListSkill.FlatAppearance.CheckedBackColor = Color.Blue;
            //btnListSkill.Margin = new Padding(24, 8, 4, 4);
            //flpListSkills.Controls.Add(btnListSkill);

        }

        private void btnBuildTable_Click(object sender, EventArgs e)
        {

        }
    }
}
