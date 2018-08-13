using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSchedule
{
    class Students
    {
        public List<Student> list = new List<Student>();

        public Students()
        {

        }

        public void AddStudent(Student student)
        {
            list.Add(student);
        }

        public void UpdateStudent()
        {
            foreach(Student s in list)
            {
                s.CountNumberOfLesson();
            }
        }
    }
}
