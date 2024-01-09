using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class Tutor : Person, IComparable<Person>
    {
        private decimal lessonRate;
        private string email;
        static int currentId = 1;

        #region Properties
        public decimal LessonRate { get => lessonRate; set {
            if (value >= 0m)lessonRate = value;
            else throw new FormatException("Wrong tutor lessonRate value; lessonRate has to bigger or equal to zero.");
        }}
        public string Email{get => email; set {
            email = value;
            if (Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")) email = value;
            else throw new FormatException("Wrong tutor email value.");
        }}
        #endregion Properties

        #region Constructors
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
