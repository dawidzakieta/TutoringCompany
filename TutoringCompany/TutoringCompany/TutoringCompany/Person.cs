using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutoringCompany {
    /// <summary>
    /// Class Person that uses the interface IComparable and is used as a "base" class for classes: Client, Tutor and Student
    /// </summary>
    public abstract class Person : IComparable<Person>
    {
        protected int id;
        protected string name;
        protected string surname;
        protected Gender gender;
        protected string phoneNumber;
        /// <summary>
        /// Gets or sets client's name with condition
        /// </summary>
        public string Name { get => name; set {
            if (value.Length > 0 && value.Length < 30 && char.IsUpper(value[0])) name = value;
            else throw new FormatException("Wrong client name value; name has to start from the uppercase letter, have at least one and less than thirty characters.");
        }}
        /// <summary>
        /// Gets or sets client's surname with condition
        /// </summary>
        public string Surname{get => surname; set{
            if (value.Length > 0 && value.Length < 30 && char.IsUpper(value[0])) surname = value;
            else throw new FormatException("Wrong client surname value; surname has to start from the uppercase letter, have at least one and less than thirty characters.");
        }}
        /// <summary>
        /// Gets or sets client's phone number with condition
        /// </summary>
        public string PhoneNumber{ get => phoneNumber; set {
            if (Regex.IsMatch(value, @"^\d{9}$")) phoneNumber = value;
            else throw new FormatException("Wrong client phoneNumber value; phoneNumber has to contain exactly 9 digits.");
        }}
        /// <summary>
        /// Gets or sets client's gender
        /// </summary>
        public Gender Gender { get => gender; set => gender = value; }
        /// <summary>
        /// Gets client's id
        /// </summary>
        public int Id { get => id; }
        /// <summary>
        /// Initialazes an instance of class Person
        /// </summary>
        /// <param name="name">Person's name</param>
        /// <param name="surname">Person's surname</param>
        /// <param name="phoneNumber">Persons phone number</param>
        public Person(string name, string surname, string phoneNumber) {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }
        /// <summary>
        /// Compares the current instance with another Person object based on surnames.
        /// Returns:
        ///   -1 if the current instance's surname is considered "less" than the other's.
        ///    0 if both surnames are the same.
        ///    1 if the current instance's surname is considered "greater" than the other's.
        /// </summary>
        /// <param name="other">An object of class Person which surname we want to compare</param>
        /// <returns></returns>
        public int CompareTo(Person other) {
            if (other == null) return 1; 
            int nameComparison = string.Compare(this.Surname, other.Surname, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            return 0;
        }
    }
}
