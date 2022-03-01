namespace DesktopApp
{
    partial class FormCursos
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
            this.lblCourses = new System.Windows.Forms.Label();
            this.dtpStartCourse = new System.Windows.Forms.DateTimePicker();
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.gbStartCourse = new System.Windows.Forms.GroupBox();
            this.gbFinishCourse = new System.Windows.Forms.GroupBox();
            this.dtpFinishCourse = new System.Windows.Forms.DateTimePicker();
            this.cboActivate = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbStartCourse.SuspendLayout();
            this.gbFinishCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.Location = new System.Drawing.Point(278, 19);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(75, 24);
            this.lblCourses.TabIndex = 4;
            this.lblCourses.Text = "Cursos";
            // 
            // dtpStartCourse
            // 
            this.dtpStartCourse.CustomFormat = "yyyy";
            this.dtpStartCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartCourse.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartCourse.Location = new System.Drawing.Point(20, 35);
            this.dtpStartCourse.Name = "dtpStartCourse";
            this.dtpStartCourse.Size = new System.Drawing.Size(78, 28);
            this.dtpStartCourse.TabIndex = 5;
            // 
            // lbCourses
            // 
            this.lbCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.ItemHeight = 22;
            this.lbCourses.Location = new System.Drawing.Point(12, 55);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(159, 268);
            this.lbCourses.TabIndex = 6;
            // 
            // gbStartCourse
            // 
            this.gbStartCourse.Controls.Add(this.dtpStartCourse);
            this.gbStartCourse.Location = new System.Drawing.Point(194, 57);
            this.gbStartCourse.Name = "gbStartCourse";
            this.gbStartCourse.Size = new System.Drawing.Size(181, 112);
            this.gbStartCourse.TabIndex = 7;
            this.gbStartCourse.TabStop = false;
            this.gbStartCourse.Text = "Curs Inici";
            // 
            // gbFinishCourse
            // 
            this.gbFinishCourse.Controls.Add(this.dtpFinishCourse);
            this.gbFinishCourse.Location = new System.Drawing.Point(385, 57);
            this.gbFinishCourse.Name = "gbFinishCourse";
            this.gbFinishCourse.Size = new System.Drawing.Size(183, 112);
            this.gbFinishCourse.TabIndex = 8;
            this.gbFinishCourse.TabStop = false;
            this.gbFinishCourse.Text = "Curs Final";
            // 
            // dtpFinishCourse
            // 
            this.dtpFinishCourse.CustomFormat = "yyyy";
            this.dtpFinishCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinishCourse.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinishCourse.Location = new System.Drawing.Point(20, 35);
            this.dtpFinishCourse.Name = "dtpFinishCourse";
            this.dtpFinishCourse.Size = new System.Drawing.Size(78, 28);
            this.dtpFinishCourse.TabIndex = 5;
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
            this.cboActivate.Location = new System.Drawing.Point(327, 205);
            this.cboActivate.Name = "cboActivate";
            this.cboActivate.Size = new System.Drawing.Size(106, 41);
            this.cboActivate.TabIndex = 21;
            this.cboActivate.Text = "Activar";
            this.cboActivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboActivate.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(174, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 42);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(304, 391);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 42);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 445);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboActivate);
            this.Controls.Add(this.gbFinishCourse);
            this.Controls.Add(this.gbStartCourse);
            this.Controls.Add(this.lbCourses);
            this.Controls.Add(this.lblCourses);
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.Load += new System.EventHandler(this.FormCursos_Load);
            this.gbStartCourse.ResumeLayout(false);
            this.gbFinishCourse.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.DateTimePicker dtpStartCourse;
        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.GroupBox gbStartCourse;
        private System.Windows.Forms.GroupBox gbFinishCourse;
        private System.Windows.Forms.DateTimePicker dtpFinishCourse;
        private System.Windows.Forms.CheckBox cboActivate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}