using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSchedule
{
    class GeneratorOfSchedule
    {
        /*
        public const int LastLessonMorning = 620;
        public const int LastTimeMorning = 660;
        public const int FirstTimeAN = 840;
        public const int FirstLessonAN = 880;
        */

        public const int NumberOfWorkdays = 5;
        public const int MaxNumberOfLessons = 10;
        public const int LastMorningLesson = 610;
        public const int EndFirstANLesson = 860;
        public const int FirstANLesson = 810;
        public const int DurationOfLesson = 50;

        /*public string[,] Calendar = { { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
                               { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
                               { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
                               { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
                               { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
        };*/

        public string[,] Calendar = { { "8:30", "9:20", "10:10", "13:30", "14:20", "15:10", "16:00", "16:50", "17:40", "18:30"},
                                      { "8:30", "9:20", "10:10", "13:30", "14:20", "15:10", "16:00", "16:50", "17:40", "18:30"},
                                      { "8:30", "9:20", "10:10", "13:30", "14:20", "15:10", "16:00", "16:50", "17:40", "18:30"},
                                      { "8:30", "9:20", "10:10", "13:30", "14:20", "15:10", "16:00", "16:50", "17:40", "18:30"},
                                      { "8:30", "9:20", "10:10", "13:30", "14:20", "15:10", "16:00", "16:50", "17:40", "18:30"},
        };
        public bool[,] CalendarOfBusyness = new bool[NumberOfWorkdays, MaxNumberOfLessons];

        public int[,] CalendarMinutes;

        public Students students;

        public List<int> series = new List<int>();

        public List<int> shuffledSeries = new List<int>();

        public List<int> TimesOfLessons = new List<int>() { 510, 560, 610, 810, 860, 910, 960, 1010, 1060, 1110 };

        public KeyValuePair<string, string>[,] StudentTimeTable = new KeyValuePair<string, string>[NumberOfWorkdays, MaxNumberOfLessons];

        //public List<int> TimesOfLessons = new List<int>() { 500, 540, 580, 620, 840, 880, 920, 960, 1000, 1040, 1080, 1120 };

        //public KeyValuePair<string, string>[,] DlyaMamy = new KeyValuePair<string, string>[5, 12];

        public GeneratorOfSchedule(Students st)
        {
            CalendarMinutes = new int[Calendar.GetLength(0), Calendar.GetLength(1)];
            students = st;
            FillCalendarMinutes();
            CreateSeriesOfStudents();
            CreateTableForStudents();
            CreateIndexesForStudents();
            ShuffleStudents();
        }
        public int CheckDayOfWeek(PotentialDay pd)
        {
            int day = 7;
            switch (pd.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    {
                        day = (int)DayOfWeek.Monday - 1;
                        break;
                    }
                case DayOfWeek.Tuesday:
                    {
                        day = (int)DayOfWeek.Tuesday - 1;
                        break;
                    }
                case DayOfWeek.Wednesday:
                    {
                        day = (int)DayOfWeek.Wednesday - 1;
                        break;
                    }
                case DayOfWeek.Thursday:
                    {
                        day = (int)DayOfWeek.Thursday - 1;
                        break;
                    }
                case DayOfWeek.Friday:
                    {
                        day = (int)DayOfWeek.Friday - 1;
                        break;
                    }
                case DayOfWeek.Saturday:
                    {
                        day = (int)DayOfWeek.Saturday - 1;
                        break;
                    }
            }
            return day;
        }

        public int ConvertStringTimeToMinutes(string timeofstart)
        {
            var tOS = timeofstart.Split(':'); //OS - OfStart h - hours m - minutes
            int hOS = int.Parse(tOS[0]);
            int mOS = int.Parse(tOS[1]);
            return hOS * 60 + mOS;
        }

        public int CountNumberOfLessonsBetweenTimes(PotentialDay pd)
        {
            int timeOS = ConvertStringTimeToMinutes(pd.TimeOfStart);
            int timeOE = ConvertStringTimeToMinutes(pd.TimeOfEnding);
            int difference = 0;
            if (timeOS > LastMorningLesson && timeOE < EndFirstANLesson)
            {
                return 0;
            }
            if (timeOS <= LastMorningLesson && timeOE >= FirstANLesson)
            {
                difference = 660 - timeOS; //660=11:00 //60 min s utra
                difference += (timeOE - FirstANLesson);
            }
            else if ((timeOS > LastMorningLesson && timeOS <= FirstANLesson) && timeOE >= FirstANLesson)
            {
                timeOS = FirstANLesson;
                difference = timeOE - timeOS;
            }
            else
            {
                difference = timeOE - timeOS;
            }
            int countLessons = difference / DurationOfLesson; //50 минут длится урок
            return countLessons;
        }

        public void CreateSeriesOfStudents()
        {
            foreach (Student s in students.ListOfStudents)
            {
                for (int i = 0; i < s.NumberOfLesson; i++)
                {
                    series.Add(s.ID);
                }
            }
        }

        public void CreateTableForStudents()
        {
            int day = 0;
            int nOL = 0; //numberOfLessons
            int eTOL = 0; //earliestTimeOfLesson

            foreach (Student s in students.ListOfStudents)
            {
                bool[,] Table = new bool[NumberOfWorkdays, MaxNumberOfLessons];
                foreach (PotentialDay pd in s.PotentialDays)
                {
                    day = CheckDayOfWeek(pd);
                    nOL = CountNumberOfLessonsBetweenTimes(pd);
                    eTOL = FindEarliestTimeOfLesson(pd);
                    while (nOL != 0)
                    {
                        Table[day, eTOL] = true;
                        eTOL++;
                        nOL--;
                    }
                }
                s.TablePotentialDays = Table;
            }
        }

        public void CreateIndexesForStudents()
        {
            foreach(Student s in students.ListOfStudents)
            {
                List<KeyValuePair<int, int>> indexes = new List<KeyValuePair<int, int>>();
                for (int i = 0; i < s.TablePotentialDays.GetLength(0); i++)
                {
                    for (int j = 0; j < s.TablePotentialDays.GetLength(1); j++)
                    {
                        if (s.TablePotentialDays[i,j]==true)
                        {
                            indexes.Add(new KeyValuePair<int, int>(i, j));
                        }
                    }
                }
                s.Indexes = indexes;
            }
        }

        public void FillCalendarMinutes()
        {
            for (int i = 0; i < CalendarMinutes.GetLength(0); i++)
            {
                for (int j = 0; j < CalendarMinutes.GetLength(1); j++)
                {
                    CalendarMinutes[i, j] = ConvertStringTimeToMinutes(Calendar[i, j]);
                }
            }
        }

        public void FillCalendarOfBusyness()
        {
            Random rnd = new Random();
            for (int i = 0; i < shuffledSeries.Count; i++)
            {
                bool success = false;
                Student s = students.ListOfStudents.Find(st => st.ID == shuffledSeries[i]);
                if(s.Indexes.Count==0) //если у студента нет уроков
                {
                    continue;
                }
                List<KeyValuePair<int, int>> buf = new List<KeyValuePair<int, int>>();
                buf.AddRange(s.Indexes);
                while (success != true && buf.Count!=0)
                {
                    int rndindex = rnd.Next(0, buf.Count);
                    KeyValuePair<int, int> dayAndTime = buf[rndindex];
                    if (!CalendarOfBusyness[dayAndTime.Key, dayAndTime.Value] & s.TablePotentialDays[dayAndTime.Key, dayAndTime.Value])
                    {
                        if(s.UsedIndexes.Exists(v=>v.Key==dayAndTime.Key))
                        {
                            buf.RemoveAt(rndindex);
                            continue;
                        }
                        CalendarOfBusyness[dayAndTime.Key, dayAndTime.Value] = true;
                        s.UsedIndexes.Add(dayAndTime);
                        KeyValuePair<string, string> dm = new KeyValuePair<string, string>(Calendar[dayAndTime.Key, dayAndTime.Value], s.FIO);
                        StudentTimeTable[dayAndTime.Key, dayAndTime.Value] = dm;
                        success = true;
                    }
                    else
                    {
                        buf.RemoveAt(rndindex);
                    }
                }
            }
        }

        public int FindEarliestTimeOfLesson(PotentialDay pd)
        {
            int timeOS = ConvertStringTimeToMinutes(pd.TimeOfStart);
            int closestTime = Math.Abs(timeOS - TimesOfLessons[0]);
            int index = 0;

            for (int i = 0; i < TimesOfLessons.Count; i++)
            {
                if (Math.Abs(timeOS - TimesOfLessons[i]) < closestTime && TimesOfLessons[i] >= timeOS)
                {
                    closestTime = Math.Abs(timeOS - TimesOfLessons[i]);
                    index = i;
                }
            }
            return index;
        }

        public void ShuffleStudents()
        {
            Random rnd = new Random();

            shuffledSeries.AddRange(series.ToArray());

            int n = shuffledSeries.Count;

            while(n!=0)
            {
                n--;
                int j = rnd.Next(n + 1);
                int val = shuffledSeries[j];
                shuffledSeries[j] = shuffledSeries[n];
                shuffledSeries[n] = val;
            }

        }

        public void CheckSameDay()
        {

        }
    }
}
