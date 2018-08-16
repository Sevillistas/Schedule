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
    public partial class ShowSchedule : UserControl
    {
        public static string[] DaysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница" };
        string path = "C:\\Users\\Aleks\\Documents\\Visual Studio 2017\\Projects\\AutoSchedule\\AutoSchedule\\database.xml";

        Students students;
        GeneratorOfSchedule generator;
        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

        public ShowSchedule()
        {
            InitializeComponent();
            DeserializeXml();
            CreatingTable();
            FillingTable();
        }
        public void CreatingTable()
        {
            dataGridView1.Rows.Add(5);
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = DaysOfWeek[i];
            }
        }
        private void DeserializeXml()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                students = new Students((List<Student>)serializer.Deserialize(fs));
            }
        }
        private void SerializeXml()
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, students.ListOfStudents);
            }
        }

        public void FillingTable()
        {
            generator = new GeneratorOfSchedule(students);
            generator.FillCalendarOfBusyness();
            for(int i=0;i<generator.CalendarOfBusyness.GetLength(0);i++)
            {
                for (int j = 0; j < generator.CalendarOfBusyness.GetLength(1); j++)
                {
                    dataGridView1[j, i].Value = Convert.ToString(generator.StudentTimeTable[i,j].Value);
                }
            }
        }
    }
}
