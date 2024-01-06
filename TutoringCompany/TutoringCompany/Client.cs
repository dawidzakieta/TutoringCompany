using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class Client
    {
        private int id;
        private string name;
        private string surname;
        private Gender gender;
        private string phoneNumber;
        private string email;
        private decimal lessonRate;
        static int currentId = 1;

        #region Properties
        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 0 && value.Length < 30 && char.IsUpper(value[0]))
                {
                    name = value;
                }
                else
                {
                    throw new FormatException("Wrong client name value; name has to start from the uppercase letter, have at least one and less than thirty characters.");
                }
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                if (value.Length > 0 && value.Length < 30 && char.IsUpper(value[0]))
                {
                    surname = value;
                }
                else
                {
                    throw new FormatException("Wrong client surname value; surname has to start from the uppercase letter, have at least one and less than thirty characters.");
                }
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (Regex.IsMatch(value, @"^\d{9}$"))
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new FormatException("Wrong client phoneNumber value; phoneNumber has to contain exactly 9 digits.");

                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    email = value;
                }
                else
                {
                    throw new FormatException("Wrong client email value.");
                }
            }
        }
        public decimal LessonRate
        {
            get => lessonRate;
            set
            {
                if (value >= 0m)
                {
                    lessonRate = value;
                }
                else
                {
                    throw new FormatException("Wrong client lessonRate value; lessonRate has to bigger or equal to zero.");
                }
            }
        }
        public Gender Gender { get => gender; set => gender = value; }
        public int Id { get => id; }
        #endregion Properties

        #region Constructors
        public Client(string name, string phoneNumber, decimal lessonRate)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.lessonRate = lessonRate;
            this.id = currentId;
            currentId++;
        }
        public Client(string name, string surname, decimal lessonRate, string phoneNumber, string email, Gender gender) : this(name, phoneNumber, lessonRate)
        {
            this.surname = surname;
            this.email = email;
            this.gender = gender;
        }
        #endregion Constructors

    }
}
