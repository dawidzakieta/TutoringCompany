using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TutoringCompany {
    public abstract class Person : IComparable<Person>
    {
        protected int id;
        protected string name;
        protected string surname;
        protected Gender gender;
        protected string phoneNumber;
        public string Name { get => name; set {
            if (value.Length > 0 && value.Length < 30 && char.IsUpper(value[0])) name = value;
            else throw new FormatException("Wrong client name value; name has to start from the uppercase letter, have at least one and less than thirty characters.");
        }}
        public string Surname{get => surname; set{
            if (value.Length > 0 && value.Length < 30 && char.IsUpper(value[0])) surname = value;
            else throw new FormatException("Wrong client surname value; surname has to start from the uppercase letter, have at least one and less than thirty characters.");
        }}
        public string PhoneNumber{ get => phoneNumber; set {
            if (Regex.IsMatch(value, @"^\d{9}$")) phoneNumber = value;
            else throw new FormatException("Wrong client phoneNumber value; phoneNumber has to contain exactly 9 digits.");
        }}
        public Gender Gender { get => gender; set => gender = value; }
        public int Id { get => id; }

        public Person(string name, string surname, string phoneNumber) {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
        }
        public int CompareTo(Person other) {
            if (other == null) return 1; 
            int nameComparison = string.Compare(this.Surname, other.Surname, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            return 0;
        }
    }
}
