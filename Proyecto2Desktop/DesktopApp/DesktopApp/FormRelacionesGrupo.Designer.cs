namespace DesktopApp
{
    partial class FormRelacionesGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelacionesGrupo));
            this.label2 = new System.Windows.Forms.Label();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearchUsers = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSourceCourses = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxCourses = new System.Windows.Forms.ComboBox();
            this.btnManagmentCourses = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.dgvListSkills = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlGroupsHasSkills = new System.Windows.Forms.Panel();
            this.lbGroupsHasSkills = new System.Windows.Forms.ListBox();
            this.bindingSourceGrupsHasSkills = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pnlGrupsStudTeach = new System.Windows.Forms.Panel();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.bindingSourceGrupsHasStudents = new System.Windows.Forms.BindingSource(this.components);
            this.lbTeachers = new System.Windows.Forms.ListBox();
            this.bindingSourceGroupsHasTeachers = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            this.pnlSearchUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSkills)).BeginInit();
            this.pnlGroupsHasSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrupsHasSkills)).BeginInit();
            this.pnlGrupsStudTeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrupsHasStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroupsHasTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Lista de Grupos";
            // 
            // lbGroups
            // 
            this.lbGroups.DataSource = this.bindingSourceGroups;
            this.lbGroups.DisplayMember = "nom";
            this.lbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 22;
            this.lbGroups.Location = new System.Drawing.Point(36, 116);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGroups.Size = new System.Drawing.Size(287, 422);
            this.lbGroups.TabIndex = 29;
            this.lbGroups.ValueMember = "id";
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(DesktopApp.Models.grups);
            // 
            // pnlSearchUsers
            // 
            this.pnlSearchUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchUsers.Controls.Add(this.pictureBox1);
            this.pnlSearchUsers.Controls.Add(this.textBox1);
            this.pnlSearchUsers.Controls.Add(this.label1);
            this.pnlSearchUsers.Location = new System.Drawing.Point(719, 100);
            this.pnlSearchUsers.Name = "pnlSearchUsers";
            this.pnlSearchUsers.Size = new System.Drawing.Size(421, 76);
            this.pnlSearchUsers.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(119, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 36);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Usuarios:";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvUsers.Location = new System.Drawing.Point(719, 182);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(421, 373);
            this.dgvUsers.TabIndex = 36;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Usuarios";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Docente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.DataSource = this.bindingSourceCourses;
            this.Column3.DisplayMember = "nom";
            this.Column3.HeaderText = "Curso";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bindingSourceCourses
            // 
            this.bindingSourceCourses.DataSource = typeof(DesktopApp.Models.cursos);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(464, 614);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(625, 614);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 42);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxCourses
            // 
            this.cbxCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCourses.DataSource = this.bindingSourceCourses;
            this.cbxCourses.DisplayMember = "nom";
            this.cbxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCourses.FormattingEnabled = true;
            this.cbxCourses.Location = new System.Drawing.Point(864, 37);
            this.cbxCourses.Name = "cbxCourses";
            this.cbxCourses.Size = new System.Drawing.Size(201, 37);
            this.cbxCourses.TabIndex = 41;
            this.cbxCourses.ValueMember = "id";
            this.cbxCourses.SelectedIndexChanged += new System.EventHandler(this.cbxCourses_SelectedIndexChanged);
            // 
            // btnManagmentCourses
            // 
            this.btnManagmentCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagmentCourses.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManagmentCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentCourses.ForeColor = System.Drawing.Color.White;
            this.btnManagmentCourses.Location = new System.Drawing.Point(1071, 26);
            this.btnManagmentCourses.Name = "btnManagmentCourses";
            this.btnManagmentCourses.Size = new System.Drawing.Size(97, 62);
            this.btnManagmentCourses.TabIndex = 40;
            this.btnManagmentCourses.Text = "Gestion Cursos";
            this.btnManagmentCourses.UseVisualStyleBackColor = false;
            this.btnManagmentCourses.Click += new System.EventHandler(this.btnManagmentCourses_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Cursos:";
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.DataSource = typeof(DesktopApp.Models.usuaris);
            // 
            // dgvListSkills
            // 
            this.dgvListSkills.AllowUserToAddRows = false;
            this.dgvListSkills.AllowUserToDeleteRows = false;
            this.dgvListSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn1});
            this.dgvListSkills.Location = new System.Drawing.Point(781, 182);
            this.dgvListSkills.Name = "dgvListSkills";
            this.dgvListSkills.RowHeadersWidth = 51;
            this.dgvListSkills.RowTemplate.Height = 24;
            this.dgvListSkills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSkills.Size = new System.Drawing.Size(359, 400);
            this.dgvListSkills.TabIndex = 42;
            this.dgvListSkills.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListSkills_CellFormatting);
            this.dgvListSkills.SelectionChanged += new System.EventHandler(this.dgvListSkills_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Listas Skills";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataSource = this.bindingSourceCourses;
            this.dataGridViewComboBoxColumn1.DisplayMember = "nom";
            this.dataGridViewComboBoxColumn1.HeaderText = "Curso";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnlGroupsHasSkills
            // 
            this.pnlGroupsHasSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGroupsHasSkills.Controls.Add(this.lbGroupsHasSkills);
            this.pnlGroupsHasSkills.Controls.Add(this.label4);
            this.pnlGroupsHasSkills.Location = new System.Drawing.Point(338, 116);
            this.pnlGroupsHasSkills.Name = "pnlGroupsHasSkills";
            this.pnlGroupsHasSkills.Size = new System.Drawing.Size(309, 422);
            this.pnlGroupsHasSkills.TabIndex = 35;
            // 
            // lbGroupsHasSkills
            // 
            this.lbGroupsHasSkills.DataSource = this.bindingSourceGrupsHasSkills;
            this.lbGroupsHasSkills.DisplayMember = "llistes_skills_id";
            this.lbGroupsHasSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroupsHasSkills.FormattingEnabled = true;
            this.lbGroupsHasSkills.ItemHeight = 22;
            this.lbGroupsHasSkills.Location = new System.Drawing.Point(39, 66);
            this.lbGroupsHasSkills.Name = "lbGroupsHasSkills";
            this.lbGroupsHasSkills.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGroupsHasSkills.Size = new System.Drawing.Size(241, 334);
            this.lbGroupsHasSkills.TabIndex = 43;
            this.lbGroupsHasSkills.ValueMember = "grups_id";
            // 
            // bindingSourceGrupsHasSkills
            // 
            this.bindingSourceGrupsHasSkills.DataSource = typeof(DesktopApp.Models.grups_has_llistes_skills);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Skills de Grupo";
            // 
            // pnlGrupsStudTeach
            // 
            this.pnlGrupsStudTeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrupsStudTeach.Controls.Add(this.lbStudents);
            this.pnlGrupsStudTeach.Controls.Add(this.lbTeachers);
            this.pnlGrupsStudTeach.Controls.Add(this.label6);
            this.pnlGrupsStudTeach.Controls.Add(this.label5);
            this.pnlGrupsStudTeach.Location = new System.Drawing.Point(573, 46);
            this.pnlGrupsStudTeach.Name = "pnlGrupsStudTeach";
            this.pnlGrupsStudTeach.Size = new System.Drawing.Size(306, 422);
            this.pnlGrupsStudTeach.TabIndex = 44;
            // 
            // lbStudents
            // 
            this.lbStudents.DataSource = this.bindingSourceGrupsHasStudents;
            this.lbStudents.DisplayMember = "usuaris_id";
            this.lbStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 22;
            this.lbStudents.Location = new System.Drawing.Point(33, 68);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbStudents.Size = new System.Drawing.Size(244, 136);
            this.lbStudents.TabIndex = 46;
            this.lbStudents.ValueMember = "grups_id";
            // 
            // bindingSourceGrupsHasStudents
            // 
            this.bindingSourceGrupsHasStudents.DataSource = typeof(DesktopApp.Models.grups_has_alumnes);
            // 
            // lbTeachers
            // 
            this.lbTeachers.DataSource = this.bindingSourceGroupsHasTeachers;
            this.lbTeachers.DisplayMember = "usuaris_id";
            this.lbTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeachers.FormattingEnabled = true;
            this.lbTeachers.ItemHeight = 22;
            this.lbTeachers.Location = new System.Drawing.Point(33, 266);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTeachers.Size = new System.Drawing.Size(244, 136);
            this.lbTeachers.TabIndex = 45;
            this.lbTeachers.ValueMember = "grups_id";
            // 
            // bindingSourceGroupsHasTeachers
            // 
            this.bindingSourceGroupsHasTeachers.DataSource = typeof(DesktopApp.Models.grups_has_docents);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Docentes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Alumnos";
            // 
            // FormRelacionesGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1197, 687);
            this.Controls.Add(this.pnlGrupsStudTeach);
            this.Controls.Add(this.pnlGroupsHasSkills);
            this.Controls.Add(this.dgvListSkills);
            this.Controls.Add(this.cbxCourses);
            this.Controls.Add(this.btnManagmentCourses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlSearchUsers);
            this.Controls.Add(this.lbGroups);
            this.Controls.Add(this.label2);
            this.Name = "FormRelacionesGrupo";
            this.Text = "FormRelacionesGrupo";
            this.Load += new System.EventHandler(this.FormRelacionesGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            this.pnlSearchUsers.ResumeLayout(false);
            this.pnlSearchUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSkills)).EndInit();
            this.pnlGroupsHasSkills.ResumeLayout(false);
            this.pnlGroupsHasSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrupsHasSkills)).EndInit();
            this.pnlGrupsStudTeach.ResumeLayout(false);
            this.pnlGrupsStudTeach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrupsHasStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroupsHasTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.Panel pnlSearchUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbxCourses;
        private System.Windows.Forms.Button btnManagmentCourses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSourceCourses;
        private System.Windows.Forms.BindingSource bindingSourceGroups;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridView dgvListSkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.Panel pnlGroupsHasSkills;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbGroupsHasSkills;
        private System.Windows.Forms.Panel pnlGrupsStudTeach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.ListBox lbTeachers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSourceGrupsHasSkills;
        private System.Windows.Forms.BindingSource bindingSourceGrupsHasStudents;
        private System.Windows.Forms.BindingSource bindingSourceGroupsHasTeachers;
    }
}