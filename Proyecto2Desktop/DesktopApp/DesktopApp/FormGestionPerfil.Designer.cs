
namespace DesktopApp
{
    partial class FormGestionPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPerfil));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelNombrePerfil = new System.Windows.Forms.Label();
            this.tbPerfilName = new System.Windows.Forms.TextBox();
            this.labelPermisos = new System.Windows.Forms.Label();
            this.ckbAllPermision = new System.Windows.Forms.CheckBox();
            this.ckbEmptyPermision = new System.Windows.Forms.CheckBox();
            this.groupBoxPermisos = new System.Windows.Forms.GroupBox();
            this.ckbGroupGestion = new System.Windows.Forms.CheckBox();
            this.ckbPerfilGestion = new System.Windows.Forms.CheckBox();
            this.ckbUsersGestion = new System.Windows.Forms.CheckBox();
            this.ckbSkillsGestion = new System.Windows.Forms.CheckBox();
            this.ckbListSkilsGestion = new System.Windows.Forms.CheckBox();
            this.ckbKPIGestion = new System.Windows.Forms.CheckBox();
            this.pnBarra = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gestionarKPIsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gestionarListaSkillsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gestionarSkillsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gestionarUsuariosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gestionarPerfilesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gestionarGruposDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRols = new System.Windows.Forms.BindingSource(this.components);
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbActiu = new System.Windows.Forms.CheckBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.ckbManagmentCourses = new System.Windows.Forms.CheckBox();
            this.cxbRelationsGroups = new System.Windows.Forms.CheckBox();
            this.groupBoxPermisos.SuspendLayout();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRols)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombrePerfil
            // 
            this.labelNombrePerfil.AutoSize = true;
            this.labelNombrePerfil.Location = new System.Drawing.Point(337, 103);
            this.labelNombrePerfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombrePerfil.Name = "labelNombrePerfil";
            this.labelNombrePerfil.Size = new System.Drawing.Size(94, 17);
            this.labelNombrePerfil.TabIndex = 1;
            this.labelNombrePerfil.Text = "Nombre Perfil";
            // 
            // tbPerfilName
            // 
            this.tbPerfilName.Location = new System.Drawing.Point(458, 98);
            this.tbPerfilName.Margin = new System.Windows.Forms.Padding(4);
            this.tbPerfilName.Name = "tbPerfilName";
            this.tbPerfilName.Size = new System.Drawing.Size(545, 22);
            this.tbPerfilName.TabIndex = 2;
            // 
            // labelPermisos
            // 
            this.labelPermisos.AutoSize = true;
            this.labelPermisos.Location = new System.Drawing.Point(339, 172);
            this.labelPermisos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPermisos.Name = "labelPermisos";
            this.labelPermisos.Size = new System.Drawing.Size(70, 17);
            this.labelPermisos.TabIndex = 3;
            this.labelPermisos.Text = "Permisos:";
            // 
            // ckbAllPermision
            // 
            this.ckbAllPermision.AutoSize = true;
            this.ckbAllPermision.Location = new System.Drawing.Point(458, 169);
            this.ckbAllPermision.Margin = new System.Windows.Forms.Padding(4);
            this.ckbAllPermision.Name = "ckbAllPermision";
            this.ckbAllPermision.Size = new System.Drawing.Size(148, 21);
            this.ckbAllPermision.TabIndex = 4;
            this.ckbAllPermision.Text = "Seleccionar Todos";
            this.ckbAllPermision.UseVisualStyleBackColor = true;
            this.ckbAllPermision.CheckedChanged += new System.EventHandler(this.ckbAllPermision_CheckedChanged);
            // 
            // ckbEmptyPermision
            // 
            this.ckbEmptyPermision.AutoSize = true;
            this.ckbEmptyPermision.Location = new System.Drawing.Point(721, 169);
            this.ckbEmptyPermision.Margin = new System.Windows.Forms.Padding(4);
            this.ckbEmptyPermision.Name = "ckbEmptyPermision";
            this.ckbEmptyPermision.Size = new System.Drawing.Size(114, 21);
            this.ckbEmptyPermision.TabIndex = 5;
            this.ckbEmptyPermision.Text = "Vaciar Todos";
            this.ckbEmptyPermision.UseVisualStyleBackColor = true;
            this.ckbEmptyPermision.CheckedChanged += new System.EventHandler(this.ckbEmptyPermision_CheckedChanged);
            // 
            // groupBoxPermisos
            // 
            this.groupBoxPermisos.Controls.Add(this.cxbRelationsGroups);
            this.groupBoxPermisos.Controls.Add(this.ckbManagmentCourses);
            this.groupBoxPermisos.Controls.Add(this.ckbGroupGestion);
            this.groupBoxPermisos.Controls.Add(this.ckbPerfilGestion);
            this.groupBoxPermisos.Controls.Add(this.ckbUsersGestion);
            this.groupBoxPermisos.Controls.Add(this.ckbSkillsGestion);
            this.groupBoxPermisos.Controls.Add(this.ckbListSkilsGestion);
            this.groupBoxPermisos.Controls.Add(this.ckbKPIGestion);
            this.groupBoxPermisos.Location = new System.Drawing.Point(338, 226);
            this.groupBoxPermisos.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPermisos.Name = "groupBoxPermisos";
            this.groupBoxPermisos.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPermisos.Size = new System.Drawing.Size(700, 155);
            this.groupBoxPermisos.TabIndex = 6;
            this.groupBoxPermisos.TabStop = false;
            this.groupBoxPermisos.Text = "groupBoxPermisos";
            // 
            // ckbGroupGestion
            // 
            this.ckbGroupGestion.AutoSize = true;
            this.ckbGroupGestion.Location = new System.Drawing.Point(383, 97);
            this.ckbGroupGestion.Margin = new System.Windows.Forms.Padding(4);
            this.ckbGroupGestion.Name = "ckbGroupGestion";
            this.ckbGroupGestion.Size = new System.Drawing.Size(143, 21);
            this.ckbGroupGestion.TabIndex = 5;
            this.ckbGroupGestion.Text = "Gestionar Grupos";
            this.ckbGroupGestion.UseVisualStyleBackColor = true;
            // 
            // ckbPerfilGestion
            // 
            this.ckbPerfilGestion.AutoSize = true;
            this.ckbPerfilGestion.Location = new System.Drawing.Point(210, 97);
            this.ckbPerfilGestion.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPerfilGestion.Name = "ckbPerfilGestion";
            this.ckbPerfilGestion.Size = new System.Drawing.Size(143, 21);
            this.ckbPerfilGestion.TabIndex = 4;
            this.ckbPerfilGestion.Text = "Gestionar Perfiles";
            this.ckbPerfilGestion.UseVisualStyleBackColor = true;
            // 
            // ckbUsersGestion
            // 
            this.ckbUsersGestion.AutoSize = true;
            this.ckbUsersGestion.Location = new System.Drawing.Point(32, 97);
            this.ckbUsersGestion.Margin = new System.Windows.Forms.Padding(4);
            this.ckbUsersGestion.Name = "ckbUsersGestion";
            this.ckbUsersGestion.Size = new System.Drawing.Size(152, 21);
            this.ckbUsersGestion.TabIndex = 3;
            this.ckbUsersGestion.Text = "Gestionar Usuarios";
            this.ckbUsersGestion.UseVisualStyleBackColor = true;
            // 
            // ckbSkillsGestion
            // 
            this.ckbSkillsGestion.AutoSize = true;
            this.ckbSkillsGestion.Location = new System.Drawing.Point(383, 30);
            this.ckbSkillsGestion.Margin = new System.Windows.Forms.Padding(4);
            this.ckbSkillsGestion.Name = "ckbSkillsGestion";
            this.ckbSkillsGestion.Size = new System.Drawing.Size(128, 21);
            this.ckbSkillsGestion.TabIndex = 2;
            this.ckbSkillsGestion.Text = "Gestionar Skills";
            this.ckbSkillsGestion.UseVisualStyleBackColor = true;
            // 
            // ckbListSkilsGestion
            // 
            this.ckbListSkilsGestion.AutoSize = true;
            this.ckbListSkilsGestion.Location = new System.Drawing.Point(210, 30);
            this.ckbListSkilsGestion.Margin = new System.Windows.Forms.Padding(4);
            this.ckbListSkilsGestion.Name = "ckbListSkilsGestion";
            this.ckbListSkilsGestion.Size = new System.Drawing.Size(162, 21);
            this.ckbListSkilsGestion.TabIndex = 1;
            this.ckbListSkilsGestion.Text = "Gestionar Lista Skills";
            this.ckbListSkilsGestion.UseVisualStyleBackColor = true;
            // 
            // ckbKPIGestion
            // 
            this.ckbKPIGestion.AutoSize = true;
            this.ckbKPIGestion.Location = new System.Drawing.Point(32, 30);
            this.ckbKPIGestion.Margin = new System.Windows.Forms.Padding(4);
            this.ckbKPIGestion.Name = "ckbKPIGestion";
            this.ckbKPIGestion.Size = new System.Drawing.Size(124, 21);
            this.ckbKPIGestion.TabIndex = 0;
            this.ckbKPIGestion.Text = "Gestionar KPIs";
            this.ckbKPIGestion.UseVisualStyleBackColor = true;
            // 
            // pnBarra
            // 
            this.pnBarra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnBarra.Controls.Add(this.pbMinimize);
            this.pnBarra.Controls.Add(this.pbClose);
            this.pnBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarra.Location = new System.Drawing.Point(0, 0);
            this.pnBarra.Margin = new System.Windows.Forms.Padding(4);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(1067, 44);
            this.pnBarra.TabIndex = 7;
            this.pnBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseDown);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(978, 3);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(27, 33);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMinimize.TabIndex = 1;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1011, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(27, 33);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = "-";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.actiuDataGridViewCheckBoxColumn,
            this.gestionarKPIsDataGridViewCheckBoxColumn,
            this.gestionarListaSkillsDataGridViewCheckBoxColumn,
            this.gestionarSkillsDataGridViewCheckBoxColumn,
            this.gestionarUsuariosDataGridViewCheckBoxColumn,
            this.gestionarPerfilesDataGridViewCheckBoxColumn,
            this.gestionarGruposDataGridViewCheckBoxColumn,
            this.usuarisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bsRols;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(278, 285);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // actiuDataGridViewCheckBoxColumn
            // 
            this.actiuDataGridViewCheckBoxColumn.DataPropertyName = "actiu";
            this.actiuDataGridViewCheckBoxColumn.HeaderText = "actiu";
            this.actiuDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.actiuDataGridViewCheckBoxColumn.Name = "actiuDataGridViewCheckBoxColumn";
            this.actiuDataGridViewCheckBoxColumn.ReadOnly = true;
            this.actiuDataGridViewCheckBoxColumn.Width = 125;
            // 
            // gestionarKPIsDataGridViewCheckBoxColumn
            // 
            this.gestionarKPIsDataGridViewCheckBoxColumn.DataPropertyName = "GestionarKPIs";
            this.gestionarKPIsDataGridViewCheckBoxColumn.HeaderText = "GestionarKPIs";
            this.gestionarKPIsDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gestionarKPIsDataGridViewCheckBoxColumn.Name = "gestionarKPIsDataGridViewCheckBoxColumn";
            this.gestionarKPIsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gestionarKPIsDataGridViewCheckBoxColumn.Visible = false;
            this.gestionarKPIsDataGridViewCheckBoxColumn.Width = 125;
            // 
            // gestionarListaSkillsDataGridViewCheckBoxColumn
            // 
            this.gestionarListaSkillsDataGridViewCheckBoxColumn.DataPropertyName = "GestionarListaSkills";
            this.gestionarListaSkillsDataGridViewCheckBoxColumn.HeaderText = "GestionarListaSkills";
            this.gestionarListaSkillsDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gestionarListaSkillsDataGridViewCheckBoxColumn.Name = "gestionarListaSkillsDataGridViewCheckBoxColumn";
            this.gestionarListaSkillsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gestionarListaSkillsDataGridViewCheckBoxColumn.Visible = false;
            this.gestionarListaSkillsDataGridViewCheckBoxColumn.Width = 125;
            // 
            // gestionarSkillsDataGridViewCheckBoxColumn
            // 
            this.gestionarSkillsDataGridViewCheckBoxColumn.DataPropertyName = "GestionarSkills";
            this.gestionarSkillsDataGridViewCheckBoxColumn.HeaderText = "GestionarSkills";
            this.gestionarSkillsDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gestionarSkillsDataGridViewCheckBoxColumn.Name = "gestionarSkillsDataGridViewCheckBoxColumn";
            this.gestionarSkillsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gestionarSkillsDataGridViewCheckBoxColumn.Visible = false;
            this.gestionarSkillsDataGridViewCheckBoxColumn.Width = 125;
            // 
            // gestionarUsuariosDataGridViewCheckBoxColumn
            // 
            this.gestionarUsuariosDataGridViewCheckBoxColumn.DataPropertyName = "GestionarUsuarios";
            this.gestionarUsuariosDataGridViewCheckBoxColumn.HeaderText = "GestionarUsuarios";
            this.gestionarUsuariosDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gestionarUsuariosDataGridViewCheckBoxColumn.Name = "gestionarUsuariosDataGridViewCheckBoxColumn";
            this.gestionarUsuariosDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gestionarUsuariosDataGridViewCheckBoxColumn.Visible = false;
            this.gestionarUsuariosDataGridViewCheckBoxColumn.Width = 125;
            // 
            // gestionarPerfilesDataGridViewCheckBoxColumn
            // 
            this.gestionarPerfilesDataGridViewCheckBoxColumn.DataPropertyName = "GestionarPerfiles";
            this.gestionarPerfilesDataGridViewCheckBoxColumn.HeaderText = "GestionarPerfiles";
            this.gestionarPerfilesDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gestionarPerfilesDataGridViewCheckBoxColumn.Name = "gestionarPerfilesDataGridViewCheckBoxColumn";
            this.gestionarPerfilesDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gestionarPerfilesDataGridViewCheckBoxColumn.Visible = false;
            this.gestionarPerfilesDataGridViewCheckBoxColumn.Width = 125;
            // 
            // gestionarGruposDataGridViewCheckBoxColumn
            // 
            this.gestionarGruposDataGridViewCheckBoxColumn.DataPropertyName = "GestionarGrupos";
            this.gestionarGruposDataGridViewCheckBoxColumn.HeaderText = "GestionarGrupos";
            this.gestionarGruposDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.gestionarGruposDataGridViewCheckBoxColumn.Name = "gestionarGruposDataGridViewCheckBoxColumn";
            this.gestionarGruposDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gestionarGruposDataGridViewCheckBoxColumn.Visible = false;
            this.gestionarGruposDataGridViewCheckBoxColumn.Width = 125;
            // 
            // usuarisDataGridViewTextBoxColumn
            // 
            this.usuarisDataGridViewTextBoxColumn.DataPropertyName = "usuaris";
            this.usuarisDataGridViewTextBoxColumn.HeaderText = "usuaris";
            this.usuarisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarisDataGridViewTextBoxColumn.Name = "usuarisDataGridViewTextBoxColumn";
            this.usuarisDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarisDataGridViewTextBoxColumn.Visible = false;
            this.usuarisDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsRols
            // 
            this.bsRols.DataSource = typeof(DesktopApp.Models.rols);
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Location = new System.Drawing.Point(466, 474);
            this.buttonIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(115, 28);
            this.buttonIniciarSesion.TabIndex = 9;
            this.buttonIniciarSesion.Text = "Guardar";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ckbActiu
            // 
            this.ckbActiu.AutoSize = true;
            this.ckbActiu.Location = new System.Drawing.Point(351, 401);
            this.ckbActiu.Margin = new System.Windows.Forms.Padding(4);
            this.ckbActiu.Name = "ckbActiu";
            this.ckbActiu.Size = new System.Drawing.Size(61, 21);
            this.ckbActiu.TabIndex = 6;
            this.ckbActiu.Text = "Actiu";
            this.ckbActiu.UseVisualStyleBackColor = true;
            this.ckbActiu.Visible = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(356, 477);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(53, 25);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "+";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ckbManagmentCourses
            // 
            this.ckbManagmentCourses.AutoSize = true;
            this.ckbManagmentCourses.Location = new System.Drawing.Point(549, 30);
            this.ckbManagmentCourses.Margin = new System.Windows.Forms.Padding(4);
            this.ckbManagmentCourses.Name = "ckbManagmentCourses";
            this.ckbManagmentCourses.Size = new System.Drawing.Size(140, 21);
            this.ckbManagmentCourses.TabIndex = 6;
            this.ckbManagmentCourses.Text = "Gestionar Cursos";
            this.ckbManagmentCourses.UseVisualStyleBackColor = true;
            // 
            // cxbRelationsGroups
            // 
            this.cxbRelationsGroups.AutoSize = true;
            this.cxbRelationsGroups.Location = new System.Drawing.Point(549, 97);
            this.cxbRelationsGroups.Margin = new System.Windows.Forms.Padding(4);
            this.cxbRelationsGroups.Name = "cxbRelationsGroups";
            this.cxbRelationsGroups.Size = new System.Drawing.Size(149, 21);
            this.cxbRelationsGroups.TabIndex = 7;
            this.cxbRelationsGroups.Text = "Relacionar Grupos";
            this.cxbRelationsGroups.UseVisualStyleBackColor = true;
            // 
            // FormGestionPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.ckbActiu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIniciarSesion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.groupBoxPermisos);
            this.Controls.Add(this.ckbEmptyPermision);
            this.Controls.Add(this.ckbAllPermision);
            this.Controls.Add(this.labelPermisos);
            this.Controls.Add(this.tbPerfilName);
            this.Controls.Add(this.labelNombrePerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGestionPerfil";
            this.Text = "FormGestionPerfil";
            this.Load += new System.EventHandler(this.FormGestionPerfil_Load);
            this.groupBoxPermisos.ResumeLayout(false);
            this.groupBoxPermisos.PerformLayout();
            this.pnBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNombrePerfil;
        private System.Windows.Forms.TextBox tbPerfilName;
        private System.Windows.Forms.Label labelPermisos;
        private System.Windows.Forms.CheckBox ckbAllPermision;
        private System.Windows.Forms.CheckBox ckbEmptyPermision;
        private System.Windows.Forms.GroupBox groupBoxPermisos;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.CheckBox ckbGroupGestion;
        private System.Windows.Forms.CheckBox ckbPerfilGestion;
        private System.Windows.Forms.CheckBox ckbUsersGestion;
        private System.Windows.Forms.CheckBox ckbSkillsGestion;
        private System.Windows.Forms.CheckBox ckbListSkilsGestion;
        private System.Windows.Forms.CheckBox ckbKPIGestion;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsRols;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn actiuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gestionarKPIsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gestionarListaSkillsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gestionarSkillsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gestionarUsuariosDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gestionarPerfilesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gestionarGruposDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarisDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox ckbActiu;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.CheckBox cxbRelationsGroups;
        private System.Windows.Forms.CheckBox ckbManagmentCourses;
    }
}