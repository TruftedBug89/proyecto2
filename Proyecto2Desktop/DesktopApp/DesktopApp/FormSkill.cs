using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Models;

namespace DesktopApp
{
    public partial class FormSkill : Form
    {
        private skills _skill;
        private List<skills> _skills;
        private llistes_skills _llistaS;

        public FormSkill()
        {
            InitializeComponent();
        }

        public FormSkill(llistes_skills _llistaS)
        {
            InitializeComponent();
            this._llistaS = _llistaS;
        }


        private void FormSkill_Load(object sender, EventArgs e)
        {
            lblNameListSkills.Text = _llistaS.nom;
            _skills = SkillsOrm.SelectIdLlista(_llistaS.id);

            foreach (skills skill in _skills)
            {
                CrearBotonSkills(skill);
            }
            
        }

        private void SeleccionarSkill_Click(object sender, EventArgs e, RadioButton btnSkill, skills S)
        {
            _skill = S;

            if (_skill != null)
            {
                txtNameSkill.Text = _skill.nom;
                char[] letras = _skill.nom.ToCharArray();
                txtWordSkill.Text = letras[0].ToString();
                cboActivate.Checked = _skill.actiu;
                txtBcolor.BackColor = Color.FromArgb(_skill.colorFondo);
                txtTcolor.BackColor = Color.FromArgb(_skill.colorTexto);
            }
            else
            {
                vaciarCampos();
            }

            
           
        }


        private void CrearBotonSkills(skills _skill)
        {
            RadioButton btnSkill = new RadioButton();
            btnSkill.Appearance = Appearance.Button;

            if (_skill == null) 
            {
                btnSkill.Text = "";
                btnSkill.BackColor = Color.Black;
                btnSkill.ForeColor = Color.White;
            }
            else
            {
                char[] letra = _skill.nom.ToCharArray();
                btnSkill.Text = letra[0].ToString();
                btnSkill.BackColor = Color.FromArgb(_skill.colorFondo);
                btnSkill.ForeColor = Color.FromArgb(_skill.colorTexto);
            }

            String nombre = btnSkill.Text;
            btnSkill.FlatStyle = FlatStyle.Flat;
            btnSkill.FlatAppearance.BorderSize = 0;
            btnSkill.TextAlign = ContentAlignment.MiddleCenter;
            btnSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 30, FontStyle.Bold);
            btnSkill.Size = new Size(85, 75);
            btnSkill.FlatAppearance.CheckedBackColor = Color.Blue;
            btnSkill.Margin = new Padding(120, 15, 4, 4);
            flpSkills.Controls.Add(btnSkill);

            btnSkill.Click += (sender2, e2) => SeleccionarSkill_Click(sender2, e2, btnSkill, _skill);
        }



        private void btnBColor_Click(object sender, EventArgs e)
        {
            cdBackgroundColor.ShowDialog();
            Color color = cdBackgroundColor.Color;            
            txtBcolor.BackColor = color;
        }

        private void btnTColor_Click(object sender, EventArgs e)
        {
            cdTextColor.ShowDialog();
            Color color = cdTextColor.Color;
            txtTcolor.BackColor = color;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_skill != null)
            {
                char[] letrasS = txtNameSkill.Text.ToCharArray();

                //remplazar la primera letra en caso de repeticion de caracteres
                var regex = new Regex(Regex.Escape(letrasS[0].ToString()));
                String nombreSkill = regex.Replace(txtNameSkill.Text, letrasS[0].ToString().ToUpper(), 1);

                missatge = SkillsOrm.Update(_skill, nombreSkill, cboActivate.Checked, txtBcolor.BackColor.ToArgb(), txtTcolor.BackColor.ToArgb());

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Skill Actualizada");
                    ActualizarPanelSkills();
                    ActualizarNombreListaSkills(missatge);
                }
            }
            else
            {
                skills S = new skills();
                char[] letrasS = txtNameSkill.Text.ToCharArray(); 
                var regex = new Regex(Regex.Escape(letrasS[0].ToString()));
                String nombreSkill = regex.Replace(txtNameSkill.Text, letrasS[0].ToString().ToUpper(), 1);

                S.nom = nombreSkill;
                S.llistes_skills_id = _llistaS.id;
                S.actiu = cboActivate.Checked;
                S.colorFondo = txtBcolor.BackColor.ToArgb();
                S.colorTexto = txtTcolor.BackColor.ToArgb();

                missatge = SkillsOrm.Insert(S);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    char[] letras = _llistaS.nom.ToCharArray();
                    char[] letraSnueva = S.nom.ToCharArray();
                    String nuevoNombre = _llistaS.nom.Insert(_llistaS.nom.Length, letraSnueva[0].ToString().ToUpper());
                    
                    missatge = Llistes_SkillsOrm.UpdateName(_llistaS, nuevoNombre.ToUpper());

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Skill añadida");
                        ActualizarPanelSkills();
                        ActualizarNombreListaSkills(missatge);

                    }


                }


            }

            

        }


        private void ActualizarPanelSkills()
        {
            //Elimino todos los Controles menos el primero
            while (flpSkills.Controls.Count > 1)
            {
                flpSkills.Controls.RemoveAt(1);
            }

            List<skills> _Skills = SkillsOrm.SelectIdLlista(_llistaS.id);

            foreach (skills S in _Skills)
            {
                CrearBotonSkills(S);
            }
        }

        private void ActualizarNombreListaSkills(String msg) 
        {
            List<skills> _Skills = SkillsOrm.SelectIdLlista(_llistaS.id);
            char[] letras = new char[_Skills.Count()];
            int i = 0;
            foreach (skills S in _Skills)
            {
                char[] letra = S.nom.ToCharArray();
                letras[i] = letra[0];
                i++;
            }

            String nuevoNombreLista = new string(letras);
            lblNameListSkills.Text = nuevoNombreLista;
            msg = Llistes_SkillsOrm.UpdateName(_llistaS, nuevoNombreLista.ToUpper());

            if (msg != "")
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            _skill = null;

            CrearBotonSkills(_skill);
            vaciarCampos();

        }

        public void vaciarCampos() 
        {
            txtNameSkill.Text = "";
            txtWordSkill.Text = "";
            cboActivate.Checked = false;
            txtBcolor.BackColor = Color.White;
            txtTcolor.BackColor = Color.White;
        }

        private void txtNameSkill_TextChanged(object sender, EventArgs e)
        {
            if (!txtNameSkill.Text.Equals("")) {

                char[] letras = txtNameSkill.Text.ToCharArray();

                txtWordSkill.Text = letras[0].ToString().ToUpper();
            }
        }
    }
}
