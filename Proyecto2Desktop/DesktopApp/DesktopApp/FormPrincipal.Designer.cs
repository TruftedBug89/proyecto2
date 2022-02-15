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
            this.btnGestionKPI = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.flpListSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnManagmentSkills = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.flpListSkills.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1751, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnCloseSesion
            // 
            this.btnCloseSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSesion.BackColor = System.Drawing.Color.Tomato;
            this.btnCloseSesion.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCloseSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSesion.Location = new System.Drawing.Point(1491, 11);
            this.btnCloseSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(223, 43);
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
            this.btnManagmentListSkills.Location = new System.Drawing.Point(16, 10);
            this.btnManagmentListSkills.Margin = new System.Windows.Forms.Padding(16, 10, 4, 4);
            this.btnManagmentListSkills.Name = "btnManagmentListSkills";
            this.btnManagmentListSkills.Size = new System.Drawing.Size(147, 66);
            this.btnManagmentListSkills.TabIndex = 3;
            this.btnManagmentListSkills.Text = "Gestion Lista de Skils";
            this.btnManagmentListSkills.UseVisualStyleBackColor = false;
            this.btnManagmentListSkills.Click += new System.EventHandler(this.btnManagmentListSkills_Click);
            // 
            // btnGestionKPI
            // 
            this.btnGestionKPI.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnGestionKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionKPI.ForeColor = System.Drawing.Color.White;
            this.btnGestionKPI.Location = new System.Drawing.Point(74, 55);
            this.btnGestionKPI.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionKPI.Name = "btnGestionKPI";
            this.btnGestionKPI.Size = new System.Drawing.Size(155, 59);
            this.btnGestionKPI.TabIndex = 5;
            this.btnGestionKPI.Text = "Gestion KPI";
            this.btnGestionKPI.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flpListSkills);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1751, 130);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.flowLayoutPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 825);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1751, 131);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGestionUsuarios);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(259, 629);
            this.panel6.TabIndex = 13;
            // 
            // btnGestionUsuarios
            // 
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(49, 267);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(133, 81);
            this.btnGestionUsuarios.TabIndex = 7;
            this.btnGestionUsuarios.Text = "Gestion Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnGestionKPI);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1491, 196);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(260, 629);
            this.panel7.TabIndex = 14;
            // 
            // dgvSkill
            // 
            this.dgvSkill.ColumnHeadersHeight = 29;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkill.Location = new System.Drawing.Point(259, 196);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.RowHeadersWidth = 51;
            this.dgvSkill.Size = new System.Drawing.Size(1232, 629);
            this.dgvSkill.TabIndex = 16;
            // 
            // flpListSkills
            // 
            this.flpListSkills.AutoScroll = true;
            this.flpListSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpListSkills.Controls.Add(this.btnManagmentListSkills);
            this.flpListSkills.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpListSkills.Location = new System.Drawing.Point(0, 0);
            this.flpListSkills.Name = "flpListSkills";
            this.flpListSkills.Size = new System.Drawing.Size(1751, 105);
            this.flpListSkills.TabIndex = 22;
            this.flpListSkills.WrapContents = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel1.Controls.Add(this.btnManagmentSkills);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1751, 105);
            this.flowLayoutPanel1.TabIndex = 23;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnManagmentSkills
            // 
            this.btnManagmentSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagmentSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagmentSkills.Location = new System.Drawing.Point(16, 10);
            this.btnManagmentSkills.Margin = new System.Windows.Forms.Padding(16, 10, 4, 4);
            this.btnManagmentSkills.Name = "btnManagmentSkills";
            this.btnManagmentSkills.Size = new System.Drawing.Size(147, 66);
            this.btnManagmentSkills.TabIndex = 5;
            this.btnManagmentSkills.Text = "Gestion Skills";
            this.btnManagmentSkills.UseVisualStyleBackColor = false;
            this.btnManagmentSkills.Click += new System.EventHandler(this.btnManagmentSkills_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1751, 956);
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
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.flpListSkills.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseSesion;
        private System.Windows.Forms.Button btnManagmentListSkills;
        private System.Windows.Forms.Button btnGestionKPI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.FlowLayoutPanel flpListSkills;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnManagmentSkills;
    }
}