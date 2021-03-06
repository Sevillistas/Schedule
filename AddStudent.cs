﻿using System;
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
using System.Xml;

namespace AutoSchedule
{
    public partial class AddStudent : UserControl
    {

        Students studs;
        GeneratorOfSchedule generator;
        string path = "C:\\Users\\Aleks\\Documents\\Visual Studio 2017\\Projects\\AutoSchedule\\AutoSchedule\\database.xml";
        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

        public AddStudent()
        {
            InitializeComponent();
        }
        private void SerializeXml()
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fs, studs.ListOfStudents);
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            Student s = new Student(textBoxFIO.Text, comboBoxClassPiano.Text, comboBoxLevelTrain.Text, int.Parse(comboBoxForm.Text));
            
            s.ID = studs.ListOfStudents.Count + 1; //Присваивание ID новому студенту
            studs.AddStudent(s);
            SerializeXml();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        { 
            using (XmlReader xmlRead = new XmlTextReader(path))
            {
                if (serializer.CanDeserialize(xmlRead))
                {
                    xmlRead.Dispose();
                    xmlRead.Close();
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        studs = new Students((List<Student>)serializer.Deserialize(fs));
                    }
                }
            }
            SerializeXml();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //
        }
    }
}
