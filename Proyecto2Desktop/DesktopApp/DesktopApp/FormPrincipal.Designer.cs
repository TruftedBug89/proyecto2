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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseSesion = new System.Windows.Forms.Button();
            this.btnManagmentListSkills = new System.Windows.Forms.Button();
            this.btnManagmentKPI = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flpListSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnManagmentSkills = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnManagmentRoles = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.btnManagmentCourses = new System.Windows.Forms.Button();
            this.btnManagmentGroups = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flpListSkills.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flpSkills.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCloseSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseSesion
            // 
            this.btnCloseSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSesion.BackColor = System.Drawing.Color.Tomato;
            this.btnCloseSesion.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCloseSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSesion.ForeColor = System.Drawing.Color.White;
            this.btnCloseSesion.Location = new System.Drawing.Point(1409, 12);
            this.btnCloseSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(198, 34);
            this.btnCloseSesion.TabIndex = 0;
            this.btnCloseSesion.Text = "Cerar Sesión";
            this.btnCloseSesion.UseVisualStyleBackColor = false;
            this.btnCloseSesion.Click += new System.EventHandler(this.btnCloseSesion_Click);
            // 
            // btnManagmentListSkills
            // 
            this.btnManagmentListSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagmentListSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentListSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentListSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagmentListSkills.Location = new System.Drawing.Point(14, 11);
            this.btnManagmentListSkills.Margin = new System.Windows.Forms.Padding(14, 11, 4, 3);
            this.btnManagmentListSkills.Name = "btnManagmentListSkills";
            this.btnManagmentListSkills.Size = new System.Drawing.Size(249, 67);
            this.btnManagmentListSkills.TabIndex = 3;
            this.btnManagmentListSkills.Text = "Gestion Lista de Skils";
            this.btnManagmentListSkills.UseVisualStyleBackColor = false;
            this.btnManagmentListSkills.Click += new System.EventHandler(this.btnManagmentListSkills_Click);
            // 
            // btnManagmentKPI
            // 
            this.btnManagmentKPI.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManagmentKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentKPI.ForeColor = System.Drawing.Color.White;
            this.btnManagmentKPI.Location = new System.Drawing.Point(59, 278);
            this.btnManagmentKPI.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagmentKPI.Name = "btnManagmentKPI";
            this.btnManagmentKPI.Size = new System.Drawing.Size(155, 59);
            this.btnManagmentKPI.TabIndex = 5;
            this.btnManagmentKPI.Text = "Gestion KPI";
            this.btnManagmentKPI.UseVisualStyleBackColor = false;
            this.btnManagmentKPI.Visible = false;
            this.btnManagmentKPI.Click += new System.EventHandler(this.btnManagmentKPI_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flpListSkills);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1710, 114);
            this.panel4.TabIndex = 7;
            // 
            // flpListSkills
            // 
            this.flpListSkills.AutoScroll = true;
            this.flpListSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpListSkills.Controls.Add(this.btnManagmentListSkills);
            this.flpListSkills.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpListSkills.Location = new System.Drawing.Point(0, 0);
            this.flpListSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpListSkills.Name = "flpListSkills";
            this.flpListSkills.Size = new System.Drawing.Size(1710, 109);
            this.flpListSkills.TabIndex = 22;
            this.flpListSkills.WrapContents = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flpSkills);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 714);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1710, 130);
            this.panel5.TabIndex = 10;
            // 
            // flpSkills
            // 
            this.flpSkills.AutoScroll = true;
            this.flpSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpSkills.Controls.Add(this.btnManagmentSkills);
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSkills.Location = new System.Drawing.Point(0, 10);
            this.flpSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(1710, 120);
            this.flpSkills.TabIndex = 23;
            this.flpSkills.WrapContents = false;
            // 
            // btnManagmentSkills
            // 
            this.btnManagmentSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagmentSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagmentSkills.Location = new System.Drawing.Point(14, 16);
            this.btnManagmentSkills.Margin = new System.Windows.Forms.Padding(14, 16, 4, 3);
            this.btnManagmentSkills.Name = "btnManagmentSkills";
            this.btnManagmentSkills.Size = new System.Drawing.Size(131, 70);
            this.btnManagmentSkills.TabIndex = 5;
            this.btnManagmentSkills.Text = "Gestion Skills";
            this.btnManagmentSkills.UseVisualStyleBackColor = false;
            this.btnManagmentSkills.Click += new System.EventHandler(this.btnManagmentSkills_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnManagmentGroups);
            this.panel6.Controls.Add(this.btnManagmentCourses);
            this.panel6.Controls.Add(this.btnManagmentRoles);
            this.panel6.Controls.Add(this.btnGestionUsuarios);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 180);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(230, 534);
            this.panel6.TabIndex = 13;
            // 
            // btnManagmentRoles
            // 
            this.btnManagmentRoles.BackColor = System.Drawing.Color.Black;
            this.btnManagmentRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentRoles.ForeColor = System.Drawing.Color.White;
            this.btnManagmentRoles.Location = new System.Drawing.Point(46, 171);
            this.btnManagmentRoles.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagmentRoles.Name = "btnManagmentRoles";
            this.btnManagmentRoles.Size = new System.Drawing.Size(133, 81);
            this.btnManagmentRoles.TabIndex = 8;
            this.btnManagmentRoles.Text = "Gestion Roles";
            this.btnManagmentRoles.UseVisualStyleBackColor = false;
            this.btnManagmentRoles.Click += new System.EventHandler(this.btnManagmentRoles_Click);
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(46, 45);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(133, 81);
            this.btnGestionUsuarios.TabIndex = 7;
            this.btnGestionUsuarios.Text = "Gestion Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnManagmentKPI);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1479, 180);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 534);
            this.panel7.TabIndex = 14;
            // 
            // dgvSkill
            // 
            this.dgvSkill.AllowUserToAddRows = false;
            this.dgvSkill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkill.Location = new System.Drawing.Point(230, 180);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.ReadOnly = true;
            this.dgvSkill.RowHeadersWidth = 51;
            this.dgvSkill.Size = new System.Drawing.Size(1249, 534);
            this.dgvSkill.TabIndex = 16;
            // 
            // btnManagmentCourses
            // 
            this.btnManagmentCourses.BackColor = System.Drawing.Color.Black;
            this.btnManagmentCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentCourses.ForeColor = System.Drawing.Color.White;
            this.btnManagmentCourses.Location = new System.Drawing.Point(46, 290);
            this.btnManagmentCourses.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagmentCourses.Name = "btnManagmentCourses";
            this.btnManagmentCourses.Size = new System.Drawing.Size(133, 81);
            this.btnManagmentCourses.TabIndex = 9;
            this.btnManagmentCourses.Text = "Gestion Cursos";
            this.btnManagmentCourses.UseVisualStyleBackColor = false;
            this.btnManagmentCourses.Click += new System.EventHandler(this.btnManagmentCourses_Click);
            // 
            // btnManagmentGroups
            // 
            this.btnManagmentGroups.BackColor = System.Drawing.Color.Black;
            this.btnManagmentGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentGroups.ForeColor = System.Drawing.Color.White;
            this.btnManagmentGroups.Location = new System.Drawing.Point(46, 406);
            this.btnManagmentGroups.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagmentGroups.Name = "btnManagmentGroups";
            this.btnManagmentGroups.Size = new System.Drawing.Size(133, 81);
            this.btnManagmentGroups.TabIndex = 10;
            this.btnManagmentGroups.Text = "Gestion Grupos";
            this.btnManagmentGroups.UseVisualStyleBackColor = false;
            this.btnManagmentGroups.Click += new System.EventHandler(this.btnManagmentGroups_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1710, 844);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.flpListSkills.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flpSkills.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseSesion;
        private System.Windows.Forms.Button btnManagmentListSkills;
        private System.Windows.Forms.Button btnManagmentKPI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.FlowLayoutPanel flpListSkills;
        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.Button btnManagmentSkills;
        private System.Windows.Forms.Button btnManagmentRoles;
        private System.Windows.Forms.Button btnManagmentGroups;
        private System.Windows.Forms.Button btnManagmentCourses;
    }
}
