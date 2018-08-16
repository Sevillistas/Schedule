using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutoSchedule
{
    [Serializable]
    public class Student
    {
        public int ID;
        public string FIO;
        public string ClassOfPiano;
        public string LevelOfTraining;
        public List<PotentialDay> PotentialDays = new List<PotentialDay>();
        [XmlIgnore] public bool[,] TablePotentialDays = new bool[5,10]; //5 учебных дней, 10 занятий
        [XmlIgnore] public List<KeyValuePair<int, int>> Indexes = new List<KeyValuePair<int, int>>();
        [XmlIgnore] public List<KeyValuePair<int, int>> UsedIndexes = new List<KeyValuePair<int, int>>();
        public int NumberOfLesson;
        public Student(int id, string fio, string classofpiano, string leveloftraining)
        {
            ID=id;
            FIO = fio;
            ClassOfPiano = classofpiano;
            LevelOfTraining = leveloftraining;
            this.CountNumberOfLesson();
        }
        public Student(string fio, string classofpiano, string leveloftraining)
        {
            FIO = fio;
            ClassOfPiano = classofpiano;
            LevelOfTraining = leveloftraining;
            this.CountNumberOfLesson();
        }
        public Student(string fio)
        {
            FIO = fio;
            this.CountNumberOfLesson();
        }
        public Student()
        {

        }
        public void AddPotentialDay(DayOfWeek dow, string timeofstart, string timeofending)
        {
            PotentialDay bd = new PotentialDay(dow, timeofstart, timeofending);
            PotentialDays.Add(bd);
        }
        public void AddPotentialDay(PotentialDay bd)
        {
            PotentialDays.Add(bd);
        }
        public void CountNumberOfLesson()
        {
            switch(this.ClassOfPiano)
            {
                case "Общий":
                    {
                        NumberOfLesson = 1;
                        break;
                    }
                case "Специальный":
                    {
                        NumberOfLesson = 2;
                        break;
                    }
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Student s = (Student)obj;
            return (FIO == s.FIO) && (ClassOfPiano == s.ClassOfPiano) && (LevelOfTraining == s.LevelOfTraining);// && state;
        }
    }
}
