using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TutoringCompany
{
    public class Student
    {
        private int id;
        private string name;
        private string surname;
        private string phoneNumber;
        private Gender gender;
        private Class classLevel;
        private Client client;
        private Tutor tutor;
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
                    throw new FormatException("Wrong student name value; name has to start from the uppercase letter, have at least one and less than thirty characters.");
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
                    throw new FormatException("Wrong student surname value; surname has to start from the uppercase letter, have at least one and less than thirty characters.");
                }
            }
        }
        public Class ClassLevel { get => classLevel; set => classLevel = value; }
        public Client Client { get => client; set => client = value; }
        public Tutor Tutor { get => tutor; set => tutor = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public int Id { get => id; }
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
        #endregion Properties

        #region Constructors
        public Student(string name, string surname, string phoneNumber, Class classLevel, Client client, Tutor tutor, Gender gender)
        {
            this.name = name;
            this.surname = surname;
            this.PhoneNumber = phoneNumber;
            this.classLevel = classLevel;
            this.client = client;
            this.tutor = tutor;
            this.gender = gender;
            this.id = currentId;
            currentId++;
        }
        #endregion Constructors
    }
}
