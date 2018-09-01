namespace AutoSchedule
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripAddStudent = new System.Windows.Forms.ToolStripLabel();
            this.toolStripAddBusy = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelGenerateSchedule = new System.Windows.Forms.ToolStripLabel();
            this.showSchedule1 = new AutoSchedule.ShowSchedule();
            this.addStudent1 = new AutoSchedule.AddStudent();
            this.addPotentialDay1 = new AutoSchedule.AddPotentialDay();
            this.toolStripLabelStudentInfo = new System.Windows.Forms.ToolStripLabel();
            this.studentInfo1 = new AutoSchedule.StudentInfo();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddStudent,
            this.toolStripAddBusy,
            this.toolStripLabelGenerateSchedule,
            this.toolStripLabelStudentInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripAddStudent
            // 
            this.toolStripAddStudent.Name = "toolStripAddStudent";
            this.toolStripAddStudent.Size = new System.Drawing.Size(124, 22);
            this.toolStripAddStudent.Text = "Добавление студента";
            this.toolStripAddStudent.Click += new System.EventHandler(this.toolStripAddStudent_Click);
            // 
            // toolStripAddBusy
            // 
            this.toolStripAddBusy.Name = "toolStripAddBusy";
            this.toolStripAddBusy.Size = new System.Drawing.Size(181, 22);
            this.toolStripAddBusy.Text = "Добавление занятости студента";
            this.toolStripAddBusy.Click += new System.EventHandler(this.toolStripAddBusy_Click);
            // 
            // toolStripLabelGenerateSchedule
            // 
            this.toolStripLabelGenerateSchedule.Name = "toolStripLabelGenerateSchedule";
            this.toolStripLabelGenerateSchedule.Size = new System.Drawing.Size(146, 22);
            this.toolStripLabelGenerateSchedule.Text = "Составление расписания";
            this.toolStripLabelGenerateSchedule.Click += new System.EventHandler(this.toolStripLabelGenerateSchedule_Click);
            // 
            // showSchedule1
            // 
            this.showSchedule1.Location = new System.Drawing.Point(12, 28);
            this.showSchedule1.Name = "showSchedule1";
            this.showSchedule1.Size = new System.Drawing.Size(813, 443);
            this.showSchedule1.TabIndex = 7;
            // 
            // addStudent1
            // 
            this.addStudent1.Location = new System.Drawing.Point(12, 28);
            this.addStudent1.Name = "addStudent1";
            this.addStudent1.Size = new System.Drawing.Size(813, 443);
            this.addStudent1.TabIndex = 6;
            // 
            // addPotentialDay1
            // 
            this.addPotentialDay1.Location = new System.Drawing.Point(12, 28);
            this.addPotentialDay1.Name = "addPotentialDay1";
            this.addPotentialDay1.Size = new System.Drawing.Size(813, 443);
            this.addPotentialDay1.TabIndex = 5;
            // 
            // toolStripLabelStudentInfo
            // 
            this.toolStripLabelStudentInfo.Name = "toolStripLabelStudentInfo";
            this.toolStripLabelStudentInfo.Size = new System.Drawing.Size(141, 22);
            this.toolStripLabelStudentInfo.Text = "Информация о студенте";
            this.toolStripLabelStudentInfo.Click += new System.EventHandler(this.toolStripLabelStudentInfo_Click);
            // 
            // studentInfo1
            // 
            this.studentInfo1.Location = new System.Drawing.Point(12, 28);
            this.studentInfo1.Name = "studentInfo1";
            this.studentInfo1.Size = new System.Drawing.Size(813, 458);
            this.studentInfo1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 488);
            this.Controls.Add(this.studentInfo1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.showSchedule1);
            this.Controls.Add(this.addStudent1);
            this.Controls.Add(this.addPotentialDay1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripAddStudent;
        private System.Windows.Forms.ToolStripLabel toolStripAddBusy;
        private AddPotentialDay addPotentialDay1;
        private AddStudent addStudent1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelGenerateSchedule;
        private ShowSchedule showSchedule1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStudentInfo;
        private StudentInfo studentInfo1;
    }
}

