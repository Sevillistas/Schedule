﻿using System;
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
        public const int MaxNumberOfLessons = 12;

        public string[,] Calendar = { { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
                               { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
                               { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
                               { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
                               { "8:20", "9:00", "9:40", "10:20", "14:00", "14:40", "15:20", "16:00", "16:40", "17:20", "18:00", "18:40" },
        };

        public int[,] CalendarMinutes;

        public Students students;

        public List<int> series = new List<int>();

        public List<int> shuffledSeries = new List<int>();

        public List<int> TimesOfLessons = new List<int>() { 500, 540, 580, 620, 840, 880, 920, 960, 1000, 1040, 1080, 1120 };
        public GeneratorOfSchedule(Students st)
        {
            CalendarMinutes = new int[Calendar.GetLength(0), Calendar.GetLength(1)];
            students = st;
            FillCalendarMinutes();
            CreateSeriesOfStudents();
            ShuffleStudents();
        }

        public void CreateSeriesOfStudents()
        {
            foreach (Student s in students.list)
            {
                for (int i = 0; i < s.NumberOfLesson; i++)
                {
                    series.Add(s.ID);
                }
            }
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
        public int ConvertStringTimeToMinutes(string timeofstart)
        {
            var tOS = timeofstart.Split(':'); //OS - OfStart h - hours m - minutes
            int hOS = int.Parse(tOS[0]);
            int mOS = int.Parse(tOS[1]);
            return hOS * 60 + mOS;
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

        public void FillStudentCalendar()
        {
            for (int i = 0; i < CalendarMinutes.GetLength(0); i++)
            {
                for (int j = 0; j < CalendarMinutes.GetLength(1); j++)
                {
                    CalendarMinutes[i, j] = ConvertStringTimeToMinutes(Calendar[i, j]);
                }
            }
        }

        public int CountNumberOfLessonsBetweenTimes(PotentialDay pd)
        {
            int timeOS = ConvertStringTimeToMinutes(pd.TimeOfStart);
            int timeOE = ConvertStringTimeToMinutes(pd.TimeOfEnding);
            int difference = 0;
            if(timeOS>620 && timeOE<880)
            {
                return 0;
            }
            if (timeOS <= 620 && timeOE >= 840)
            {
                difference = 660 - timeOS; //660=11:00 //60 min s utra
                difference += (timeOE - 840);
            }
            else if((timeOS > 620 && timeOS <= 840) && timeOE >= 840)
            {
                timeOS = 840;
                difference = timeOE - timeOS;
            }
            else
            {
                difference = timeOE - timeOS;
            }
            int countLessons = difference / 40; //40 минут длится урок
            return countLessons;
        }

        public int CheckDay(PotentialDay pd)
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

        public int FindEarliestTimeOfLesson(PotentialDay pd)
        {
            int timeOS = ConvertStringTimeToMinutes(pd.TimeOfStart);
            int closestTime = Math.Abs(timeOS-TimesOfLessons[0]);
            int index = 0;

            for (int i = 0; i < TimesOfLessons.Count; i++)
            {
               if(Math.Abs(timeOS-TimesOfLessons[i])< closestTime && TimesOfLessons[i]>=timeOS)
               {
                    closestTime = Math.Abs(timeOS - TimesOfLessons[i]);
                    index = i;
               }
            }
            return index;
        }
        public void CreateTableForStudent()
        {
            int day = 0;
            int nOL = 0; //numberOfLessons
            int eTOL = 0; //earliestTimeOfLesson
            bool[,] Table = new bool[NumberOfWorkdays, MaxNumberOfLessons];
            foreach(Student s in students.list)
            {
                foreach(PotentialDay pd in s.PotentialDays)
                {
                    day=CheckDay(pd);
                    nOL=CountNumberOfLessonsBetweenTimes(pd);
                    eTOL = FindEarliestTimeOfLesson(pd);
                    while(nOL!=0)
                    {
                        Table[day, eTOL] = true;
                        eTOL++;
                        nOL--;
                    }
                    /*for(int j=0;j<MaxNumberOfLessons;j++)
                    {
                        //if(CalendarMinutes[day,j]==)
                    }*/
                }
            }
        }

        public void MayBe()
        {

        }
    }
}