using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace AutoSchedule
{
    public partial class StudentInfo : UserControl
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
        Students students;

        string path = @"C:\Users\Aleks\Documents\Visual Studio 2017\Projects\AutoSchedule\AutoSchedule\database.xml";
        public StudentInfo()
        {
            InitializeComponent();
            InitializeComboBoxFIOCollection();
        }
        private void DeserializeXml()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                students=new Students((List<Student>)serializer.Deserialize(fs));
            }
        }

        public void InitializeComboBoxFIOCollection()
        {
            DeserializeXml();
            foreach (var st in students.ListOfStudents)
            {
                if (!comboBoxFIO.Items.Contains(st.FIO))
                {
                    comboBoxFIO.Items.Add(st.FIO);
                }
            }
        }

        public void InitializeComboBoxPotentialDaysCollection(Student selectedStudent)
        {
            foreach (var pd in selectedStudent.Indexes)
            {
                StringBuilder sb = new StringBuilder();
                int day = pd.Key;
                switch(day)
                {
                    case 0:
                        {
                            sb.Append("Понедельник");
                            break;
                        }
                    case 1:
                        {
                            sb.Append("Вторник");
                            break;
                        }
                    case 2:
                        {
                            sb.Append("Среда");
                            break;
                        }
                    case 3:
                        {
                            sb.Append("Четверг");
                            break;
                        }
                    case 4:
                        {
                            sb.Append("Пятница");
                            break;
                        }
                }
                int time = pd.Value;
                switch(time)
                //"8:30", "9:20", "10:10", "13:30", "14:20", "15:10", "16:00", "16:50", "17:40", "18:30"
                {
                    case 0:
                        {
                            sb.Append(" 08:30");
                            break;
                        }
                    case 1:
                        {
                            sb.Append(" 09:20");
                            break;
                        }
                    case 2:
                        {
                            sb.Append(" 10:10");
                            break;
                        }
                    case 3:
                        {
                            sb.Append(" 13:30");
                            break;
                        }
                    case 4:
                        {
                            sb.Append(" 14:20");
                            break;
                        }
                    case 5:
                        {
                            sb.Append(" 15:10");
                            break;
                        }
                    case 6:
                        {
                            sb.Append(" 16:00");
                            break;
                        }
                    case 7:
                        {
                            sb.Append(" 16:50");
                            break;
                        }
                    case 8:
                        {
                            sb.Append(" 17:40");
                            break;
                        }
                    case 9:
                        {
                            sb.Append(" 18:30");
                            break;
                        }
                }
                if (!comboBoxPotentialDays.Items.Contains(sb.ToString()))
                {
                    comboBoxPotentialDays.Items.Add(sb.ToString());
                }
            }
        }

        public void InitializeComboBoxUsedPotentialDaysCollection(Student selectedStudent)
        {
            foreach (var pd in selectedStudent.DaysOfLessons)
            {
                StringBuilder sb = new StringBuilder();
                int day = pd.Key;
                switch (day)
                {
                    case 0:
                        {
                            sb.Append("Понедельник");
                            break;
                        }
                    case 1:
                        {
                            sb.Append("Вторник");
                            break;
                        }
                    case 2:
                        {
                            sb.Append("Среда");
                            break;
                        }
                    case 3:
                        {
                            sb.Append("Четверг");
                            break;
                        }
                    case 4:
                        {
                            sb.Append("Пятница");
                            break;
                        }
                }
                int time = pd.Value;
                switch (time)
                //"8:30", "9:20", "10:10", "13:30", "14:20", "15:10", "16:00", "16:50", "17:40", "18:30"
                {
                    case 0:
                        {
                            sb.Append(" 08:30");
                            break;
                        }
                    case 1:
                        {
                            sb.Append(" 09:20");
                            break;
                        }
                    case 2:
                        {
                            sb.Append(" 10:10");
                            break;
                        }
                    case 3:
                        {
                            sb.Append(" 13:30");
                            break;
                        }
                    case 4:
                        {
                            sb.Append(" 14:20");
                            break;
                        }
                    case 5:
                        {
                            sb.Append(" 15:10");
                            break;
                        }
                    case 6:
                        {
                            sb.Append(" 16:00");
                            break;
                        }
                    case 7:
                        {
                            sb.Append(" 16:50");
                            break;
                        }
                    case 8:
                        {
                            sb.Append(" 17:40");
                            break;
                        }
                    case 9:
                        {
                            sb.Append(" 18:30");
                            break;
                        }
                }
                if (!comboBoxUsedPotentialDays.Items.Contains(sb.ToString()))
                {
                    comboBoxUsedPotentialDays.Items.Add(sb.ToString());
                }
            }
        }

        private void comboBoxFIO_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student selectedStudent = students.ListOfStudents.Find(s => s.FIO.Contains(comboBoxFIO.SelectedItem.ToString()));
            comboBoxPotentialDays.Items.Clear();
            comboBoxUsedPotentialDays.Items.Clear();
            textBoxClassPiano.Text = selectedStudent.ClassOfPiano;
            textBoxLevelTrain.Text = selectedStudent.LevelOfTraining;
            textBoxForm.Text = selectedStudent.Form.ToString();
            InitializeComboBoxPotentialDaysCollection(selectedStudent);
            InitializeComboBoxUsedPotentialDaysCollection(selectedStudent);
            textBoxNumberOfLessons.Text = selectedStudent.NumberOfLessons.ToString();
            textBoxLessonsLeft.Text = (selectedStudent.NumberOfLessons - selectedStudent.DaysOfLessons.Count).ToString();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            //InitializeComboBoxFIOCollection();
        }

        private void comboBoxFIO_MouseHover(object sender, EventArgs e)
        {
            InitializeComboBoxFIOCollection();
            GeneratorOfSchedule gen = new GeneratorOfSchedule(students);
        }
    }
}
