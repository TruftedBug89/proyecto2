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
            btnListSkill.BackColor = Color.DarkGray;
            btnListSkill.Size = new Size(130, 55);
            btnListSkill.FlatAppearance.CheckedBackColor = Color.Blue;
            btnListSkill.Margin = new Padding(24,8,4,4);
            flpListSkills.Controls.Add(btnListSkill);

           
            btnListSkill.Click += (sender2, e2) => EliminarBoton_Click(sender2, e2, btnListSkill);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void EliminarBoton_Click(object sender, EventArgs e, RadioButton btnListSkill)         
        {
            flpListSkills.Controls.Remove(btnListSkill);
        }

    }
}
