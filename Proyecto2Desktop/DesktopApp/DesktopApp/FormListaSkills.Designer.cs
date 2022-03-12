namespace DesktopApp
{
    partial class FormListaSkills
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
            this.components = new System.ComponentModel.Container();
            this.lblNameListSkill = new System.Windows.Forms.Label();
            this.txtNameListSkill = new System.Windows.Forms.TextBox();
            this.dgvListaSkills = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGroups = new System.Windows.Forms.ComboBox();
            this.btnManagmentGroups = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flpListSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.cboActivate = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSourceSkills = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuildTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSkills)).BeginInit();
            this.flpListSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameListSkill
            // 
            this.lblNameListSkill.AutoSize = true;
            this.lblNameListSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameListSkill.Location = new System.Drawing.Point(211, 203);
            this.lblNameListSkill.Name = "lblNameListSkill";
            this.lblNameListSkill.Size = new System.Drawing.Size(212, 24);
            this.lblNameListSkill.TabIndex = 3;
            this.lblNameListSkill.Text = "Lista de Skills(Siglas):";
            // 
            // txtNameListSkill
            // 
            this.txtNameListSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameListSkill.Location = new System.Drawing.Point(460, 194);
            this.txtNameListSkill.Name = "txtNameListSkill";
            this.txtNameListSkill.Size = new System.Drawing.Size(553, 45);
            this.txtNameListSkill.TabIndex = 4;
            // 
            // dgvListaSkills
            // 
            this.dgvListaSkills.AllowUserToAddRows = false;
            this.dgvListaSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSkills.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvListaSkills.Location = new System.Drawing.Point(215, 266);
            this.dgvListaSkills.Name = "dgvListaSkills";
            this.dgvListaSkills.RowHeadersWidth = 51;
            this.dgvListaSkills.RowTemplate.Height = 24;
            this.dgvListaSkills.Size = new System.Drawing.Size(918, 366);
            this.dgvListaSkills.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(602, 677);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(742, 677);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 42);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1150, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Grupos:";
            // 
            // cbxGroups
            // 
            this.cbxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroups.FormattingEnabled = true;
            this.cbxGroups.Location = new System.Drawing.Point(1240, 310);
            this.cbxGroups.Name = "cbxGroups";
            this.cbxGroups.Size = new System.Drawing.Size(179, 30);
            this.cbxGroups.TabIndex = 17;
            // 
            // btnManagmentGroups
            // 
            this.btnManagmentGroups.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManagmentGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentGroups.ForeColor = System.Drawing.Color.White;
            this.btnManagmentGroups.Location = new System.Drawing.Point(1154, 379);
            this.btnManagmentGroups.Name = "btnManagmentGroups";
            this.btnManagmentGroups.Size = new System.Drawing.Size(182, 42);
            this.btnManagmentGroups.TabIndex = 18;
            this.btnManagmentGroups.Text = "Gestionar Grupos";
            this.btnManagmentGroups.UseVisualStyleBackColor = false;
            this.btnManagmentGroups.Click += new System.EventHandler(this.btnManagmentGroups_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 10);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(16, 10, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(176, 66);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flpListSkills
            // 
            this.flpListSkills.AutoScroll = true;
            this.flpListSkills.Controls.Add(this.btnAdd);
            this.flpListSkills.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpListSkills.Location = new System.Drawing.Point(0, 51);
            this.flpListSkills.Name = "flpListSkills";
            this.flpListSkills.Size = new System.Drawing.Size(1445, 105);
            this.flpListSkills.TabIndex = 19;
            this.flpListSkills.WrapContents = false;
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
            this.cboActivate.Location = new System.Drawing.Point(1307, 190);
            this.cboActivate.Name = "cboActivate";
            this.cboActivate.Size = new System.Drawing.Size(112, 49);
            this.cboActivate.TabIndex = 20;
            this.cboActivate.Text = "Activar";
            this.cboActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 51);
            this.panel1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1187, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingSourceSkills
            // 
            this.bindingSourceSkills.DataSource = typeof(DesktopApp.Models.skills);
            // 
            // btnBuildTable
            // 
            this.btnBuildTable.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBuildTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildTable.ForeColor = System.Drawing.Color.White;
            this.btnBuildTable.Location = new System.Drawing.Point(1029, 197);
            this.btnBuildTable.Name = "btnBuildTable";
            this.btnBuildTable.Size = new System.Drawing.Size(182, 42);
            this.btnBuildTable.TabIndex = 33;
            this.btnBuildTable.Text = "Añadir Skills";
            this.btnBuildTable.UseVisualStyleBackColor = false;
            this.btnBuildTable.Click += new System.EventHandler(this.btnBuildTable_Click);
            // 
            // FormListaSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1445, 731);
            this.Controls.Add(this.btnBuildTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpListSkills);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboActivate);
            this.Controls.Add(this.btnManagmentGroups);
            this.Controls.Add(this.cbxGroups);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvListaSkills);
            this.Controls.Add(this.txtNameListSkill);
            this.Controls.Add(this.lblNameListSkill);
            this.Name = "FormListaSkills";
            this.Text = "FormListaSkills";
            this.Load += new System.EventHandler(this.FormListaSkills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSkills)).EndInit();
            this.flpListSkills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameListSkill;
        private System.Windows.Forms.TextBox txtNameListSkill;
        private System.Windows.Forms.DataGridView dgvListaSkills;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGroups;
        private System.Windows.Forms.Button btnManagmentGroups;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpListSkills;
        private System.Windows.Forms.BindingSource bindingSourceSkills;
        private System.Windows.Forms.CheckBox cboActivate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuildTable;
    }
}