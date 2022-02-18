namespace DesktopApp
{
    partial class FormSkill
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
            this.lblNombreSkill = new System.Windows.Forms.Label();
            this.txtWordSkill = new System.Windows.Forms.TextBox();
            this.lblLetraSkill = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameSkill = new System.Windows.Forms.TextBox();
            this.cboActivate = new System.Windows.Forms.CheckBox();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.cdBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.btnBColor = new System.Windows.Forms.Button();
            this.txtBcolor = new System.Windows.Forms.TextBox();
            this.btnTColor = new System.Windows.Forms.Button();
            this.txtTcolor = new System.Windows.Forms.TextBox();
            this.cdTextColor = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNameListSkills = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.flpSkills.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreSkill
            // 
            this.lblNombreSkill.AutoSize = true;
            this.lblNombreSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSkill.Location = new System.Drawing.Point(72, 139);
            this.lblNombreSkill.Name = "lblNombreSkill";
            this.lblNombreSkill.Size = new System.Drawing.Size(135, 24);
            this.lblNombreSkill.TabIndex = 2;
            this.lblNombreSkill.Text = "Nombre Skill:";
            // 
            // txtWordSkill
            // 
            this.txtWordSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordSkill.Location = new System.Drawing.Point(225, 224);
            this.txtWordSkill.Name = "txtWordSkill";
            this.txtWordSkill.Size = new System.Drawing.Size(184, 158);
            this.txtWordSkill.TabIndex = 4;
            this.txtWordSkill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLetraSkill
            // 
            this.lblLetraSkill.AutoSize = true;
            this.lblLetraSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraSkill.Location = new System.Drawing.Point(101, 274);
            this.lblLetraSkill.Name = "lblLetraSkill";
            this.lblLetraSkill.Size = new System.Drawing.Size(106, 24);
            this.lblLetraSkill.TabIndex = 5;
            this.lblLetraSkill.Text = "Letra Skill:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 562);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 78);
            this.panel2.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(639, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(488, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(20, 20, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 92);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNameSkill
            // 
            this.txtNameSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSkill.Location = new System.Drawing.Point(225, 136);
            this.txtNameSkill.Name = "txtNameSkill";
            this.txtNameSkill.Size = new System.Drawing.Size(789, 45);
            this.txtNameSkill.TabIndex = 3;
            this.txtNameSkill.TextChanged += new System.EventHandler(this.txtNameSkill_TextChanged);
            // 
            // cboActivate
            // 
            this.cboActivate.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboActivate.BackColor = System.Drawing.SystemColors.ControlText;
            this.cboActivate.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboActivate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.cboActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivate.ForeColor = System.Drawing.Color.White;
            this.cboActivate.Location = new System.Drawing.Point(1051, 136);
            this.cboActivate.Name = "cboActivate";
            this.cboActivate.Size = new System.Drawing.Size(112, 49);
            this.cboActivate.TabIndex = 21;
            this.cboActivate.Text = "Activar";
            this.cboActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.UseVisualStyleBackColor = false;
            // 
            // flpSkills
            // 
            this.flpSkills.AutoScroll = true;
            this.flpSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpSkills.Controls.Add(this.btnAdd);
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpSkills.Location = new System.Drawing.Point(0, 412);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(1192, 150);
            this.flpSkills.TabIndex = 24;
            this.flpSkills.WrapContents = false;
            // 
            // btnBColor
            // 
            this.btnBColor.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBColor.ForeColor = System.Drawing.Color.White;
            this.btnBColor.Location = new System.Drawing.Point(682, 224);
            this.btnBColor.Name = "btnBColor";
            this.btnBColor.Size = new System.Drawing.Size(214, 42);
            this.btnBColor.TabIndex = 26;
            this.btnBColor.Text = "Background Color";
            this.btnBColor.UseVisualStyleBackColor = false;
            this.btnBColor.Click += new System.EventHandler(this.btnBColor_Click);
            // 
            // txtBcolor
            // 
            this.txtBcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBcolor.Location = new System.Drawing.Point(923, 224);
            this.txtBcolor.Name = "txtBcolor";
            this.txtBcolor.ReadOnly = true;
            this.txtBcolor.Size = new System.Drawing.Size(91, 41);
            this.txtBcolor.TabIndex = 27;
            this.txtBcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTColor
            // 
            this.btnTColor.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnTColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTColor.ForeColor = System.Drawing.Color.White;
            this.btnTColor.Location = new System.Drawing.Point(682, 302);
            this.btnTColor.Name = "btnTColor";
            this.btnTColor.Size = new System.Drawing.Size(214, 42);
            this.btnTColor.TabIndex = 28;
            this.btnTColor.Text = "Text Color";
            this.btnTColor.UseVisualStyleBackColor = false;
            this.btnTColor.Click += new System.EventHandler(this.btnTColor_Click);
            // 
            // txtTcolor
            // 
            this.txtTcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTcolor.Location = new System.Drawing.Point(923, 302);
            this.txtTcolor.Name = "txtTcolor";
            this.txtTcolor.ReadOnly = true;
            this.txtTcolor.Size = new System.Drawing.Size(91, 41);
            this.txtTcolor.TabIndex = 29;
            this.txtTcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 56);
            this.panel1.TabIndex = 30;
            // 
            // lblNameListSkills
            // 
            this.lblNameListSkills.AutoSize = true;
            this.lblNameListSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameListSkills.Location = new System.Drawing.Point(472, 79);
            this.lblNameListSkills.Name = "lblNameListSkills";
            this.lblNameListSkills.Size = new System.Drawing.Size(273, 36);
            this.lblNameListSkills.TabIndex = 31;
            this.lblNameListSkills.Text = "Nombre Lista Skill";
            this.lblNameListSkills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 640);
            this.Controls.Add(this.lblNameListSkills);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTcolor);
            this.Controls.Add(this.btnTColor);
            this.Controls.Add(this.txtBcolor);
            this.Controls.Add(this.btnBColor);
            this.Controls.Add(this.flpSkills);
            this.Controls.Add(this.cboActivate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLetraSkill);
            this.Controls.Add(this.txtWordSkill);
            this.Controls.Add(this.txtNameSkill);
            this.Controls.Add(this.lblNombreSkill);
            this.Name = "FormSkill";
            this.Text = "FormSkill";
            this.Load += new System.EventHandler(this.FormSkill_Load);
            this.panel2.ResumeLayout(false);
            this.flpSkills.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreSkill;
        private System.Windows.Forms.TextBox txtWordSkill;
        private System.Windows.Forms.Label lblLetraSkill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNameSkill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cboActivate;
        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.ColorDialog cdBackgroundColor;
        private System.Windows.Forms.Button btnBColor;
        private System.Windows.Forms.TextBox txtBcolor;
        private System.Windows.Forms.Button btnTColor;
        private System.Windows.Forms.TextBox txtTcolor;
        private System.Windows.Forms.ColorDialog cdTextColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNameListSkills;
    }
}