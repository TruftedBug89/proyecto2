namespace DesktopApp
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnCloseSesion = new System.Windows.Forms.Button();
            this.btnManagmentKPI = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flpListSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnManagmentSkills = new System.Windows.Forms.Button();
            this.pnlManagmentOptions = new System.Windows.Forms.Panel();
            this.btnManagmentGroups = new System.Windows.Forms.Button();
            this.btnManagmentCourses = new System.Windows.Forms.Button();
            this.btnManagmentRoles = new System.Windows.Forms.Button();
            this.btnGestionUsuarios = new System.Windows.Forms.Button();
            this.pnlButtonKPI = new System.Windows.Forms.Panel();
            this.flpSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnManagmentSkills = new System.Windows.Forms.Button();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.pnBarra = new System.Windows.Forms.Panel();
            this.pb_minimize = new System.Windows.Forms.PictureBox();
            this.pcIcono = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.flpListSkills = new System.Windows.Forms.FlowLayoutPanel();
            this.btnManagmentListSkills = new System.Windows.Forms.Button();
            this.msOpcions = new System.Windows.Forms.MenuStrip();
            this.msSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.flpSkills.SuspendLayout();
            this.pnlManagmentOptions.SuspendLayout();
            this.pnlButtonKPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            this.flpListSkills.SuspendLayout();
            this.msOpcions.SuspendLayout();
            this.SuspendLayout();
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnCloseSesion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1710, 66);
            this.panel1.TabIndex = 0;
            //
            // btnCloseSesion
            //
            this.btnCloseSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSesion.BackColor = System.Drawing.Color.Tomato;
            this.btnCloseSesion.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCloseSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseSesion.ForeColor = System.Drawing.Color.White;
            this.btnCloseSesion.Location = new System.Drawing.Point(952, 46);
            this.btnCloseSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloseSesion.Name = "btnCloseSesion";
            this.btnCloseSesion.Size = new System.Drawing.Size(198, 34);
            this.btnCloseSesion.TabIndex = 0;
            this.btnCloseSesion.Text = "Cerrar Sesión";
            this.btnCloseSesion.UseVisualStyleBackColor = false;
            this.btnCloseSesion.Click += new System.EventHandler(this.btnCloseSesion_Click);
            //
            // btnManagmentKPI
            //
            this.btnManagmentKPI.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnManagmentKPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnManagmentKPI.ForeColor = System.Drawing.Color.White;
            this.btnManagmentKPI.Location = new System.Drawing.Point(1049, 582);
            this.btnManagmentKPI.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagmentKPI.Name = "btnManagmentKPI";
            this.btnManagmentKPI.Size = new System.Drawing.Size(155, 49);
            this.btnManagmentKPI.TabIndex = 5;
            this.btnManagmentKPI.Text = "Gestión KPI";
            this.btnManagmentKPI.UseVisualStyleBackColor = false;
            this.btnManagmentKPI.Visible = false;
            this.btnManagmentKPI.Click += new System.EventHandler(this.btnManagmentKPI_Click);
            //
            // panel4
            //
            this.panel4.Controls.Add(this.flpListSkills);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 66);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1710, 107);
            this.panel4.TabIndex = 7;
            //
            // flpListSkills
            //
            this.flpListSkills.AutoScroll = true;
            this.flpListSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpListSkills.Controls.Add(this.btnManagmentListSkills);
            this.flpListSkills.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpListSkills.Location = new System.Drawing.Point(0, 0);
            this.flpListSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpListSkills.Name = "flpListSkills";
            this.flpListSkills.Size = new System.Drawing.Size(1710, 103);
            this.flpListSkills.TabIndex = 22;
            this.flpListSkills.WrapContents = false;
            //
            // panel5
            //
            this.panel5.Controls.Add(this.flpSkills);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 714);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1710, 130);
            this.panel5.TabIndex = 10;
            //
            // flpSkills
            //
            this.flpSkills.AutoScroll = true;
            this.flpSkills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpSkills.Controls.Add(this.btnManagmentSkills);
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSkills.Location = new System.Drawing.Point(0, 10);
            this.flpSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(1710, 120);
            this.flpSkills.TabIndex = 23;
            this.flpSkills.WrapContents = false;
            //
            // btnManagmentSkills
            //
            this.btnManagmentSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagmentSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagmentSkills.Location = new System.Drawing.Point(14, 16);
            this.btnManagmentSkills.Margin = new System.Windows.Forms.Padding(14, 16, 4, 3);
            this.btnManagmentSkills.Name = "btnManagmentSkills";
            this.btnManagmentSkills.Size = new System.Drawing.Size(131, 70);
            this.btnManagmentSkills.TabIndex = 5;
            this.btnManagmentSkills.Text = "Gestion Skills";
            this.btnManagmentSkills.UseVisualStyleBackColor = false;
            this.btnManagmentSkills.Click += new System.EventHandler(this.btnManagmentSkills_Click);
            //
            // pnlManagmentOptions
            //
            this.pnlManagmentOptions.Controls.Add(this.btnManagmentGroups);
            this.pnlManagmentOptions.Controls.Add(this.btnManagmentCourses);
            this.pnlManagmentOptions.Controls.Add(this.btnManagmentRoles);
            this.pnlManagmentOptions.Controls.Add(this.btnGestionUsuarios);
            this.pnlManagmentOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlManagmentOptions.Location = new System.Drawing.Point(0, 173);
            this.pnlManagmentOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlManagmentOptions.Name = "pnlManagmentOptions";
            this.pnlManagmentOptions.Size = new System.Drawing.Size(204, 541);
            this.pnlManagmentOptions.TabIndex = 13;
            //
            // btnManagmentGroups
            //
            this.btnManagmentGroups.BackColor = System.Drawing.Color.Black;
            this.btnManagmentGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentGroups.ForeColor = System.Drawing.Color.White;
            this.btnManagmentGroups.Location = new System.Drawing.Point(806, 582);
            this.btnManagmentGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManagmentGroups.Name = "btnManagmentGroups";
            this.btnManagmentGroups.Size = new System.Drawing.Size(205, 49);
            this.btnManagmentGroups.TabIndex = 10;
            this.btnManagmentGroups.Text = "Gestion Grupos";
            this.btnManagmentGroups.UseVisualStyleBackColor = false;
            this.btnManagmentGroups.Click += new System.EventHandler(this.btnManagmentGroups_Click);
            //
            // btnManagmentCourses
            //
            this.btnManagmentCourses.BackColor = System.Drawing.Color.Black;
            this.btnManagmentCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentCourses.ForeColor = System.Drawing.Color.White;
            this.btnManagmentCourses.Location = new System.Drawing.Point(590, 582);
            this.btnManagmentCourses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManagmentCourses.Name = "btnManagmentCourses";
            this.btnManagmentCourses.Size = new System.Drawing.Size(181, 49);
            this.btnManagmentCourses.TabIndex = 9;
            this.btnManagmentCourses.Text = "Gestion Cursos";
            this.btnManagmentCourses.UseVisualStyleBackColor = false;
            this.btnManagmentCourses.Click += new System.EventHandler(this.btnManagmentCourses_Click);
            //
            // btnManagmentRoles
            //
            this.btnManagmentRoles.BackColor = System.Drawing.Color.Black;
            this.btnManagmentRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentRoles.ForeColor = System.Drawing.Color.White;
            this.btnManagmentRoles.Location = new System.Drawing.Point(348, 582);
            this.btnManagmentRoles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManagmentRoles.Name = "btnManagmentRoles";
            this.btnManagmentRoles.Size = new System.Drawing.Size(176, 49);
            this.btnManagmentRoles.TabIndex = 8;
            this.btnManagmentRoles.Text = "Gestion Roles";
            this.btnManagmentRoles.UseVisualStyleBackColor = false;
            this.btnManagmentRoles.Click += new System.EventHandler(this.btnManagmentRoles_Click);
            //
            // btnGestionUsuarios
            //
            this.btnGestionUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnGestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGestionUsuarios.Location = new System.Drawing.Point(101, 583);
            this.btnGestionUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGestionUsuarios.Name = "btnGestionUsuarios";
            this.btnGestionUsuarios.Size = new System.Drawing.Size(196, 49);
            this.btnGestionUsuarios.TabIndex = 7;
            this.btnGestionUsuarios.Text = "Gestión Usuarios";
            this.btnGestionUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);
            //
            // pnlButtonKPI
            //
            this.pnlButtonKPI.Controls.Add(this.btnManagmentKPI);
            this.pnlButtonKPI.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonKPI.Location = new System.Drawing.Point(1505, 173);
            this.pnlButtonKPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtonKPI.Name = "pnlButtonKPI";
            this.pnlButtonKPI.Size = new System.Drawing.Size(205, 541);
            this.pnlButtonKPI.TabIndex = 14;
            // flpSkills
            //
            this.flpSkills.AutoScroll = true;
            this.flpSkills.BackColor = System.Drawing.Color.White;
            this.flpSkills.Controls.Add(this.btnManagmentSkills);
            this.flpSkills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpSkills.Location = new System.Drawing.Point(0, 660);
            this.flpSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpSkills.Name = "flpSkills";
            this.flpSkills.Size = new System.Drawing.Size(1403, 120);
            this.flpSkills.TabIndex = 24;
            this.flpSkills.WrapContents = false;
            //
            // btnManagmentSkills
            //
            this.btnManagmentSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagmentSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagmentSkills.Location = new System.Drawing.Point(14, 16);
            this.btnManagmentSkills.Margin = new System.Windows.Forms.Padding(14, 16, 4, 3);
            this.btnManagmentSkills.Name = "btnManagmentSkills";
            this.btnManagmentSkills.Size = new System.Drawing.Size(131, 70);
            this.btnManagmentSkills.TabIndex = 5;
            this.btnManagmentSkills.Text = "Gestion Skills";
            this.btnManagmentSkills.UseVisualStyleBackColor = false;
            //
            // dgvSkill
            //
            this.dgvSkill.AllowUserToAddRows = false;
            this.dgvSkill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Location = new System.Drawing.Point(28, 194);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.ReadOnly = true;
            this.dgvSkill.RowHeadersWidth = 51;
            this.dgvSkill.Size = new System.Drawing.Size(1340, 365);
            this.dgvSkill.TabIndex = 17;
            //
            // pnBarra
            //
            this.pnBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.pnBarra.Controls.Add(this.pb_minimize);
            this.pnBarra.Controls.Add(this.pcIcono);
            this.pnBarra.Controls.Add(this.pb_close);
            this.pnBarra.Controls.Add(this.lbTitulo);
            this.pnBarra.Location = new System.Drawing.Point(0, 0);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(1405, 40);
            this.pnBarra.TabIndex = 25;
            this.pnBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnBarra_MouseDown);
            //
            // pb_minimize
            //
            this.pb_minimize.Image = ((System.Drawing.Image)(resources.GetObject("pb_minimize.Image")));
            this.pb_minimize.Location = new System.Drawing.Point(1335, 9);
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
            this.pb_close.Location = new System.Drawing.Point(1366, 9);
            this.pb_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(25, 25);
            this.pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_close.TabIndex = 27;
            this.pb_close.TabStop = false;
            this.pb_close.Click += new System.EventHandler(this.pb_close_Click);
            //
            // lbTitulo
            //
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(53, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(92, 17);
            this.lbTitulo.TabIndex = 12;
            this.lbTitulo.Text = "Iniciar Sesion";
            this.lbTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitulo_MouseDown);
            //
            // flpListSkills
            //
            this.flpListSkills.AutoScroll = true;
            this.flpListSkills.BackColor = System.Drawing.Color.White;
            this.flpListSkills.Controls.Add(this.btnManagmentListSkills);
            this.flpListSkills.Location = new System.Drawing.Point(0, 92);
            this.flpListSkills.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpListSkills.Name = "flpListSkills";
            this.flpListSkills.Size = new System.Drawing.Size(1606, 98);
            this.flpListSkills.TabIndex = 26;
            this.flpListSkills.WrapContents = false;
            //
            // btnManagmentListSkills
            //
            this.btnManagmentListSkills.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnManagmentListSkills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagmentListSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagmentListSkills.ForeColor = System.Drawing.Color.White;
            this.btnManagmentListSkills.Location = new System.Drawing.Point(12, 9);
            this.btnManagmentListSkills.Margin = new System.Windows.Forms.Padding(12, 9, 4, 2);
            this.btnManagmentListSkills.Name = "btnManagmentListSkills";
            this.btnManagmentListSkills.Size = new System.Drawing.Size(249, 73);
            this.btnManagmentListSkills.TabIndex = 3;
            this.btnManagmentListSkills.Text = "Gestión Lista Skils";
            this.btnManagmentListSkills.UseVisualStyleBackColor = false;
            this.btnManagmentListSkills.Click += new System.EventHandler(this.btnManagmentListSkills_Click_1);
            //
            // msOpcions
            //
            this.msOpcions.BackColor = System.Drawing.Color.Transparent;
            this.msOpcions.Dock = System.Windows.Forms.DockStyle.None;
            this.msOpcions.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.msOpcions.ImageScalingSize = new System.Drawing.Size(50, 20);
            this.msOpcions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSettings,
            this.msFile,
            this.msRecord,
            this.msHelp});
            this.msOpcions.Location = new System.Drawing.Point(0, 40);
            this.msOpcions.Name = "msOpcions";
            this.msOpcions.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msOpcions.Size = new System.Drawing.Size(379, 38);
            this.msOpcions.TabIndex = 28;
            this.msOpcions.Text = "menuStrip1";
            //
            // msSettings
            //
            this.msSettings.BackColor = System.Drawing.Color.DimGray;
            this.msSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.msSettings.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msSettings.Name = "msSettings";
            this.msSettings.Size = new System.Drawing.Size(104, 34);
            this.msSettings.Text = "Settings";
            //
            // msFile
            //
            this.msFile.BackColor = System.Drawing.Color.DimGray;
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToolStripMenuItem,
            this.reloadDataToolStripMenuItem});
            this.msFile.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(60, 34);
            this.msFile.Text = "File";
            //
            // saveDataToolStripMenuItem
            //
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.saveDataToolStripMenuItem.Text = "Save Data";
            //
            // reloadDataToolStripMenuItem
            //
            this.reloadDataToolStripMenuItem.Name = "reloadDataToolStripMenuItem";
            this.reloadDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.reloadDataToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.reloadDataToolStripMenuItem.Text = "Reload Data";
            //
            // msRecord
            //
            this.msRecord.BackColor = System.Drawing.Color.DimGray;
            this.msRecord.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msRecord.Name = "msRecord";
            this.msRecord.Size = new System.Drawing.Size(95, 34);
            this.msRecord.Text = "Record";
            //
            // msHelp
            //
            this.msHelp.BackColor = System.Drawing.Color.DimGray;
            this.msHelp.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(73, 34);
            this.msHelp.Text = "Help";
            //
            // FormPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1403, 780);
            this.Controls.Add(this.msOpcions);
            this.Controls.Add(this.btnManagmentKPI);
            this.Controls.Add(this.flpListSkills);
            this.Controls.Add(this.btnCloseSesion);
            this.Controls.Add(this.pnBarra);
            this.Controls.Add(this.btnManagmentGroups);
            this.Controls.Add(this.btnManagmentCourses);
            this.Controls.Add(this.btnManagmentRoles);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.btnGestionUsuarios);
            this.Controls.Add(this.flpSkills);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Controls.Add(this.pnlButtonKPI);
            this.Controls.Add(this.pnlManagmentOptions);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "566666 ";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.flpSkills.ResumeLayout(false);
            this.pnlManagmentOptions.ResumeLayout(false);
            this.pnlButtonKPI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.pnBarra.ResumeLayout(false);
            this.pnBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            this.flpListSkills.ResumeLayout(false);
            this.msOpcions.ResumeLayout(false);
            this.msOpcions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCloseSesion;
        private System.Windows.Forms.Button btnManagmentKPI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlManagmentOptions;
        private System.Windows.Forms.Button btnGestionUsuarios;
        private System.Windows.Forms.Panel pnlButtonKPI;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.FlowLayoutPanel flpListSkills;
        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.Button btnManagmentSkills;
        private System.Windows.Forms.Button btnManagmentRoles;
        private System.Windows.Forms.Button btnManagmentGroups;
        private System.Windows.Forms.Button btnManagmentCourses;
        private System.Windows.Forms.FlowLayoutPanel flpSkills;
        private System.Windows.Forms.Button btnManagmentSkills;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.FlowLayoutPanel flpListSkills;
        private System.Windows.Forms.Button btnManagmentListSkills;
        private System.Windows.Forms.PictureBox pcIcono;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pb_minimize;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.MenuStrip msOpcions;
        private System.Windows.Forms.ToolStripMenuItem msSettings;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msRecord;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
    }
}
