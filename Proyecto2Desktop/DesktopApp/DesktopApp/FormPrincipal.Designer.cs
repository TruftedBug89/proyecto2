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
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 82);
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
            this.btnCloseSesion.Location = new System.Drawing.Point(1585, 15);
            this.btnCloseSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(223, 42);
            this.btnCloseSesion.TabIndex = 0;
            this.btnCloseSesion.Text = "Cerrar Sesión";
            this.btnCloseSesion.UseVisualStyleBackColor = false;
            this.btnCloseSesion.Click += new System.EventHandler(this.btnCloseSesion_Click);
            // 
            // btnManagmentListSkills
            // 
            this.btnManagmentListSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagmentListSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentListSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentListSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagmentListSkills.Location = new System.Drawing.Point(16, 10);
            this.btnManagmentListSkills.Margin = new System.Windows.Forms.Padding(16, 10, 4, 4);
            this.btnManagmentListSkills.Name = "btnManagmentListSkills";
            this.btnManagmentListSkills.Size = new System.Drawing.Size(147, 66);
            this.btnManagmentListSkills.TabIndex = 3;
            this.btnManagmentListSkills.Text = "Gestión Lista de Skils";
            this.btnManagmentListSkills.UseVisualStyleBackColor = false;
            this.btnManagmentListSkills.Click += new System.EventHandler(this.btnManagmentListSkills_Click);
            // 
            // btnManagmentKPI
            // 
            this.btnManagmentKPI.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManagmentKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentKPI.ForeColor = System.Drawing.Color.White;
            this.btnManagmentKPI.Location = new System.Drawing.Point(66, 348);
            this.btnManagmentKPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManagmentKPI.Name = "btnManagmentKPI";
            this.btnManagmentKPI.Size = new System.Drawing.Size(174, 74);
            this.btnManagmentKPI.TabIndex = 5;
            this.btnManagmentKPI.Text = "Gestión KPI";
            this.btnManagmentKPI.UseVisualStyleBackColor = false;
            this.btnManagmentKPI.Visible = false;
            this.btnManagmentKPI.Click += new System.EventHandler(this.btnManagmentKPI_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flpListSkills);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 82);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1924, 130);
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
            this.flpListSkills.Size = new System.Drawing.Size(1924, 105);
            this.flpListSkills.TabIndex = 22;
            this.flpListSkills.WrapContents = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flpSkills);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 893);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1924, 162);
            this.panel5.TabIndex = 10;
            // 
            // flpSkills
            // 
            this.flpSkills.AutoScroll = true;
            this.flpSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpSkills.Controls.Add(this.btnManagmentSkills);
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSkills.Location = new System.Drawing.Point(0, 12);
            this.flpSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(1924, 150);
            this.flpSkills.TabIndex = 23;
            this.flpSkills.WrapContents = false;
            // 
            // btnManagmentSkills
            // 
            this.btnManagmentSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagmentSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagmentSkills.Location = new System.Drawing.Point(16, 20);
            this.btnManagmentSkills.Margin = new System.Windows.Forms.Padding(16, 20, 4, 4);
            this.btnManagmentSkills.Name = "btnManagmentSkills";
            this.btnManagmentSkills.Size = new System.Drawing.Size(147, 88);
            this.btnManagmentSkills.TabIndex = 5;
            this.btnManagmentSkills.Text = "Gestion Skills";
            this.btnManagmentSkills.UseVisualStyleBackColor = false;
            this.btnManagmentSkills.Click += new System.EventHandler(this.btnManagmentSkills_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGestionUsuarios);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 212);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(259, 681);
            this.panel6.TabIndex = 13;
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(55, 334);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(150, 101);
            this.btnGestionUsuarios.TabIndex = 7;
            this.btnGestionUsuarios.Text = "Gestión Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnManagmentKPI);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1664, 212);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 681);
            this.panel7.TabIndex = 14;
            // 
            // dgvSkill
            // 
            this.dgvSkill.AllowUserToAddRows = false;
            this.dgvSkill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkill.Location = new System.Drawing.Point(259, 212);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.ReadOnly = true;
            this.dgvSkill.RowHeadersWidth = 51;
            this.dgvSkill.Size = new System.Drawing.Size(1405, 681);
            this.dgvSkill.TabIndex = 16;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}
