namespace CourseWork
{
    partial class FormMenu
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
            this.imgSettings = new System.Windows.Forms.PictureBox();
            this.mbcAircraft = new CourseWork.menuBoxControl();
            this.mbcInstructor = new CourseWork.menuBoxControl();
            this.mbcStudent = new CourseWork.menuBoxControl();
            this.mbcLogs = new CourseWork.menuBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.imgSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSettings
            // 
            this.imgSettings.Image = global::CourseWork.Properties.Resources.iconSettings;
            this.imgSettings.Location = new System.Drawing.Point(799, 12);
            this.imgSettings.Name = "imgSettings";
            this.imgSettings.Size = new System.Drawing.Size(50, 50);
            this.imgSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSettings.TabIndex = 4;
            this.imgSettings.TabStop = false;
            this.imgSettings.Click += new System.EventHandler(this.imgSettings_Click);
            // 
            // mbcAircraft
            // 
            this.mbcAircraft.Icon = global::CourseWork.Properties.Resources.iconFlight;
            this.mbcAircraft.Location = new System.Drawing.Point(647, 82);
            this.mbcAircraft.Name = "mbcAircraft";
            this.mbcAircraft.Size = new System.Drawing.Size(208, 257);
            this.mbcAircraft.TabIndex = 3;
            this.mbcAircraft.Title = "Aircraft";
            // 
            // mbcInstructor
            // 
            this.mbcInstructor.Icon = global::CourseWork.Properties.Resources.iconInstructor;
            this.mbcInstructor.Location = new System.Drawing.Point(219, 82);
            this.mbcInstructor.Name = "mbcInstructor";
            this.mbcInstructor.Size = new System.Drawing.Size(208, 257);
            this.mbcInstructor.TabIndex = 2;
            this.mbcInstructor.Title = "CFI\'s";
            // 
            // mbcStudent
            // 
            this.mbcStudent.Icon = global::CourseWork.Properties.Resources.iconStudent;
            this.mbcStudent.Location = new System.Drawing.Point(433, 82);
            this.mbcStudent.Name = "mbcStudent";
            this.mbcStudent.Size = new System.Drawing.Size(208, 257);
            this.mbcStudent.TabIndex = 1;
            this.mbcStudent.Title = "Students";
            // 
            // mbcLogs
            // 
            this.mbcLogs.Icon = global::CourseWork.Properties.Resources.iconLogs;
            this.mbcLogs.Location = new System.Drawing.Point(5, 82);
            this.mbcLogs.Name = "mbcLogs";
            this.mbcLogs.Size = new System.Drawing.Size(208, 257);
            this.mbcLogs.TabIndex = 0;
            this.mbcLogs.Title = "Logs";
            this.mbcLogs.Click += new System.EventHandler(this.mbcLogs_Click);
            // 
            // FormMenu
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 441);
            this.Controls.Add(this.imgSettings);
            this.Controls.Add(this.mbcAircraft);
            this.Controls.Add(this.mbcInstructor);
            this.Controls.Add(this.mbcStudent);
            this.Controls.Add(this.mbcLogs);
            this.Name = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.imgSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private menuBoxControl mbcLogs;
        private menuBoxControl mbcStudent;
        private menuBoxControl mbcInstructor;
        private menuBoxControl mbcAircraft;
        private System.Windows.Forms.PictureBox imgSettings;
    }
}

