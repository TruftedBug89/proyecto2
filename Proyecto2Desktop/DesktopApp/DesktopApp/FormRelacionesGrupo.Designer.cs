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
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSearchUsers = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSourceCoursesListSkillsUsers = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCourses = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxCourses = new System.Windows.Forms.ComboBox();
            this.btnManagmentCourses = new System.Windows.Forms.Button();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.dgvListSkills = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlGroupsHasSkills = new System.Windows.Forms.Panel();
            this.lblDataSelect = new System.Windows.Forms.Label();
            this.lbGroupsHasSkills = new System.Windows.Forms.ListBox();
            this.lblDates = new System.Windows.Forms.Label();
            this.bindingSourceGrupsHasSkills = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGrupsStudTeach = new System.Windows.Forms.Panel();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.bindingSourceGrupsHasStudents = new System.Windows.Forms.BindingSource(this.components);
            this.lbTeachers = new System.Windows.Forms.ListBox();
            this.bindingSourceGroupsHasTeachers = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bgCoursesGroups = new System.Windows.Forms.GroupBox();
            this.cbxGroupsCourses = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbTypeRelations = new System.Windows.Forms.GroupBox();
            this.rdbOneListUserHasGroups = new System.Windows.Forms.RadioButton();
            this.rdbOneGroupHasListUsers = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            this.pnlSearchUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoursesListSkillsUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSkills)).BeginInit();
            this.pnlGroupsHasSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrupsHasSkills)).BeginInit();
            this.pnlGrupsStudTeach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGrupsHasStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroupsHasTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.bgCoursesGroups.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbTypeRelations.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(DesktopApp.Models.grups);
            // 
            // pnlSearchUsers
            // 
            this.pnlSearchUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearchUsers.Controls.Add(this.textBox1);
            this.pnlSearchUsers.Controls.Add(this.label1);
            this.pnlSearchUsers.Location = new System.Drawing.Point(420, 170);
            this.pnlSearchUsers.Name = "pnlSearchUsers";
            this.pnlSearchUsers.Size = new System.Drawing.Size(316, 80);
            this.pnlSearchUsers.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(119, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 28);
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
            this.dgvUsers.Location = new System.Drawing.Point(420, 261);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(639, 491);
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
            this.Column3.DataSource = this.bindingSourceCoursesListSkillsUsers;
            this.Column3.DisplayMember = "nom";
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column3.HeaderText = "Curso";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bindingSourceCoursesListSkillsUsers
            // 
            this.bindingSourceCoursesListSkillsUsers.DataSource = this.bindingSourceCourses;
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
            this.btnSave.Location = new System.Drawing.Point(587, 818);
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
            this.btnExit.Location = new System.Drawing.Point(737, 818);
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
            this.cbxCourses.DataSource = this.bindingSourceCoursesListSkillsUsers;
            this.cbxCourses.DisplayMember = "nom";
            this.cbxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCourses.FormattingEnabled = true;
            this.cbxCourses.Location = new System.Drawing.Point(45, 32);
            this.cbxCourses.Name = "cbxCourses";
            this.cbxCourses.Size = new System.Drawing.Size(201, 30);
            this.cbxCourses.TabIndex = 41;
            this.cbxCourses.ValueMember = "id";
            this.cbxCourses.SelectedIndexChanged += new System.EventHandler(this.cbxCourses_SelectedIndexChanged);
            // 
            // btnManagmentCourses
            // 
            this.btnManagmentCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagmentCourses.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManagmentCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentCourses.ForeColor = System.Drawing.Color.White;
            this.btnManagmentCourses.Location = new System.Drawing.Point(1207, 57);
            this.btnManagmentCourses.Name = "btnManagmentCourses";
            this.btnManagmentCourses.Size = new System.Drawing.Size(184, 49);
            this.btnManagmentCourses.TabIndex = 40;
            this.btnManagmentCourses.Text = "Gestion Cursos";
            this.btnManagmentCourses.UseVisualStyleBackColor = false;
            this.btnManagmentCourses.Click += new System.EventHandler(this.btnManagmentCourses_Click);
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
            this.dgvListSkills.Location = new System.Drawing.Point(420, 278);
            this.dgvListSkills.Name = "dgvListSkills";
            this.dgvListSkills.RowHeadersWidth = 51;
            this.dgvListSkills.RowTemplate.Height = 24;
            this.dgvListSkills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSkills.Size = new System.Drawing.Size(639, 491);
            this.dgvListSkills.TabIndex = 42;
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
            this.dataGridViewComboBoxColumn1.DataSource = this.bindingSourceCoursesListSkillsUsers;
            this.dataGridViewComboBoxColumn1.DisplayMember = "nom";
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.HeaderText = "Curso";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnlGroupsHasSkills
            // 
            this.pnlGroupsHasSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGroupsHasSkills.Controls.Add(this.lblDataSelect);
            this.pnlGroupsHasSkills.Controls.Add(this.lbGroupsHasSkills);
            this.pnlGroupsHasSkills.Controls.Add(this.lblDates);
            this.pnlGroupsHasSkills.Location = new System.Drawing.Point(1132, 218);
            this.pnlGroupsHasSkills.Name = "pnlGroupsHasSkills";
            this.pnlGroupsHasSkills.Size = new System.Drawing.Size(259, 517);
            this.pnlGroupsHasSkills.TabIndex = 35;
            // 
            // lblDataSelect
            // 
            this.lblDataSelect.AutoSize = true;
            this.lblDataSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSelect.Location = new System.Drawing.Point(156, 21);
            this.lblDataSelect.Name = "lblDataSelect";
            this.lblDataSelect.Size = new System.Drawing.Size(52, 24);
            this.lblDataSelect.TabIndex = 45;
            this.lblDataSelect.Text = "Dato";
            // 
            // lbGroupsHasSkills
            // 
            this.lbGroupsHasSkills.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbGroupsHasSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroupsHasSkills.FormattingEnabled = true;
            this.lbGroupsHasSkills.ItemHeight = 22;
            this.lbGroupsHasSkills.Location = new System.Drawing.Point(21, 60);
            this.lbGroupsHasSkills.Name = "lbGroupsHasSkills";
            this.lbGroupsHasSkills.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGroupsHasSkills.Size = new System.Drawing.Size(217, 422);
            this.lbGroupsHasSkills.TabIndex = 43;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(40, 21);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(94, 24);
            this.lblDates.TabIndex = 19;
            this.lblDates.Text = "Skills de:";
            // 
            // bindingSourceGrupsHasSkills
            // 
            this.bindingSourceGrupsHasSkills.DataSource = typeof(DesktopApp.Models.grups_has_llistes_skills);
            // 
            // pnlGrupsStudTeach
            // 
            this.pnlGrupsStudTeach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGrupsStudTeach.Controls.Add(this.lbStudents);
            this.pnlGrupsStudTeach.Controls.Add(this.lbTeachers);
            this.pnlGrupsStudTeach.Controls.Add(this.label6);
            this.pnlGrupsStudTeach.Controls.Add(this.label5);
            this.pnlGrupsStudTeach.Location = new System.Drawing.Point(1156, 252);
            this.pnlGrupsStudTeach.Name = "pnlGrupsStudTeach";
            this.pnlGrupsStudTeach.Size = new System.Drawing.Size(259, 517);
            this.pnlGrupsStudTeach.TabIndex = 44;
            // 
            // lbStudents
            // 
            this.lbStudents.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbStudents.DataSource = this.bindingSourceGrupsHasStudents;
            this.lbStudents.DisplayMember = "usuaris_id";
            this.lbStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 22;
            this.lbStudents.Location = new System.Drawing.Point(24, 46);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbStudents.Size = new System.Drawing.Size(199, 180);
            this.lbStudents.TabIndex = 46;
            this.lbStudents.ValueMember = "grups_id";
            // 
            // bindingSourceGrupsHasStudents
            // 
            this.bindingSourceGrupsHasStudents.DataSource = typeof(DesktopApp.Models.grups_has_alumnes);
            // 
            // lbTeachers
            // 
            this.lbTeachers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbTeachers.DataSource = this.bindingSourceGroupsHasTeachers;
            this.lbTeachers.DisplayMember = "usuaris_id";
            this.lbTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeachers.FormattingEnabled = true;
            this.lbTeachers.ItemHeight = 22;
            this.lbTeachers.Location = new System.Drawing.Point(24, 303);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTeachers.Size = new System.Drawing.Size(199, 180);
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
            this.label6.Location = new System.Drawing.Point(82, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Docentes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Alumnos";
            // 
            // dgvGroups
            // 
            this.dgvGroups.AllowUserToAddRows = false;
            this.dgvGroups.AllowUserToDeleteRows = false;
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn2});
            this.dgvGroups.Location = new System.Drawing.Point(23, 278);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.RowHeadersWidth = 51;
            this.dgvGroups.RowTemplate.Height = 24;
            this.dgvGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroups.Size = new System.Drawing.Size(305, 491);
            this.dgvGroups.TabIndex = 45;
            this.dgvGroups.SelectionChanged += new System.EventHandler(this.dgvGroups_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Grupos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataSource = this.bindingSourceCourses;
            this.dataGridViewComboBoxColumn2.DisplayMember = "nom";
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn2.HeaderText = "Curso";
            this.dataGridViewComboBoxColumn2.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bgCoursesGroups
            // 
            this.bgCoursesGroups.Controls.Add(this.cbxGroupsCourses);
            this.bgCoursesGroups.Location = new System.Drawing.Point(23, 152);
            this.bgCoursesGroups.Name = "bgCoursesGroups";
            this.bgCoursesGroups.Size = new System.Drawing.Size(305, 100);
            this.bgCoursesGroups.TabIndex = 46;
            this.bgCoursesGroups.TabStop = false;
            this.bgCoursesGroups.Text = "Asignar cursos a grupos Selecionados";
            // 
            // cbxGroupsCourses
            // 
            this.cbxGroupsCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGroupsCourses.DataSource = this.bindingSourceCourses;
            this.cbxGroupsCourses.DisplayMember = "nom";
            this.cbxGroupsCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroupsCourses.FormattingEnabled = true;
            this.cbxGroupsCourses.Location = new System.Drawing.Point(45, 37);
            this.cbxGroupsCourses.Name = "cbxGroupsCourses";
            this.cbxGroupsCourses.Size = new System.Drawing.Size(201, 30);
            this.cbxGroupsCourses.TabIndex = 47;
            this.cbxGroupsCourses.ValueMember = "id";
            this.cbxGroupsCourses.SelectedIndexChanged += new System.EventHandler(this.cbxGroupsCourses_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCourses);
            this.groupBox1.Location = new System.Drawing.Point(754, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 98);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar Cursos a Listas Seleccionadas";
            // 
            // gbTypeRelations
            // 
            this.gbTypeRelations.Controls.Add(this.rdbOneListUserHasGroups);
            this.gbTypeRelations.Controls.Add(this.rdbOneGroupHasListUsers);
            this.gbTypeRelations.Location = new System.Drawing.Point(23, 31);
            this.gbTypeRelations.Name = "gbTypeRelations";
            this.gbTypeRelations.Size = new System.Drawing.Size(940, 100);
            this.gbTypeRelations.TabIndex = 50;
            this.gbTypeRelations.TabStop = false;
            this.gbTypeRelations.Text = "Tipo de Relaciones";
            // 
            // rdbOneListUserHasGroups
            // 
            this.rdbOneListUserHasGroups.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbOneListUserHasGroups.BackColor = System.Drawing.Color.Black;
            this.rdbOneListUserHasGroups.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdbOneListUserHasGroups.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rdbOneListUserHasGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbOneListUserHasGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOneListUserHasGroups.ForeColor = System.Drawing.Color.White;
            this.rdbOneListUserHasGroups.Location = new System.Drawing.Point(483, 26);
            this.rdbOneListUserHasGroups.Name = "rdbOneListUserHasGroups";
            this.rdbOneListUserHasGroups.Size = new System.Drawing.Size(423, 49);
            this.rdbOneListUserHasGroups.TabIndex = 52;
            this.rdbOneListUserHasGroups.TabStop = true;
            this.rdbOneListUserHasGroups.Text = "Una lista tiene muchos Grupos";
            this.rdbOneListUserHasGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbOneListUserHasGroups.UseVisualStyleBackColor = false;
            this.rdbOneListUserHasGroups.CheckedChanged += new System.EventHandler(this.rdbOneListUserHasGroups_CheckedChanged);
            // 
            // rdbOneGroupHasListUsers
            // 
            this.rdbOneGroupHasListUsers.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbOneGroupHasListUsers.BackColor = System.Drawing.Color.Black;
            this.rdbOneGroupHasListUsers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rdbOneGroupHasListUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rdbOneGroupHasListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbOneGroupHasListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOneGroupHasListUsers.ForeColor = System.Drawing.Color.White;
            this.rdbOneGroupHasListUsers.Location = new System.Drawing.Point(22, 26);
            this.rdbOneGroupHasListUsers.Name = "rdbOneGroupHasListUsers";
            this.rdbOneGroupHasListUsers.Size = new System.Drawing.Size(423, 49);
            this.rdbOneGroupHasListUsers.TabIndex = 51;
            this.rdbOneGroupHasListUsers.TabStop = true;
            this.rdbOneGroupHasListUsers.Text = "Un grupo tiene muchas Listas";
            this.rdbOneGroupHasListUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbOneGroupHasListUsers.UseVisualStyleBackColor = false;
            this.rdbOneGroupHasListUsers.CheckedChanged += new System.EventHandler(this.rdbOneGroupHasListUsers_CheckedChanged);
            // 
            // FormRelacionesGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1457, 924);
            this.Controls.Add(this.gbTypeRelations);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlGroupsHasSkills);
            this.Controls.Add(this.pnlGrupsStudTeach);
            this.Controls.Add(this.bgCoursesGroups);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.dgvListSkills);
            this.Controls.Add(this.btnManagmentCourses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlSearchUsers);
            this.Name = "FormRelacionesGrupo";
            this.Text = "FormRelacionesGrupo";
            this.Load += new System.EventHandler(this.FormRelacionesGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            this.pnlSearchUsers.ResumeLayout(false);
            this.pnlSearchUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoursesListSkillsUsers)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.bgCoursesGroups.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbTypeRelations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSearchUsers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbxCourses;
        private System.Windows.Forms.Button btnManagmentCourses;
        private System.Windows.Forms.BindingSource bindingSourceCourses;
        private System.Windows.Forms.BindingSource bindingSourceGroups;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private System.Windows.Forms.DataGridView dgvListSkills;
        private System.Windows.Forms.Panel pnlGroupsHasSkills;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.ListBox lbGroupsHasSkills;
        private System.Windows.Forms.Panel pnlGrupsStudTeach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.ListBox lbTeachers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSourceGrupsHasSkills;
        private System.Windows.Forms.BindingSource bindingSourceGrupsHasStudents;
        private System.Windows.Forms.BindingSource bindingSourceGroupsHasTeachers;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.GroupBox bgCoursesGroups;
        private System.Windows.Forms.ComboBox cbxGroupsCourses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDataSelect;
        private System.Windows.Forms.GroupBox gbTypeRelations;
        private System.Windows.Forms.RadioButton rdbOneGroupHasListUsers;
        private System.Windows.Forms.RadioButton rdbOneListUserHasGroups;
        private System.Windows.Forms.BindingSource bindingSourceCoursesListSkillsUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
    }
}