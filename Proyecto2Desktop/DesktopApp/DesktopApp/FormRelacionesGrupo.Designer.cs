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
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bgCoursesGroups = new System.Windows.Forms.GroupBox();
            this.cbxGroupsCourses = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGroups = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
            this.pnlSearchUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
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
            this.pnlSearchUsers.Location = new System.Drawing.Point(420, 51);
            this.pnlSearchUsers.Name = "pnlSearchUsers";
            this.pnlSearchUsers.Size = new System.Drawing.Size(333, 76);
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
            this.dgvUsers.Location = new System.Drawing.Point(420, 143);
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
            this.btnSave.Location = new System.Drawing.Point(582, 674);
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
            this.btnExit.Location = new System.Drawing.Point(728, 674);
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
            this.cbxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCourses.FormattingEnabled = true;
            this.cbxCourses.Location = new System.Drawing.Point(41, 32);
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
            this.btnManagmentCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentCourses.ForeColor = System.Drawing.Color.White;
            this.btnManagmentCourses.Location = new System.Drawing.Point(1210, 54);
            this.btnManagmentCourses.Name = "btnManagmentCourses";
            this.btnManagmentCourses.Size = new System.Drawing.Size(165, 38);
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
            this.dgvListSkills.Location = new System.Drawing.Point(420, 154);
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
            this.pnlGroupsHasSkills.Location = new System.Drawing.Point(1175, 142);
            this.pnlGroupsHasSkills.Name = "pnlGroupsHasSkills";
            this.pnlGroupsHasSkills.Size = new System.Drawing.Size(259, 517);
            this.pnlGroupsHasSkills.TabIndex = 35;
            // 
            // lbGroupsHasSkills
            // 
            this.lbGroupsHasSkills.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbGroupsHasSkills.DataSource = this.bindingSourceGrupsHasSkills;
            this.lbGroupsHasSkills.DisplayMember = "llistes_skills_id";
            this.lbGroupsHasSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroupsHasSkills.FormattingEnabled = true;
            this.lbGroupsHasSkills.ItemHeight = 22;
            this.lbGroupsHasSkills.Location = new System.Drawing.Point(21, 60);
            this.lbGroupsHasSkills.Name = "lbGroupsHasSkills";
            this.lbGroupsHasSkills.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGroupsHasSkills.Size = new System.Drawing.Size(217, 422);
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
            this.label4.Location = new System.Drawing.Point(40, 21);
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
            this.pnlGrupsStudTeach.Location = new System.Drawing.Point(1186, 128);
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
            this.dgvGroups.Location = new System.Drawing.Point(23, 154);
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
            this.dataGridViewComboBoxColumn2.HeaderText = "Curso";
            this.dataGridViewComboBoxColumn2.MinimumWidth = 6;
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bgCoursesGroups
            // 
            this.bgCoursesGroups.Controls.Add(this.cbxGroupsCourses);
            this.bgCoursesGroups.Location = new System.Drawing.Point(23, 38);
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
            this.groupBox1.Location = new System.Drawing.Point(780, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 100);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar Cursos a Listas Seleccionadas";
            // 
            // lbGroups
            // 
            this.lbGroups.DataSource = this.bindingSourceGroups;
            this.lbGroups.DisplayMember = "nom";
            this.lbGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 22;
            this.lbGroups.Location = new System.Drawing.Point(50, 154);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGroups.Size = new System.Drawing.Size(187, 510);
            this.lbGroups.TabIndex = 29;
            this.lbGroups.ValueMember = "id";
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // FormRelacionesGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1457, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bgCoursesGroups);
            this.Controls.Add(this.dgvGroups);
            this.Controls.Add(this.pnlGrupsStudTeach);
            this.Controls.Add(this.pnlGroupsHasSkills);
            this.Controls.Add(this.dgvListSkills);
            this.Controls.Add(this.btnManagmentCourses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnlSearchUsers);
            this.Controls.Add(this.lbGroups);
            this.Name = "FormRelacionesGrupo";
            this.Text = "FormRelacionesGrupo";
            this.Load += new System.EventHandler(this.FormRelacionesGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
            this.pnlSearchUsers.ResumeLayout(false);
            this.pnlSearchUsers.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.bgCoursesGroups.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.GroupBox bgCoursesGroups;
        private System.Windows.Forms.ComboBox cbxGroupsCourses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbGroups;
    }
}