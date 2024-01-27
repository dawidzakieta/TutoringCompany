using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutoringCompany
{
    /// <summary>
    /// Class Client represents a client using tutoring services, the class inherits from the class Person
    /// </summary>
    public class Client : Person
    {
        private string email;
        private decimal lessonRate;
        static int currentId = 1;

        #region Properties
        /// <summary>
        /// Gets or sets client's email address with condition
        /// </summary>
        public string Email { get => email; set {
            email = value;
            if (Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")) email = value;
            else throw new FormatException("Wrong client email value.");
        }}
        /// <summary>
        /// Gets or sets client's rate per lesson
        /// </summary>
        public decimal LessonRate {get => lessonRate; set {
            if (value >= 0m) lessonRate = value;
            else throw new FormatException("Wrong client lessonRate value; lessonRate has to bigger or equal to zero.");
        }}
        #endregion Properties

        #region Constructors
        /// <summary>
        /// Initializes new instance of class Client
        /// </summary>
        /// <param name="name">Client's name</param>
        /// <param name="surname">Client's surname</param>
        /// <param name="lessonRate">Client's rate per lesson</param>
        /// <param name="phoneNumber">Client's phone number</param>
        /// <param name="email">Client's email address</param>
        /// <param name="gender">Client's gender</param>
        public Client(string name, string surname, decimal lessonRate, string phoneNumber, string email, Gender gender) : base(name, surname, phoneNumber)
        {
            id = currentId;
            this.surname = surname;
            this.email = email;
            this.gender = gender;
            currentId++;
        }
        #endregion Constructors

    }
}
