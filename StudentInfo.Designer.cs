namespace AutoSchedule
{
    partial class StudentInfo
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.comboBoxFIO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClassPiano = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLevelTrain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPotentialDays = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUsedPotentialDays = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNumberOfLessons = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLessonsLeft = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(68, 67);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(131, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "Фамилия и имя ученика";
            // 
            // comboBoxFIO
            // 
            this.comboBoxFIO.FormattingEnabled = true;
            this.comboBoxFIO.Location = new System.Drawing.Point(68, 83);
            this.comboBoxFIO.Name = "comboBoxFIO";
            this.comboBoxFIO.Size = new System.Drawing.Size(180, 21);
            this.comboBoxFIO.TabIndex = 1;
            this.comboBoxFIO.SelectedIndexChanged += new System.EventHandler(this.comboBoxFIO_SelectedIndexChanged);
            this.comboBoxFIO.MouseHover += new System.EventHandler(this.comboBoxFIO_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Класс фортепиано";
            // 
            // textBoxClassPiano
            // 
            this.textBoxClassPiano.Location = new System.Drawing.Point(68, 123);
            this.textBoxClassPiano.Name = "textBoxClassPiano";
            this.textBoxClassPiano.Size = new System.Drawing.Size(180, 20);
            this.textBoxClassPiano.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Уровень подготовки";
            // 
            // textBoxLevelTrain
            // 
            this.textBoxLevelTrain.Location = new System.Drawing.Point(68, 164);
            this.textBoxLevelTrain.Name = "textBoxLevelTrain";
            this.textBoxLevelTrain.Size = new System.Drawing.Size(180, 20);
            this.textBoxLevelTrain.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Класс";
            // 
            // textBoxForm
            // 
            this.textBoxForm.Location = new System.Drawing.Point(68, 203);
            this.textBoxForm.Name = "textBoxForm";
            this.textBoxForm.Size = new System.Drawing.Size(99, 20);
            this.textBoxForm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Потенциальные дни";
            // 
            // comboBoxPotentialDays
            // 
            this.comboBoxPotentialDays.FormattingEnabled = true;
            this.comboBoxPotentialDays.Location = new System.Drawing.Point(341, 80);
            this.comboBoxPotentialDays.Name = "comboBoxPotentialDays";
            this.comboBoxPotentialDays.Size = new System.Drawing.Size(172, 21);
            this.comboBoxPotentialDays.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Назначенные дни";
            // 
            // comboBoxUsedPotentialDays
            // 
            this.comboBoxUsedPotentialDays.FormattingEnabled = true;
            this.comboBoxUsedPotentialDays.Location = new System.Drawing.Point(342, 151);
            this.comboBoxUsedPotentialDays.Name = "comboBoxUsedPotentialDays";
            this.comboBoxUsedPotentialDays.Size = new System.Drawing.Size(170, 21);
            this.comboBoxUsedPotentialDays.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество уроков в неделю";
            // 
            // textBoxNumberOfLessons
            // 
            this.textBoxNumberOfLessons.Location = new System.Drawing.Point(68, 247);
            this.textBoxNumberOfLessons.Name = "textBoxNumberOfLessons";
            this.textBoxNumberOfLessons.Size = new System.Drawing.Size(99, 20);
            this.textBoxNumberOfLessons.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Количество неназначенных уроков";
            // 
            // textBoxLessonsLeft
            // 
            this.textBoxLessonsLeft.Location = new System.Drawing.Point(68, 304);
            this.textBoxLessonsLeft.Name = "textBoxLessonsLeft";
            this.textBoxLessonsLeft.Size = new System.Drawing.Size(99, 20);
            this.textBoxLessonsLeft.TabIndex = 15;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxLessonsLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNumberOfLessons);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxUsedPotentialDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPotentialDays);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLevelTrain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxClassPiano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Name = "StudentInfo";
            this.Size = new System.Drawing.Size(569, 376);
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.ComboBox comboBoxFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClassPiano;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLevelTrain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPotentialDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUsedPotentialDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNumberOfLessons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLessonsLeft;
    }
}
