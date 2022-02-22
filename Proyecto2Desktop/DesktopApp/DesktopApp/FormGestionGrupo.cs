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
    public partial class FormGestionGrupo : Form
    {
        private llistes_skills _llistaSkill;        
        private List<llistes_skills> _llistesSkills;
        private grups _grup;
        private List<grups> _grups;
        private usuaris _usuaris;
        private List<usuaris> _ListUsuaris;

        public FormGestionGrupo()
        {
            InitializeComponent();
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGestionGrupo_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
            cargarListasSkills();
            actualizarGrupos();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            usuaris _users = (usuaris)lbUsers.SelectedItem;

            MessageBox.Show(_users.nom);
        }



        private void cargarUsuarios()         
        {
            _ListUsuaris = UsuarisOrm.Select();

            foreach (usuaris us in _ListUsuaris)
            {
                lbUsers.Items.Add(us.nom);
            }

        }


        private void actualizarGrupos()
        {
            lbGroups.Items.Clear();

            _grups = GrupsOrm.Select();

            foreach (grups grp in _grups)
            {
                lbGroups.Items.Add(grp.nom);
            }

        }


        private void cargarListasSkills()
        {
            _llistesSkills = Llistes_SkillsOrm.Select();

            foreach (llistes_skills ls in _llistesSkills)
            {
                lbListSkills.Items.Add(ls.nom);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_grup != null)
            {
                //update
            }
            else
            {
                grups Grup = new grups();
                Grup.nom = txtNameGroup.Text;

                missatge = GrupsOrm.Insert(Grup);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Grupo añadido");
                }

            }

            actualizarGrupos();
        }

    }
}
