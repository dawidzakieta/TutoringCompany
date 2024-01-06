﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class Tutor
    {
        private int id;
        private string name;
        private string surname;
        private Gender gender;
        private string phoneNumber;
        private decimal lessonRate;
        private DateTime joiningDate;
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
                    throw new FormatException("Wrong tutor name value; name has to start from the uppercase letter, have at least one and less than thirty characters.");
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
                    throw new FormatException("Wrong tutor surname value; surname has to start from the uppercase letter, have at least one and less than thirty characters.");
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
                    throw new FormatException("Wrong tutor phoneNumber value; phoneNumber has to contain exactly 9 digits.");

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
                    throw new FormatException("Wrong tutor lessonRate value; lessonRate has to bigger or equal to zero.");
                }
            }
        }
        public DateTime JoiningDate { get => joiningDate; set => joiningDate = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public int Id { get => id; }
        #endregion Properties

        #region Constructors
        public Tutor(string name, string surname, string phoneNumber, decimal lessonRate, DateTime joiningDate, Gender gender)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.lessonRate = lessonRate;
            this.joiningDate = joiningDate;
            this.gender = gender;
            this.id = currentId;
            currentId++;
        }
        #endregion Constructors

    }
}
