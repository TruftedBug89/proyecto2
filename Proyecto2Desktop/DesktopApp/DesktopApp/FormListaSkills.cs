using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApp.Models;

namespace DesktopApp
{
    public partial class FormListaSkills : Form
    {       
        private llistes_skills _llistesSkills;
        private List<llistes_skills> _llistesS;
        private String FormGruposSkills;

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
            _llistesSkills = null;
            dgvListaSkills.Columns.Clear();
            dgvListaSkills.DataSource = null;

            CrearBotonListaSkill(_llistesSkills);
        }


        private void SeleccionarLista_Click(object sender, EventArgs e, RadioButton btnListSkill, llistes_skills llistesS)         
        {
  
            _llistesSkills = llistesS;

            if (_llistesSkills != null) 
            {
                txtNameListSkill.Text = _llistesSkills.nom;
                cboActivate.Checked = llistesS.actiu;

                if (_llistesSkills.skills.Count() != 0 || _llistesSkills.skills != null)
                {
                    
                    ConstruirEncabezadosTabla();
                    
                    foreach (skills skill in _llistesSkills.skills)
                    {                       
                        char[] letras = skill.nom.ToCharArray();
                        dgvListaSkills.Rows.Add(letras[0], skill.nom);
                        
                    }
                }
                else
                {
                    
                    dgvListaSkills.Columns.Clear();

                }
            }
            else
            {
                txtNameListSkill.Text = "";
                dgvListaSkills.Columns.Clear();
            }

            
        }

