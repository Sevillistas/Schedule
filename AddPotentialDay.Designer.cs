namespace AutoSchedule
{
    partial class AddPotentialDay
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelBusy = new System.Windows.Forms.Label();
            this.buttonAcceptBusy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxDayOfWeek = new System.Windows.Forms.ComboBox();
            this.inputTimeOfStart = new System.Windows.Forms.MaskedTextBox();
            this.inputTimeOfEnding = new System.Windows.Forms.MaskedTextBox();
            this.addStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(40, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 32;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(339, 120);
            this.dataGridView1.TabIndex = 7;
            // 
            // labelBusy
            // 
            this.labelBusy.AutoSize = true;
            this.labelBusy.Location = new System.Drawing.Point(37, 89);
            this.labelBusy.Name = "labelBusy";
            this.labelBusy.Size = new System.Drawing.Size(309, 13);
            this.labelBusy.TabIndex = 6;
            this.labelBusy.Text = "Укажите потенциальный день недели и время для занятия";
            // 
            // buttonAcceptBusy
            // 
            this.buttonAcceptBusy.Location = new System.Drawing.Point(272, 114);
            this.buttonAcceptBusy.Name = "buttonAcceptBusy";
            this.buttonAcceptBusy.Size = new System.Drawing.Size(75, 21);
            this.buttonAcceptBusy.TabIndex = 5;
            this.buttonAcceptBusy.Text = "Добавить";
            this.buttonAcceptBusy.UseVisualStyleBackColor = true;
            this.buttonAcceptBusy.Click += new System.EventHandler(this.buttonAcceptBusy_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите студента";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(40, 53);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(242, 21);
            this.comboBoxStudent.TabIndex = 9;
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            this.comboBoxStudent.Click += new System.EventHandler(this.comboBoxStudent_Click);
            // 
            // comboBoxDayOfWeek
            // 
            this.comboBoxDayOfWeek.FormattingEnabled = true;
            this.comboBoxDayOfWeek.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.comboBoxDayOfWeek.Location = new System.Drawing.Point(43, 114);
            this.comboBoxDayOfWeek.Name = "comboBoxDayOfWeek";
            this.comboBoxDayOfWeek.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDayOfWeek.TabIndex = 10;
            // 
            // inputTimeOfStart
            // 
            this.inputTimeOfStart.Location = new System.Drawing.Point(168, 114);
            this.inputTimeOfStart.Mask = "00:00";
            this.inputTimeOfStart.Name = "inputTimeOfStart";
            this.inputTimeOfStart.Size = new System.Drawing.Size(41, 20);
            this.inputTimeOfStart.TabIndex = 13;
            this.inputTimeOfStart.ValidatingType = typeof(System.DateTime);
            // 
            // inputTimeOfEnding
            // 
            this.inputTimeOfEnding.Location = new System.Drawing.Point(215, 114);
            this.inputTimeOfEnding.Mask = "00:00";
            this.inputTimeOfEnding.Name = "inputTimeOfEnding";
            this.inputTimeOfEnding.Size = new System.Drawing.Size(41, 20);
            this.inputTimeOfEnding.TabIndex = 14;
            this.inputTimeOfEnding.ValidatingType = typeof(System.DateTime);
            // 
            // addStudentBindingSource
            // 
            this.addStudentBindingSource.DataSource = typeof(AutoSchedule.AddStudent);
            // 
            // AddPotentialDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputTimeOfEnding);
            this.Controls.Add(this.inputTimeOfStart);
            this.Controls.Add(this.comboBoxDayOfWeek);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelBusy);
            this.Controls.Add(this.buttonAcceptBusy);
            this.Name = "AddPotentialDay";
            this.Size = new System.Drawing.Size(477, 304);
            this.Load += new System.EventHandler(this.AddBusiedDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelBusy;
        private System.Windows.Forms.Button buttonAcceptBusy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.BindingSource addStudentBindingSource;
        private System.Windows.Forms.ComboBox comboBoxDayOfWeek;
        private System.Windows.Forms.MaskedTextBox inputTimeOfStart;
        private System.Windows.Forms.MaskedTextBox inputTimeOfEnding;
    }
}
