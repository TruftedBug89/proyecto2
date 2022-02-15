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
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
                
        private void btnManagmentListSkills_Click(object sender, EventArgs e)
        {
           
            FormListaSkills formListaSkills = new FormListaSkills();
            formListaSkills.ShowDialog();
        }

        private void btnManagmentSkill_Click(object sender, EventArgs e)
        {
            FormSkill formSkill = new FormSkill();
            formSkill.ShowDialog();
        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
