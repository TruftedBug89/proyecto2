namespace DesktopApp
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGestionListaSkills = new System.Windows.Forms.Button();
            this.btnGestionSkill = new System.Windows.Forms.Button();
            this.pbTabletEmulator = new System.Windows.Forms.PictureBox();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.btnGestionKPI = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabletEmulator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCerrarSesión);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1313, 54);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.BackColor = System.Drawing.Color.Tomato;
            this.btnCerrarSesión.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Location = new System.Drawing.Point(1118, 9);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(167, 35);
            this.btnCerrarSesión.TabIndex = 0;
            this.btnCerrarSesión.Text = "Cerar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnGestionListaSkills);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1313, 89);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnGestionSkill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 688);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1313, 89);
            this.panel3.TabIndex = 2;
            // 
            // btnGestionListaSkills
            // 
            this.btnGestionListaSkills.Location = new System.Drawing.Point(26, 21);
            this.btnGestionListaSkills.Name = "btnGestionListaSkills";
            this.btnGestionListaSkills.Size = new System.Drawing.Size(128, 48);
            this.btnGestionListaSkills.TabIndex = 3;
            this.btnGestionListaSkills.Text = "Gestion Lista de Skils";
            this.btnGestionListaSkills.UseVisualStyleBackColor = true;
            // 
            // btnGestionSkill
            // 
            this.btnGestionSkill.Location = new System.Drawing.Point(26, 20);
            this.btnGestionSkill.Name = "btnGestionSkill";
            this.btnGestionSkill.Size = new System.Drawing.Size(128, 48);
            this.btnGestionSkill.TabIndex = 4;
            this.btnGestionSkill.Text = "Gestion Skils";
            this.btnGestionSkill.UseVisualStyleBackColor = true;
            // 
            // pbTabletEmulator
            // 
            this.pbTabletEmulator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTabletEmulator.BackgroundImage")));
            this.pbTabletEmulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTabletEmulator.Location = new System.Drawing.Point(142, 163);
            this.pbTabletEmulator.Name = "pbTabletEmulator";
            this.pbTabletEmulator.Size = new System.Drawing.Size(987, 503);
            this.pbTabletEmulator.TabIndex = 3;
            this.pbTabletEmulator.TabStop = false;
            // 
            // dgvSkill
            // 
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Location = new System.Drawing.Point(186, 199);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.Size = new System.Drawing.Size(902, 427);
            this.dgvSkill.TabIndex = 4;
            // 
            // btnGestionKPI
            // 
            this.btnGestionKPI.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGestionKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionKPI.ForeColor = System.Drawing.Color.White;
            this.btnGestionKPI.Location = new System.Drawing.Point(1169, 224);
            this.btnGestionKPI.Name = "btnGestionKPI";
            this.btnGestionKPI.Size = new System.Drawing.Size(116, 48);
            this.btnGestionKPI.TabIndex = 5;
            this.btnGestionKPI.Text = "Gestion KPI";
            this.btnGestionKPI.UseVisualStyleBackColor = false;
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(26, 368);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(100, 66);
            this.btnGestionUsuarios.TabIndex = 6;
            this.btnGestionUsuarios.Text = "Gestion Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1313, 777);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Controls.Add(this.btnGestionKPI);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.pbTabletEmulator);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTabletEmulator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGestionListaSkills;
        private System.Windows.Forms.Button btnGestionSkill;
        private System.Windows.Forms.PictureBox pbTabletEmulator;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.Button btnGestionKPI;
        private System.Windows.Forms.Button btnGestionUsuarios;
    }
}