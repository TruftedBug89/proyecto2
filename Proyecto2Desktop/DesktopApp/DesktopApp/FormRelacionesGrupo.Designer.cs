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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelacionesGrupo));
            this.bindingSourceGroups = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnDeleteRelation = new System.Windows.Forms.Button();
            this.lblDataSelect = new System.Windows.Forms.Label();
            this.lbGroupsHasSkills = new System.Windows.Forms.ListBox();
            this.lblDates = new System.Windows.Forms.Label();
            this.bindingSourceGrupsHasSkills = new System.Windows.Forms.BindingSource(this.components);
            this.pnlGrupsStudTeach = new System.Windows.Forms.Panel();
            this.btnDropStudentsRelation = new System.Windows.Forms.Button();
            this.btnDropTeachersRelation = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblRelationType = new System.Windows.Forms.Label();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTeachers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSourceGrupsHasStudents = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceGroupsHasTeachers = new System.Windows.Forms.BindingSource(this.components);
            this.lbgroups = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnManagmentGroups = new System.Windows.Forms.Button();
            this.bindingSourceListasDeGrupo = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceGruposDeLista = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceAlumnosDeGrupo = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceDocentesDeGrupo = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceGruposDeDocentes = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceGruposDeAlumno = new System.Windows.Forms.BindingSource(this.components);
            this.pnBarra = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListasDeGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruposDeLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlumnosDeGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocentesDeGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruposDeDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruposDeAlumno)).BeginInit();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceGroups
            // 
            this.bindingSourceGroups.DataSource = typeof(DesktopApp.Models.grups);
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
            this.dgvUsers.Location = new System.Drawing.Point(322, 175);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(750, 524);
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
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(593, 723);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(753, 723);
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
            this.cbxCourses.Location = new System.Drawing.Point(565, 116);
            this.cbxCourses.Name = "cbxCourses";
            this.cbxCourses.Size = new System.Drawing.Size(231, 30);
            this.cbxCourses.TabIndex = 41;
            this.cbxCourses.ValueMember = "id";
            this.cbxCourses.SelectedIndexChanged += new System.EventHandler(this.cbxCourses_SelectedIndexChanged);
            // 
            // btnManagmentCourses
            // 
            this.btnManagmentCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagmentCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnManagmentCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentCourses.ForeColor = System.Drawing.Color.Black;
            this.btnManagmentCourses.Location = new System.Drawing.Point(1127, 81);
            this.btnManagmentCourses.Name = "btnManagmentCourses";
            this.btnManagmentCourses.Size = new System.Drawing.Size(184, 45);
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
            this.dgvListSkills.Location = new System.Drawing.Point(322, 175);
            this.dgvListSkills.Name = "dgvListSkills";
            this.dgvListSkills.RowHeadersWidth = 51;
            this.dgvListSkills.RowTemplate.Height = 24;
            this.dgvListSkills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSkills.Size = new System.Drawing.Size(750, 524);
            this.dgvListSkills.TabIndex = 42;
            this.dgvListSkills.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvListSkills_DataBindingComplete);
            this.dgvListSkills.SelectionChanged += new System.EventHandler(this.dgvListSkills_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.pnlGroupsHasSkills.Controls.Add(this.btnDeleteRelation);
            this.pnlGroupsHasSkills.Controls.Add(this.lblDataSelect);
            this.pnlGroupsHasSkills.Controls.Add(this.lbGroupsHasSkills);
            this.pnlGroupsHasSkills.Controls.Add(this.lblDates);
            this.pnlGroupsHasSkills.Location = new System.Drawing.Point(1100, 175);
            this.pnlGroupsHasSkills.Name = "pnlGroupsHasSkills";
            this.pnlGroupsHasSkills.Size = new System.Drawing.Size(259, 524);
            this.pnlGroupsHasSkills.TabIndex = 35;
            // 
            // btnDeleteRelation
            // 
            this.btnDeleteRelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnDeleteRelation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRelation.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteRelation.Location = new System.Drawing.Point(27, 459);
            this.btnDeleteRelation.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRelation.Name = "btnDeleteRelation";
            this.btnDeleteRelation.Size = new System.Drawing.Size(217, 45);
            this.btnDeleteRelation.TabIndex = 50;
            this.btnDeleteRelation.Text = "Eliminar Relacion";
            this.btnDeleteRelation.UseVisualStyleBackColor = false;
            this.btnDeleteRelation.Click += new System.EventHandler(this.btnDeleteRelation_Click);
            // 
            // lblDataSelect
            // 
            this.lblDataSelect.AutoSize = true;
            this.lblDataSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSelect.Location = new System.Drawing.Point(158, 14);
            this.lblDataSelect.Name = "lblDataSelect";
            this.lblDataSelect.Size = new System.Drawing.Size(53, 25);
            this.lblDataSelect.TabIndex = 45;
            this.lblDataSelect.Text = "Dato";
            // 
            // lbGroupsHasSkills
            // 
            this.lbGroupsHasSkills.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbGroupsHasSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGroupsHasSkills.FormattingEnabled = true;
            this.lbGroupsHasSkills.ItemHeight = 22;
            this.lbGroupsHasSkills.Location = new System.Drawing.Point(27, 52);
            this.lbGroupsHasSkills.Name = "lbGroupsHasSkills";
            this.lbGroupsHasSkills.Size = new System.Drawing.Size(217, 400);
            this.lbGroupsHasSkills.TabIndex = 43;
            this.lbGroupsHasSkills.SelectedIndexChanged += new System.EventHandler(this.lbGroupsHasSkills_SelectedIndexChanged);
            this.lbGroupsHasSkills.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lbGroupsHasSkills_Format);
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(42, 14);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(91, 25);
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
            this.pnlGrupsStudTeach.Controls.Add(this.btnDropStudentsRelation);
            this.pnlGrupsStudTeach.Controls.Add(this.btnDropTeachersRelation);
            this.pnlGrupsStudTeach.Controls.Add(this.lblData);
            this.pnlGrupsStudTeach.Controls.Add(this.lblRelationType);
            this.pnlGrupsStudTeach.Controls.Add(this.lbStudents);
            this.pnlGrupsStudTeach.Controls.Add(this.label5);
            this.pnlGrupsStudTeach.Controls.Add(this.lbTeachers);
            this.pnlGrupsStudTeach.Controls.Add(this.label6);
            this.pnlGrupsStudTeach.Location = new System.Drawing.Point(1100, 175);
            this.pnlGrupsStudTeach.Name = "pnlGrupsStudTeach";
            this.pnlGrupsStudTeach.Size = new System.Drawing.Size(259, 602);
            this.pnlGrupsStudTeach.TabIndex = 44;
            // 
            // btnDropStudentsRelation
            // 
            this.btnDropStudentsRelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnDropStudentsRelation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropStudentsRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropStudentsRelation.ForeColor = System.Drawing.Color.Black;
            this.btnDropStudentsRelation.Location = new System.Drawing.Point(36, 550);
            this.btnDropStudentsRelation.Margin = new System.Windows.Forms.Padding(4);
            this.btnDropStudentsRelation.Name = "btnDropStudentsRelation";
            this.btnDropStudentsRelation.Size = new System.Drawing.Size(199, 34);
            this.btnDropStudentsRelation.TabIndex = 52;
            this.btnDropStudentsRelation.Text = "Eliminar Relacion";
            this.btnDropStudentsRelation.UseVisualStyleBackColor = false;
            this.btnDropStudentsRelation.Click += new System.EventHandler(this.btnDropStudentsRelation_Click);
            // 
            // btnDropTeachersRelation
            // 
            this.btnDropTeachersRelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnDropTeachersRelation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropTeachersRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropTeachersRelation.ForeColor = System.Drawing.Color.Black;
            this.btnDropTeachersRelation.Location = new System.Drawing.Point(36, 270);
            this.btnDropTeachersRelation.Margin = new System.Windows.Forms.Padding(4);
            this.btnDropTeachersRelation.Name = "btnDropTeachersRelation";
            this.btnDropTeachersRelation.Size = new System.Drawing.Size(199, 34);
            this.btnDropTeachersRelation.TabIndex = 51;
            this.btnDropTeachersRelation.Text = "Eliminar Relacion";
            this.btnDropTeachersRelation.UseVisualStyleBackColor = false;
            this.btnDropTeachersRelation.Click += new System.EventHandler(this.btnDropTeachersRelation_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(174, 14);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(53, 25);
            this.lblData.TabIndex = 48;
            this.lblData.Text = "Dato";
            // 
            // lblRelationType
            // 
            this.lblRelationType.AutoSize = true;
            this.lblRelationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelationType.Location = new System.Drawing.Point(23, 14);
            this.lblRelationType.Name = "lblRelationType";
            this.lblRelationType.Size = new System.Drawing.Size(111, 25);
            this.lblRelationType.TabIndex = 47;
            this.lblRelationType.Text = "Usuaris de:";
            // 
            // lbStudents
            // 
            this.lbStudents.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 22;
            this.lbStudents.Location = new System.Drawing.Point(36, 363);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbStudents.Size = new System.Drawing.Size(199, 180);
            this.lbStudents.TabIndex = 46;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Alumnos";
            // 
            // lbTeachers
            // 
            this.lbTeachers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTeachers.FormattingEnabled = true;
            this.lbTeachers.ItemHeight = 22;
            this.lbTeachers.Location = new System.Drawing.Point(36, 83);
            this.lbTeachers.Name = "lbTeachers";
            this.lbTeachers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTeachers.Size = new System.Drawing.Size(199, 180);
            this.lbTeachers.TabIndex = 45;
            this.lbTeachers.SelectedIndexChanged += new System.EventHandler(this.lbTeachers_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Docentes";
            // 
            // bindingSourceGrupsHasStudents
            // 
            this.bindingSourceGrupsHasStudents.DataSource = typeof(DesktopApp.Models.grups_has_alumnes);
            // 
            // bindingSourceGroupsHasTeachers
            // 
            this.bindingSourceGroupsHasTeachers.DataSource = typeof(DesktopApp.Models.grups_has_docents);
            // 
            // lbgroups
            // 
            this.lbgroups.BackColor = System.Drawing.Color.White;
            this.lbgroups.DataSource = this.bindingSourceGroups;
            this.lbgroups.DisplayMember = "nom";
            this.lbgroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgroups.FormattingEnabled = true;
            this.lbgroups.ItemHeight = 22;
            this.lbgroups.Location = new System.Drawing.Point(58, 204);
            this.lbgroups.Name = "lbgroups";
            this.lbgroups.Size = new System.Drawing.Size(217, 444);
            this.lbgroups.TabIndex = 46;
            this.lbgroups.ValueMember = "id";
            this.lbgroups.SelectedIndexChanged += new System.EventHandler(this.lbgroups_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Grupos";
            // 
            // btnManagmentGroups
            // 
            this.btnManagmentGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnManagmentGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentGroups.ForeColor = System.Drawing.Color.Black;
            this.btnManagmentGroups.Location = new System.Drawing.Point(58, 658);
            this.btnManagmentGroups.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagmentGroups.Name = "btnManagmentGroups";
            this.btnManagmentGroups.Size = new System.Drawing.Size(217, 45);
            this.btnManagmentGroups.TabIndex = 49;
            this.btnManagmentGroups.Text = "Gestion Grupos";
            this.btnManagmentGroups.UseVisualStyleBackColor = false;
            this.btnManagmentGroups.Click += new System.EventHandler(this.btnManagmentGroups_Click);
            // 
            // bindingSourceListasDeGrupo
            // 
            this.bindingSourceListasDeGrupo.DataSource = typeof(DesktopApp.Models.llistes_skills);
            // 
            // bindingSourceGruposDeLista
            // 
            this.bindingSourceGruposDeLista.DataSource = typeof(DesktopApp.Models.grups);
            // 
            // bindingSourceAlumnosDeGrupo
            // 
            this.bindingSourceAlumnosDeGrupo.DataSource = typeof(DesktopApp.Models.usuaris);
            // 
            // bindingSourceDocentesDeGrupo
            // 
            this.bindingSourceDocentesDeGrupo.DataSource = typeof(DesktopApp.Models.usuaris);
            // 
            // bindingSourceGruposDeDocentes
            // 
            this.bindingSourceGruposDeDocentes.DataSource = typeof(DesktopApp.Models.grups);
            // 
            // bindingSourceGruposDeAlumno
            // 
            this.bindingSourceGruposDeAlumno.DataSource = typeof(DesktopApp.Models.grups);
            // 
            // pnBarra
            // 
            this.pnBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.pnBarra.Controls.Add(this.lbTitulo);
            this.pnBarra.Controls.Add(this.pb_minimize);
            this.pnBarra.Controls.Add(this.pcIcono);
            this.pnBarra.Controls.Add(this.pb_close);
            this.pnBarra.Location = new System.Drawing.Point(0, 0);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(1459, 40);
            this.pnBarra.TabIndex = 50;
            this.pnBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseDown);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTitulo.Location = new System.Drawing.Point(41, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(50, 20);
            this.lbTitulo.TabIndex = 12;
            this.lbTitulo.Text = "Menu";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(1389, 7);
            this.pb_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(25, 25);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minimize.TabIndex = 28;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // pcIcono
            // 
            this.pcIcono.Image = ((System.Drawing.Image)(resources.GetObject("pcIcono.Image")));
            this.pcIcono.Location = new System.Drawing.Point(10, 9);
            this.pcIcono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcIcono.Name = "pcIcono";
            this.pcIcono.Size = new System.Drawing.Size(25, 25);
            this.pcIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcIcono.TabIndex = 13;
            this.pcIcono.TabStop = false;
            this.pcIcono.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcIcono_MouseDown);
            // 
            // pb_close
            // 
            this.pb_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(1420, 7);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 27;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Asignar Cursos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "a las listas seleccionadas";
            // 
            // FormRelacionesGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1457, 789);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCourses);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.btnManagmentGroups);
            this.Controls.Add(this.pnlGrupsStudTeach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbgroups);
            this.Controls.Add(this.pnlGroupsHasSkills);
            this.Controls.Add(this.dgvListSkills);
            this.Controls.Add(this.btnManagmentCourses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelacionesGrupo";
            this.Text = "FormRelacionesGrupo";
            this.Load += new System.EventHandler(this.FormRelacionesGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGroups)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListasDeGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruposDeLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAlumnosDeGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocentesDeGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruposDeDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceGruposDeAlumno)).EndInit();
            this.pnBarra.ResumeLayout(false);
            this.pnBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblDataSelect;
        private System.Windows.Forms.BindingSource bindingSourceCoursesListSkillsUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.ListBox lbgroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnManagmentGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.Button btnDeleteRelation;
        private System.Windows.Forms.Label lblRelationType;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnDropStudentsRelation;
        private System.Windows.Forms.Button btnDropTeachersRelation;
        private System.Windows.Forms.BindingSource bindingSourceListasDeGrupo;
        private System.Windows.Forms.BindingSource bindingSourceGruposDeLista;
        private System.Windows.Forms.BindingSource bindingSourceAlumnosDeGrupo;
        private System.Windows.Forms.BindingSource bindingSourceDocentesDeGrupo;
        private System.Windows.Forms.BindingSource bindingSourceGruposDeDocentes;
        private System.Windows.Forms.BindingSource bindingSourceGruposDeAlumno;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}