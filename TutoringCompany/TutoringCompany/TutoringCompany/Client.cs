using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class Client : Person
    {
        private string email;
        private decimal lessonRate;
        static int currentId = 1;

        #region Properties
        public string Email { get => email; set {
            email = value;
            if (Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")) email = value;
            else throw new FormatException("Wrong client email value.");
        }}
        public decimal LessonRate {get => lessonRate; set {
            if (value >= 0m) lessonRate = value;
            else throw new FormatException("Wrong client lessonRate value; lessonRate has to bigger or equal to zero.");
        }}
        #endregion Properties

        #region Constructors
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
