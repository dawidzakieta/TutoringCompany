using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class Lesson
    {
        private Student student;
        private DateTime date_time;

        public Student Student { get => student; set => student = value; }
        public DateTime Date_time { get => date_time; set => date_time = value; }

        public Lesson(Student student, DateTime date_time)
        {
            this.student = student;
            this.date_time = date_time;
        }
    }
}
