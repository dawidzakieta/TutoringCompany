using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringCompany
{
    /// <summary>
    /// Class Lesson represents a student lesson
    /// </summary>
    public class Lesson
    {
        private Student student;
        private DateTime date_time;
        /// <summary>
        /// Gets or sets Lesson's student and date without a condition
        /// </summary>
        public Student Student { get => student; set => student = value; }
        public DateTime Date_time { get => date_time; set => date_time = value; }
        /// <summary>
        /// Initializes new instance of class Lesson
        /// </summary>
        /// <param name="student">Student for whom the lesson is</param>
        /// <param name="date_time">Date and the time of the lesson</param>
        public Lesson(Student student, DateTime date_time)
        {
            this.student = student;
            this.date_time = date_time;
        }
    }
}
