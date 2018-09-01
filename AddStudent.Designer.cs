namespace AutoSchedule
{
    partial class AddStudent
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
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelLevelOfSkills = new System.Windows.Forms.Label();
            this.labelClassOfPiano = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.comboBoxClassPiano = new System.Windows.Forms.ComboBox();
            this.comboBoxLevelTrain = new System.Windows.Forms.ComboBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(51, 64);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(172, 20);
            this.textBoxFIO.TabIndex = 9;
            // 
            // labelLevelOfSkills
            // 
            this.labelLevelOfSkills.AutoSize = true;
            this.labelLevelOfSkills.Location = new System.Drawing.Point(48, 159);
            this.labelLevelOfSkills.Name = "labelLevelOfSkills";
            this.labelLevelOfSkills.Size = new System.Drawing.Size(162, 13);
            this.labelLevelOfSkills.TabIndex = 8;
            this.labelLevelOfSkills.Text = "Выберите уровень подготовки";
            // 
            // labelClassOfPiano
            // 
            this.labelClassOfPiano.AutoSize = true;
            this.labelClassOfPiano.Location = new System.Drawing.Point(48, 99);
            this.labelClassOfPiano.Name = "labelClassOfPiano";
            this.labelClassOfPiano.Size = new System.Drawing.Size(154, 13);
            this.labelClassOfPiano.TabIndex = 7;
            this.labelClassOfPiano.Text = "Выберите класс фортепиано";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(48, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(175, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Введите фамилию и имя ученика";
            // 
            // comboBoxClassPiano
            // 
            this.comboBoxClassPiano.FormattingEnabled = true;
            this.comboBoxClassPiano.Items.AddRange(new object[] {
            "Общий",
            "Специальный"});
            this.comboBoxClassPiano.Location = new System.Drawing.Point(51, 115);
            this.comboBoxClassPiano.Name = "comboBoxClassPiano";
            this.comboBoxClassPiano.Size = new System.Drawing.Size(172, 21);
            this.comboBoxClassPiano.TabIndex = 10;
            // 
            // comboBoxLevelTrain
            // 
            this.comboBoxLevelTrain.FormattingEnabled = true;
            this.comboBoxLevelTrain.Items.AddRange(new object[] {
            "Общеразвивающий",
            "Пред.профессиональный"});
            this.comboBoxLevelTrain.Location = new System.Drawing.Point(51, 175);
            this.comboBoxLevelTrain.Name = "comboBoxLevelTrain";
            this.comboBoxLevelTrain.Size = new System.Drawing.Size(172, 21);
            this.comboBoxLevelTrain.TabIndex = 11;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(278, 202);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(85, 33);
            this.buttonAddStudent.TabIndex = 12;
            this.buttonAddStudent.Text = "Добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxForm.Location = new System.Drawing.Point(51, 228);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(172, 21);
            this.comboBoxForm.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выберите класс ученика";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.comboBoxLevelTrain);
            this.Controls.Add(this.comboBoxClassPiano);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelLevelOfSkills);
            this.Controls.Add(this.labelClassOfPiano);
            this.Controls.Add(this.labelName);
            this.Name = "AddStudent";
            this.Size = new System.Drawing.Size(426, 280);
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelLevelOfSkills;
        private System.Windows.Forms.Label labelClassOfPiano;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox comboBoxClassPiano;
        private System.Windows.Forms.ComboBox comboBoxLevelTrain;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.ComboBox comboBoxForm;
        private System.Windows.Forms.Label label1;
    }
}
