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
    public partial class FormSkill : Form
    {

        public FormSkill()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            skills _skill = new skills();
            _skill.nom = txtSkillName.Text;
            _skill.colorTexto = cbxColors.SelectedIndex;
     //       _skill.colorFondo = cbxTextColors.SelectedItem;
        }

        private void txtSkillName_TextChanged(object sender, EventArgs e)
        {
            if (txtSkillName.TextLength >= 1)
            {
                String sTexto = txtSkillName.Text;
                txtInitialSkill.Text = sTexto.Substring(0, 1);
            }
            else {
                txtInitialSkill.Text = "";
            }
            
            
        }
    }
}