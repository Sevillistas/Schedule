using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSchedule
{
    class Students
    {
        public List<Student> ListOfStudents = new List<Student>();

        public Students(List<Student> students)
        {
            ListOfStudents = students;
            UpdateStudent();
        }

        public Students()
        {

        }

        public void AddStudent(Student student)
        {
            ListOfStudents.Add(student);
        }

        public void UpdateStudent()
        {
            foreach(Student s in ListOfStudents)
            {
                s.CountNumberOfLesson();
            }
        }
    }
}
