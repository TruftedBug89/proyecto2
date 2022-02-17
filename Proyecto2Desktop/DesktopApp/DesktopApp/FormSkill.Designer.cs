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
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreSkill = new System.Windows.Forms.Label();
            this.txtWordSkill = new System.Windows.Forms.TextBox();
            this.lblLetraSkill = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.txtNameSkill = new System.Windows.Forms.TextBox();
            this.cboActivate = new System.Windows.Forms.CheckBox();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.cdBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.btnBColor = new System.Windows.Forms.Button();
            this.txtBcolor = new System.Windows.Forms.TextBox();
            this.btnTColor = new System.Windows.Forms.Button();
            this.txtTcolor = new System.Windows.Forms.TextBox();
            this.cdTextColor = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flpSkills.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.BackColor = System.Drawing.Color.Tomato;
            this.btnCerrarSesión.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Location = new System.Drawing.Point(1491, 11);
            this.btnCerrarSesión.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(223, 43);
            this.btnCerrarSesión.TabIndex = 0;
            this.btnCerrarSesión.Text = "Cerar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCerrarSesión);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 51);
            this.panel1.TabIndex = 1;
            // 
            // lblNombreSkill
            // 
            this.lblNombreSkill.AutoSize = true;
            this.lblNombreSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSkill.Location = new System.Drawing.Point(73, 121);
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
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(20, 20);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(20, 20, 4, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(101, 92);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "+";
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // txtNameSkill
            // 
            this.txtNameSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSkill.Location = new System.Drawing.Point(225, 114);
            this.txtNameSkill.Name = "txtNameSkill";
            this.txtNameSkill.Size = new System.Drawing.Size(789, 45);
            this.txtNameSkill.TabIndex = 3;
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
            this.cboActivate.Location = new System.Drawing.Point(1053, 114);
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
            this.flpSkills.Controls.Add(this.btnAñadir);
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            // FormSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 640);
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
            this.Controls.Add(this.panel1);
            this.Name = "FormSkill";
            this.Text = "FormSkill";
            this.Load += new System.EventHandler(this.FormSkill_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flpSkills.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreSkill;
        private System.Windows.Forms.TextBox txtWordSkill;
        private System.Windows.Forms.Label lblLetraSkill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNameSkill;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cboActivate;
        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.ColorDialog cdBackgroundColor;
        private System.Windows.Forms.Button btnBColor;
        private System.Windows.Forms.TextBox txtBcolor;
        private System.Windows.Forms.Button btnTColor;
        private System.Windows.Forms.TextBox txtTcolor;
        private System.Windows.Forms.ColorDialog cdTextColor;
    }
}