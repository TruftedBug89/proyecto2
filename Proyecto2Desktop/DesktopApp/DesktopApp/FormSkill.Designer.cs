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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSkill));
            this.lblNombreSkill = new System.Windows.Forms.Label();
            this.txtWordSkill = new System.Windows.Forms.TextBox();
            this.lblLetraSkill = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameSkill = new System.Windows.Forms.TextBox();
            this.cboActivate = new System.Windows.Forms.CheckBox();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBColor = new System.Windows.Forms.Button();
            this.txtBcolor = new System.Windows.Forms.TextBox();
            this.btnTColor = new System.Windows.Forms.Button();
            this.txtTcolor = new System.Windows.Forms.TextBox();
            this.lblNameListSkills = new System.Windows.Forms.Label();
            this.pnBarra = new System.Windows.Forms.Panel();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cdBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.cdTextColor = new System.Windows.Forms.ColorDialog();
            this.flpSkills.SuspendLayout();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreSkill
            // 
            this.lblNombreSkill.AutoSize = true;
            this.lblNombreSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblNombreSkill.Location = new System.Drawing.Point(66, 146);
            this.lblNombreSkill.Name = "lblNombreSkill";
            this.lblNombreSkill.Size = new System.Drawing.Size(105, 30);
            this.lblNombreSkill.TabIndex = 2;
            this.lblNombreSkill.Text = "Nombre";
            // 
            // txtWordSkill
            // 
            this.txtWordSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.txtWordSkill.Location = new System.Drawing.Point(233, 213);
            this.txtWordSkill.Name = "txtWordSkill";
            this.txtWordSkill.ReadOnly = true;
            this.txtWordSkill.Size = new System.Drawing.Size(175, 140);
            this.txtWordSkill.TabIndex = 4;
            this.txtWordSkill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLetraSkill
            // 
            this.lblLetraSkill.AutoSize = true;
            this.lblLetraSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLetraSkill.Location = new System.Drawing.Point(66, 272);
            this.lblLetraSkill.Name = "lblLetraSkill";
            this.lblLetraSkill.Size = new System.Drawing.Size(132, 29);
            this.lblLetraSkill.TabIndex = 5;
            this.lblLetraSkill.Text = "Letra Skill:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(687, 582);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(557, 582);
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
            this.txtNameSkill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNameSkill.Location = new System.Drawing.Point(193, 146);
            this.txtNameSkill.Name = "txtNameSkill";
            this.txtNameSkill.Size = new System.Drawing.Size(740, 36);
            this.txtNameSkill.TabIndex = 3;
            this.txtNameSkill.TextChanged += new System.EventHandler(this.txtNameSkill_TextChanged);
            // 
            // cboActivate
            // 
            this.cboActivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActivate.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.cboActivate.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.Checked = true;
            this.cboActivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboActivate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboActivate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.cboActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivate.ForeColor = System.Drawing.Color.White;
            this.cboActivate.Location = new System.Drawing.Point(821, 377);
            this.cboActivate.Name = "cboActivate";
            this.cboActivate.Size = new System.Drawing.Size(112, 35);
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
            this.flpSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpSkills.Location = new System.Drawing.Point(0, 425);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(985, 143);
            this.flpSkills.TabIndex = 24;
            this.flpSkills.WrapContents = false;
            // 
            // btnBColor
            // 
            this.btnBColor.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBColor.ForeColor = System.Drawing.Color.White;
            this.btnBColor.Location = new System.Drawing.Point(600, 227);
            this.btnBColor.Name = "btnBColor";
            this.btnBColor.Size = new System.Drawing.Size(214, 42);
            this.btnBColor.TabIndex = 26;
            this.btnBColor.Text = "Color del fondo";
            this.btnBColor.UseVisualStyleBackColor = false;
            this.btnBColor.Click += new System.EventHandler(this.btnBColor_Click);
            // 
            // txtBcolor
            // 
            this.txtBcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBcolor.Location = new System.Drawing.Point(842, 227);
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
            this.btnTColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTColor.ForeColor = System.Drawing.Color.White;
            this.btnTColor.Location = new System.Drawing.Point(600, 308);
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
            this.txtTcolor.Location = new System.Drawing.Point(842, 309);
            this.txtTcolor.Name = "txtTcolor";
            this.txtTcolor.ReadOnly = true;
            this.txtTcolor.Size = new System.Drawing.Size(91, 41);
            this.txtTcolor.TabIndex = 29;
            this.txtTcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNameListSkills
            // 
            this.lblNameListSkills.AutoSize = true;
            this.lblNameListSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameListSkills.Location = new System.Drawing.Point(292, 71);
            this.lblNameListSkills.Name = "lblNameListSkills";
            this.lblNameListSkills.Size = new System.Drawing.Size(23, 36);
            this.lblNameListSkills.TabIndex = 31;
            this.lblNameListSkills.Text = " ";
            this.lblNameListSkills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBarra
            // 
            this.pnBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.pnBarra.Controls.Add(this.pcIcono);
            this.pnBarra.Controls.Add(this.pb_minimize);
            this.pnBarra.Controls.Add(this.pb_close);
            this.pnBarra.Location = new System.Drawing.Point(0, 0);
            this.pnBarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(998, 40);
            this.pnBarra.TabIndex = 32;
            this.pnBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseDown);
            // 
            // pcIcono
            // 
            this.pcIcono.Image = ((System.Drawing.Image)(resources.GetObject("pcIcono.Image")));
            this.pcIcono.Location = new System.Drawing.Point(10, 9);
            this.pcIcono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcIcono.Name = "pcIcono";
            this.pcIcono.Size = new System.Drawing.Size(25, 25);
            this.pcIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcIcono.TabIndex = 11;
            this.pcIcono.TabStop = false;
            this.pcIcono.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcIcono_MouseDown);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(789, 9);
            this.pb_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(25, 25);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minimize.TabIndex = 9;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // pb_close
            // 
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(820, 9);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 8;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTitulo.Location = new System.Drawing.Point(41, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(40, 20);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Skill";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            // 
            // FormSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 651);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.cboActivate);
            this.Controls.Add(this.lblNameListSkills);
            this.Controls.Add(this.txtTcolor);
            this.Controls.Add(this.btnTColor);
            this.Controls.Add(this.txtBcolor);
            this.Controls.Add(this.btnBColor);
            this.Controls.Add(this.flpSkills);
            this.Controls.Add(this.lblLetraSkill);
            this.Controls.Add(this.txtWordSkill);
            this.Controls.Add(this.txtNameSkill);
            this.Controls.Add(this.lblNombreSkill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSkill";
            this.Text = "FormSkill";
            this.Load += new System.EventHandler(this.FormSkill_Load);
            this.flpSkills.ResumeLayout(false);
            this.pnBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreSkill;
        private System.Windows.Forms.TextBox txtWordSkill;
        private System.Windows.Forms.Label lblLetraSkill;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNameSkill;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cboActivate;
        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.Button btnBColor;
        private System.Windows.Forms.TextBox txtBcolor;
        private System.Windows.Forms.Button btnTColor;
        private System.Windows.Forms.TextBox txtTcolor;
        private System.Windows.Forms.Label lblNameListSkills;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.ColorDialog cdBackgroundColor;
        private System.Windows.Forms.ColorDialog cdTextColor;
    }
}
