using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutoringCompany
{
    /// <summary>
    /// Class Tutor represents a tutor hire to provide tutoring services, the class inherits from the class Person
    /// </summary>
    public class Tutor : Person, IComparable<Person>
    {
        private decimal lessonRate;
        private string email;
        static int currentId = 1;

        #region Properties
        /// <summary>
        /// Gets or sets tutor's rate per lesson with condition
        /// </summary>
        public decimal LessonRate { get => lessonRate; set {
            if (value >= 0m)lessonRate = value;
            else throw new FormatException("Wrong tutor lessonRate value; lessonRate has to bigger or equal to zero.");
        }}
        /// <summary>
        /// Gets or sets tutor's email address with condition
        /// </summary>
        public string Email{get => email; set {
            email = value;
            if (Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")) email = value;
            else throw new FormatException("Wrong tutor email value.");
        }}
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Initlizes an instance of class Tutor
        /// </summary>
        /// <param name="name">Tutors's name</param>
        /// <param name="surname">Tutors's surname</param>
        /// <param name="lessonRate">Tutors's rate per lesson</param>
        /// <param name="phoneNumber">Tutors's phone number</param>
        /// <param name="email">Tutors's email address</param>
        /// <param name="gender">Tutors's gender</param>
        public Tutor(string name, string surname, decimal lessonRate, string phoneNumber, string email, Gender gender) : base(name, surname, phoneNumber)
        {
            id = currentId;
            this.lessonRate = lessonRate;
            this.email = email;
            this.gender = gender;
            currentId++;
        }
        #endregion Constructors

    }
}