        private void FormListaSkills_Load(object sender, EventArgs e)
        {
            _llistesS = Llistes_SkillsOrm.Select();

            if (_llistesS.Count() >= 1)            
            {
                foreach (llistes_skills lSkills in _llistesS)
                {
                    CrearBotonListaSkill(lSkills);
                }
            }


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            String missatge = "";

            if (_llistesSkills != null)
            {
                _llistesSkills.actiu = cboActivate.Checked;
                
                missatge = Llistes_SkillsOrm.Update(_llistesSkills,txtNameListSkill.Text.ToUpper(), _llistesSkills.actiu);

                if (missatge != "")
                {
                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Datos actualizados");
                    //if (dgvListaSkills.Columns.Count != 0)
                    //{
                    //    MessageBox.Show("Test");
                    //}
                    ActualizarPanelListaSkills();
                }
                               
            }
            else
            {
                if (!txtNameListSkill.Text.Equals(""))
                {
                    llistes_skills _llistes_Skills = new llistes_skills();
                    _llistes_Skills.nom = txtNameListSkill.Text.ToUpper();
                    _llistes_Skills.skills = null;
                    _llistes_Skills.actiu = cboActivate.Checked;

                    missatge = Llistes_SkillsOrm.Insert(_llistes_Skills);

                    if (missatge != "")
                    {
                        MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (dgvListaSkills.Columns.Count >= 1)
                        {

                            foreach (DataGridViewRow row in dgvListaSkills.Rows)
                            {

                                skills _skill = new skills();
                                char[] letrasS = row.Cells["Skill"].Value.ToString().ToCharArray();
                                var regex = new Regex(Regex.Escape(letrasS[0].ToString()));

                                if (!row.Cells["Skill"].Value.Equals(""))
                                {
                                    String nombreSkill = regex.Replace(row.Cells["Skill"].Value.ToString(), letrasS[0].ToString().ToUpper(), 1);
                                    _skill.nom = nombreSkill;
                                }
                                else
                                {
                                    _skill.nom = row.Cells[0].Value.ToString().ToUpper();
                                }

                                _skill.llistes_skills_id = _llistes_Skills.id;
                                _skill.actiu = true;
                                _skill.colorFondo = Color.Black.ToArgb();
                                _skill.colorTexto = Color.White.ToArgb();

                                missatge = SkillsOrm.Insert(_skill);

                                if (missatge != "")
                                {
                                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }

                        }
                        else
                        {

                            char[] letras = txtNameListSkill.Text.ToCharArray();

                            for (int i = 0; i < letras.Length; i++)
                            {
                                skills _skill = new skills();
                                _skill.llistes_skills_id = _llistes_Skills.id;
                                _skill.nom = letras[i].ToString().ToUpper();
                                _skill.actiu = false;
                                _skill.colorFondo = Color.Black.ToArgb();
                                _skill.colorTexto = Color.White.ToArgb();

                                missatge = SkillsOrm.Insert(_skill);

                                if (missatge != "")
                                {
                                    MessageBox.Show(missatge, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }


                        }

                        MessageBox.Show("Lista de skills añadida");
                        ActualizarPanelListaSkills();
                    }
                }
                else
                {
                    MessageBox.Show("Listas vacias");
                }


               

            }


        }

        private void ActualizarPanelListaSkills()
        {
            //Elimino todos los Controles menos el primero
            while (flpListSkills.Controls.Count > 1)
            {
                flpListSkills.Controls.RemoveAt(1);
            }

            List<llistes_skills> _llistesSkills = Llistes_SkillsOrm.Select();

            foreach (llistes_skills LS in _llistesSkills)
            {
                CrearBotonListaSkill(LS);
            }
        }


        private void CrearBotonListaSkill(llistes_skills ls)         
        {
            
            RadioButton btnListSkill = new RadioButton();
            btnListSkill.Appearance = Appearance.Button;
            if (ls == null)
            {
                btnListSkill.Text = "Nueva Lista";                
                txtNameListSkill.Text = "";
                dgvListaSkills.Columns.Clear();
            }
            else 
            {
                btnListSkill.Text = ls.nom;
            }
            
            String nombre = btnListSkill.Text;
            btnListSkill.FlatStyle = FlatStyle.Flat;
            btnListSkill.TextAlign = ContentAlignment.MiddleCenter;
            btnListSkill.Font = new Font(new FontFamily("Microsoft Sans Serif"), 20, FontStyle.Bold);
            btnListSkill.BackColor = Color.Black;
            btnListSkill.ForeColor = Color.White;
            btnListSkill.Size = new Size(200, 55);
            btnListSkill.FlatAppearance.CheckedBackColor = Color.Blue;
            btnListSkill.Margin = new Padding(24, 8, 4, 4);
            flpListSkills.Controls.Add(btnListSkill);


            btnListSkill.Click += (sender2, e2) => SeleccionarLista_Click(sender2, e2, btnListSkill, ls);

        }

        private void ConstruirEncabezadosTabla() 
        {
            dgvListaSkills.Columns.Clear();
            dgvListaSkills.DataSource = null;
            dgvListaSkills.Columns.Add("Letra", "Letra");
            dgvListaSkills.Columns.Add("Skill", "Skill");

            String[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor)); 

            DataGridViewComboBoxColumn cbxCellBackgroundColorSkill = new DataGridViewComboBoxColumn();
            cbxCellBackgroundColorSkill.Name = "btnBackColor";
            cbxCellBackgroundColorSkill.HeaderText = "Color de fondo de la skill";
            cbxCellBackgroundColorSkill.DataSource = colores;

            dgvListaSkills.Columns.Add(cbxCellBackgroundColorSkill);

            DataGridViewComboBoxColumn cbxCellColorSkill = new DataGridViewComboBoxColumn();          
            cbxCellColorSkill.Name = "btnTextColumn";
            cbxCellColorSkill.HeaderText = "Color de texto de la skill";
            cbxCellColorSkill.DataSource = colores;

            dgvListaSkills.Columns.Add(cbxCellColorSkill);




            //dgvListaSkills.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
        }

      

        private void btnManagmentGroups_Click(object sender, EventArgs e)
        {
            FormGruposSkills = "GuposListasSkills";
            FormRelacionesGrupo formRelacionesGrupo = new FormRelacionesGrupo(FormGruposSkills);
            formRelacionesGrupo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGruposSkills = "";
            FormRelacionesGrupo formRelacionesGrupo = new FormRelacionesGrupo(FormGruposSkills);
            formRelacionesGrupo.ShowDialog();
        }

        private void btnBuildTable_Click(object sender, EventArgs e)
        {
            ConstruirEncabezadosTabla();

            Char[] letras = txtNameListSkill.Text.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                dgvListaSkills.Rows.Add(letras[i].ToString().ToUpper(), "");
            }
        }
    }
}
