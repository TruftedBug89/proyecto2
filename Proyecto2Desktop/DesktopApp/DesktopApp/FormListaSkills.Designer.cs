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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaSkills));
            this.lblNameListSkill = new System.Windows.Forms.Label();
            this.txtNameListSkill = new System.Windows.Forms.TextBox();
            this.dgvListaSkills = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGroups = new System.Windows.Forms.ComboBox();
            this.bdCurs = new System.Windows.Forms.BindingSource(this.components);
            this.btnManagmentGroups = new System.Windows.Forms.Button();
            this.cboActivate = new System.Windows.Forms.CheckBox();
            this.btnBuildTable = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.gbGroupsSkill = new System.Windows.Forms.GroupBox();
            this.txtAddNewSkills = new System.Windows.Forms.TextBox();
            this.lblplus = new System.Windows.Forms.Label();
            this.dgvListaNewSkills = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblPlus2 = new System.Windows.Forms.Label();
            this.bindingSourceSkills = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.flpListSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.pnBarra = new System.Windows.Forms.Panel();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCurs)).BeginInit();
            this.gbGroupsSkill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNewSkills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSkills)).BeginInit();
            this.flpListSkills.SuspendLayout();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameListSkill
            // 
            this.lblNameListSkill.AutoSize = true;
            this.lblNameListSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameListSkill.Location = new System.Drawing.Point(65, 191);
            this.lblNameListSkill.Name = "lblNameListSkill";
            this.lblNameListSkill.Size = new System.Drawing.Size(188, 24);
            this.lblNameListSkill.TabIndex = 3;
            this.lblNameListSkill.Text = "Lista de Skills(Siglas):";
            // 
            // txtNameListSkill
            // 
            this.txtNameListSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameListSkill.Location = new System.Drawing.Point(303, 182);
            this.txtNameListSkill.Name = "txtNameListSkill";
            this.txtNameListSkill.Size = new System.Drawing.Size(267, 45);
            this.txtNameListSkill.TabIndex = 4;
            // 
            // dgvListaSkills
            // 
            this.dgvListaSkills.AllowUserToAddRows = false;
            this.dgvListaSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaSkills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvListaSkills.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaSkills.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaSkills.Location = new System.Drawing.Point(69, 250);
            this.dgvListaSkills.Name = "dgvListaSkills";
            this.dgvListaSkills.RowHeadersWidth = 51;
            this.dgvListaSkills.RowTemplate.Height = 24;
            this.dgvListaSkills.Size = new System.Drawing.Size(891, 200);
            this.dgvListaSkills.TabIndex = 7;
            this.dgvListaSkills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaSkills_CellClick);
            this.dgvListaSkills.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaSkills_CellValueChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 40.63752F;
            this.Column1.HeaderText = "Letra";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 155.9785F;
            this.Column2.HeaderText = "Skill";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 137.2569F;
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column3.HeaderText = "Background Color";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 85.91298F;
            this.Column4.HeaderText = "Text Color";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FalseValue = "False";
            this.Column5.FillWeight = 80.21388F;
            this.Column5.HeaderText = "Activar";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.TrueValue = "True";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(1038, 646);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1178, 646);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Grupos:";
            // 
            // cbxGroups
            // 
            this.cbxGroups.DataSource = this.bdCurs;
            this.cbxGroups.DisplayMember = "nom";
            this.cbxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGroups.FormattingEnabled = true;
            this.cbxGroups.Location = new System.Drawing.Point(120, 39);
            this.cbxGroups.Name = "cbxGroups";
            this.cbxGroups.Size = new System.Drawing.Size(133, 30);
            this.cbxGroups.TabIndex = 17;
            this.cbxGroups.ValueMember = "id";
            this.cbxGroups.SelectedIndexChanged += new System.EventHandler(this.cbxGroups_SelectedIndexChanged);
            // 
            // bdCurs
            // 
            this.bdCurs.DataSource = typeof(DesktopApp.Models.grups);
            // 
            // btnManagmentGroups
            // 
            this.btnManagmentGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnManagmentGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentGroups.ForeColor = System.Drawing.Color.Black;
            this.btnManagmentGroups.Location = new System.Drawing.Point(23, 103);
            this.btnManagmentGroups.Name = "btnManagmentGroups";
            this.btnManagmentGroups.Size = new System.Drawing.Size(230, 42);
            this.btnManagmentGroups.TabIndex = 18;
            this.btnManagmentGroups.Text = "Relaciones Grupos";
            this.btnManagmentGroups.UseVisualStyleBackColor = false;
            this.btnManagmentGroups.Click += new System.EventHandler(this.btnManagmentGroups_Click);
            // 
            // cboActivate
            // 
            this.cboActivate.Appearance = System.Windows.Forms.Appearance.Button;
            this.cboActivate.BackColor = System.Drawing.SystemColors.ControlText;
            this.cboActivate.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.Checked = true;
            this.cboActivate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboActivate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cboActivate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.cboActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboActivate.ForeColor = System.Drawing.Color.White;
            this.cboActivate.Location = new System.Drawing.Point(1161, 178);
            this.cboActivate.Name = "cboActivate";
            this.cboActivate.Size = new System.Drawing.Size(112, 49);
            this.cboActivate.TabIndex = 20;
            this.cboActivate.Text = "Activar";
            this.cboActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.UseVisualStyleBackColor = false;
            // 
            // btnBuildTable
            // 
            this.btnBuildTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.btnBuildTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuildTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildTable.ForeColor = System.Drawing.Color.Black;
            this.btnBuildTable.Location = new System.Drawing.Point(819, 185);
            this.btnBuildTable.Name = "btnBuildTable";
            this.btnBuildTable.Size = new System.Drawing.Size(141, 42);
            this.btnBuildTable.TabIndex = 33;
            this.btnBuildTable.Text = "Añadir Skills";
            this.btnBuildTable.UseVisualStyleBackColor = false;
            this.btnBuildTable.Click += new System.EventHandler(this.btnBuildTable_Click);
            // 
            // gbGroupsSkill
            // 
            this.gbGroupsSkill.Controls.Add(this.label1);
            this.gbGroupsSkill.Controls.Add(this.cbxGroups);
            this.gbGroupsSkill.Controls.Add(this.btnManagmentGroups);
            this.gbGroupsSkill.Location = new System.Drawing.Point(990, 250);
            this.gbGroupsSkill.Name = "gbGroupsSkill";
            this.gbGroupsSkill.Size = new System.Drawing.Size(283, 175);
            this.gbGroupsSkill.TabIndex = 34;
            this.gbGroupsSkill.TabStop = false;
            this.gbGroupsSkill.Text = "Grupos de Skill";
            // 
            // txtAddNewSkills
            // 
            this.txtAddNewSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNewSkills.Location = new System.Drawing.Point(620, 182);
            this.txtAddNewSkills.Name = "txtAddNewSkills";
            this.txtAddNewSkills.Size = new System.Drawing.Size(185, 45);
            this.txtAddNewSkills.TabIndex = 35;
            this.txtAddNewSkills.Visible = false;
            // 
            // lblplus
            // 
            this.lblplus.AutoSize = true;
            this.lblplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplus.Location = new System.Drawing.Point(576, 185);
            this.lblplus.Name = "lblplus";
            this.lblplus.Size = new System.Drawing.Size(38, 39);
            this.lblplus.TabIndex = 36;
            this.lblplus.Text = "+";
            this.lblplus.Visible = false;
            // 
            // dgvListaNewSkills
            // 
            this.dgvListaNewSkills.AllowUserToAddRows = false;
            this.dgvListaNewSkills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaNewSkills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaNewSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaNewSkills.ColumnHeadersVisible = false;
            this.dgvListaNewSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewButtonColumn1,
            this.dataGridViewButtonColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.dgvListaNewSkills.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaNewSkills.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListaNewSkills.Location = new System.Drawing.Point(69, 496);
            this.dgvListaNewSkills.Name = "dgvListaNewSkills";
            this.dgvListaNewSkills.RowHeadersWidth = 51;
            this.dgvListaNewSkills.RowTemplate.Height = 24;
            this.dgvListaNewSkills.Size = new System.Drawing.Size(891, 118);
            this.dgvListaNewSkills.TabIndex = 37;
            this.dgvListaNewSkills.Visible = false;
            this.dgvListaNewSkills.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaNewSkills_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.FillWeight = 40.63752F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Letra";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 155.9785F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Skill";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.FillWeight = 137.2569F;
            this.dataGridViewButtonColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewButtonColumn1.HeaderText = "Background Color";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            this.dataGridViewButtonColumn2.FillWeight = 85.91298F;
            this.dataGridViewButtonColumn2.HeaderText = "Text Color";
            this.dataGridViewButtonColumn2.MinimumWidth = 6;
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "False";
            this.dataGridViewCheckBoxColumn1.FillWeight = 80.21388F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Activar";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "True";
            // 
            // lblPlus2
            // 
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus2.Location = new System.Drawing.Point(507, 454);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(38, 39);
            this.lblPlus2.TabIndex = 38;
            this.lblPlus2.Text = "+";
            this.lblPlus2.Visible = false;
            // 
            // bindingSourceSkills
            // 
            this.bindingSourceSkills.DataSource = typeof(DesktopApp.Models.skills);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
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
            this.flpListSkills.Location = new System.Drawing.Point(0, 40);
            this.flpListSkills.Name = "flpListSkills";
            this.flpListSkills.Size = new System.Drawing.Size(1315, 105);
            this.flpListSkills.TabIndex = 39;
            this.flpListSkills.WrapContents = false;
            // 
            // pnBarra
            // 
            this.pnBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.pnBarra.Controls.Add(this.pcIcono);
            this.pnBarra.Controls.Add(this.pb_close);
            this.pnBarra.Controls.Add(this.lbTitulo);
            this.pnBarra.Controls.Add(this.pb_minimize);
            this.pnBarra.Location = new System.Drawing.Point(0, 0);
            this.pnBarra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(1315, 40);
            this.pnBarra.TabIndex = 8;
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
            // pb_close
            // 
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(1280, 10);
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
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(41, 12);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(89, 20);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Lista skills";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            // 
            // pb_minimize
            // 
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(1248, 9);
            this.pb_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_minimize.Name = "pb_minimize";
            this.pb_minimize.Size = new System.Drawing.Size(25, 25);
            this.pb_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_minimize.TabIndex = 9;
            this.pb_minimize.TabStop = false;
            this.pb_minimize.Click += new System.EventHandler(this.pb_minimize_Click);
            // 
            // FormListaSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1315, 701);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.lblPlus2);
            this.Controls.Add(this.dgvListaNewSkills);
            this.Controls.Add(this.lblplus);
            this.Controls.Add(this.txtAddNewSkills);
            this.Controls.Add(this.gbGroupsSkill);
            this.Controls.Add(this.btnBuildTable);
            this.Controls.Add(this.flpListSkills);
            this.Controls.Add(this.cboActivate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvListaSkills);
            this.Controls.Add(this.txtNameListSkill);
            this.Controls.Add(this.lblNameListSkill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaSkills";
            this.Text = "FormListaSkills";
            this.Load += new System.EventHandler(this.FormListaSkills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdCurs)).EndInit();
            this.gbGroupsSkill.ResumeLayout(false);
            this.gbGroupsSkill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNewSkills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSkills)).EndInit();
            this.flpListSkills.ResumeLayout(false);
            this.pnBarra.ResumeLayout(false);
            this.pnBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceSkills;
        private System.Windows.Forms.CheckBox cboActivate;
        private System.Windows.Forms.Button btnBuildTable;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox gbGroupsSkill;
        private System.Windows.Forms.TextBox txtAddNewSkills;
        private System.Windows.Forms.Label lblplus;
        private System.Windows.Forms.DataGridView dgvListaNewSkills;
        private System.Windows.Forms.Label lblPlus2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpListSkills;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.BindingSource bdCurs;
    }
}
