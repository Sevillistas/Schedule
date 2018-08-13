using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace AutoSchedule
{
    public partial class AddPotentialDay : UserControl
    {
        //Для подгрузки и обработки xml-БД

        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
        XmlDocument xmlDocument = new XmlDocument();
        Students students = new Students();
        List<Student> listComboBox = new List<Student>();

        string path = @"C:\Users\Aleks\Documents\Visual Studio 2017\Projects\AutoSchedule\AutoSchedule\database.xml";

        public AddPotentialDay()
        {
            InitializeComponent();
            //CheckXml(); //Доделать
            DeserializeXml();
            InitializeComboBoxCollection();
            CreatingTable();
        }
        public void InitializeComboBoxCollection()
        {
            listComboBox = students.ListOfStudents;
            foreach (var st in listComboBox)
            {
                comboBoxStudent.Items.Add(st.FIO);
            }
        }
        private void DeserializeXml()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                students.ListOfStudents = (List<Student>)serializer.Deserialize(fs);
            }
        }

        private void CheckXml()
        {
            /*using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                xmlDocument.Load(fs);
            }*/
        }

        private void SerializeXml()
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, students.ListOfStudents);
            }
        }
        private void UpdateListFIO()
        {
            DeserializeXml();
            foreach(var student in students.ListOfStudents)
            {
                if (!listComboBox.Contains(student))
                {
                    comboBoxStudent.Items.Add(student.FIO);
                    listComboBox.Add(student);
                }
            }
        }
        private void CreatingTable()
        {
            dataGridView1.AllowUserToAddRows=false;
            //dataGridView1.Width = 332;

            var column1 = new DataGridViewColumn();
            column1.HeaderText = "День недели";
            column1.Name = "DayOfWeek";
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Начало временного интервала";
            column2.Name = "TimeOfStart";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Конец временного интервала";
            column3.Name = "TimeOfEnding";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);

            var sumWidth = 32; //Ширина заголовка строки
            var sumHeigth = 32;
            dataGridView1.ColumnHeadersHeight = 32; //Высота заголовка колонки

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = 120;
                sumWidth += col.Width;
            }
            dataGridView1.Width = sumWidth;
        }

        private void buttonAcceptBusy_Click_1(object sender, EventArgs e)
        {
            var selectedStudent = students.ListOfStudents.Find(x => x.FIO.Contains(Convert.ToString(comboBoxStudent.SelectedItem)));

            var potentialDay = comboBoxDayOfWeek.SelectedItem;
            var potentialTimeOfStart = inputTimeOfStart.Text;
            var potentialTimeOfEnding = inputTimeOfEnding.Text;

            switch (potentialDay)
            {
                case "Понедельник":
                    {
                        PotentialDay bd = new PotentialDay(DayOfWeek.Monday, potentialTimeOfStart, potentialTimeOfEnding);
                        selectedStudent.AddPotentialDay(bd);
                        break;
                    }
                case "Вторник":
                    {
                        PotentialDay bd = new PotentialDay(DayOfWeek.Tuesday, potentialTimeOfStart, potentialTimeOfEnding);
                        selectedStudent.AddPotentialDay(bd);
                        break;
                    }
                case "Среда":
                    {
                        PotentialDay bd = new PotentialDay(DayOfWeek.Wednesday, potentialTimeOfStart, potentialTimeOfEnding);
                        selectedStudent.AddPotentialDay(bd);
                        break;
                    }
                case "Четверг":
                    {
                        PotentialDay bd = new PotentialDay(DayOfWeek.Thursday, potentialTimeOfStart, potentialTimeOfEnding);
                        selectedStudent.AddPotentialDay(bd);
                        break;
                    }
                case "Пятница":
                    {
                        PotentialDay bd = new PotentialDay(DayOfWeek.Friday, potentialTimeOfStart, potentialTimeOfEnding);
                        selectedStudent.AddPotentialDay(bd);
                        break;
                    }
                case "Суббота":
                    {
                        PotentialDay bd = new PotentialDay(DayOfWeek.Saturday, potentialTimeOfStart, potentialTimeOfEnding);
                        selectedStudent.AddPotentialDay(bd);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            var dgr = new DataGridViewRow();
            var bdS = selectedStudent.PotentialDays; //Занятые дни выбранного студента
            if (bdS.Count != 0)
            {
                switch (bdS[bdS.Count-1].DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        {
                            dataGridView1.Rows.Add("Понедельник", bdS[bdS.Count - 1].TimeOfStart, bdS[bdS.Count - 1].TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Tuesday:
                        {
                            dataGridView1.Rows.Add("Вторник", bdS[bdS.Count - 1].TimeOfStart, bdS[bdS.Count - 1].TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Wednesday:
                        {
                            dataGridView1.Rows.Add("Среда", bdS[bdS.Count - 1].TimeOfStart, bdS[bdS.Count - 1].TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Thursday:
                        {
                            dataGridView1.Rows.Add("Четверг", bdS[bdS.Count - 1].TimeOfStart, bdS[bdS.Count - 1].TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Friday:
                        {
                            dataGridView1.Rows.Add("Пятница", bdS[bdS.Count - 1].TimeOfStart, bdS[bdS.Count - 1].TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Saturday:
                        {
                            dataGridView1.Rows.Add("Суббота", bdS[bdS.Count - 1].TimeOfStart, bdS[bdS.Count - 1].TimeOfEnding);
                            break;
                        }
                }
            }
            SerializeXml();
        }

        private void AddBusiedDay_Load(object sender, EventArgs e)
        {
            //Добавление в комбо-бокс существующих учеников из xml-БД
            UpdateListFIO();
        }

        private void comboBoxStudent_Click(object sender, EventArgs e)
        {
            //Обновление данных комбобокса
            UpdateListFIO();
        }

        private void comboBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedStudent = students.ListOfStudents.Find(x => x.FIO.Contains(Convert.ToString(comboBoxStudent.SelectedItem)));
            dataGridView1.Rows.Clear();
            foreach(var day in selectedStudent.PotentialDays)
            {
                switch(day.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        {
                            dataGridView1.Rows.Add("Понедельник", day.TimeOfStart, day.TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Tuesday:
                        {
                            dataGridView1.Rows.Add("Вторник", day.TimeOfStart, day.TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Wednesday:
                        {
                            dataGridView1.Rows.Add("Среда", day.TimeOfStart, day.TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Thursday:
                        {
                            dataGridView1.Rows.Add("Четверг", day.TimeOfStart, day.TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Friday:
                        {
                            dataGridView1.Rows.Add("Пятница", day.TimeOfStart, day.TimeOfEnding);
                            break;
                        }
                    case DayOfWeek.Saturday:
                        {
                            dataGridView1.Rows.Add("Суббота", day.TimeOfStart, day.TimeOfEnding);
                            break;
                        }
                }
            }
        }
    }
}
