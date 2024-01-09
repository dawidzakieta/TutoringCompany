using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TutoringCompany
{
    public class Student : Person, IComparable<Person>
    {
        private Class classLevel;
        private Client client;
        private Tutor tutor;
        static int currentId = 1;

        #region Properties
        public Class ClassLevel { get => classLevel; set => classLevel = value; }
        public Client Client { get => client; set => client = value; }
        public Tutor Tutor { get => tutor; set => tutor = value; }

        #endregion Properties

        #region Constructors
        public Student(string name, string surname, string phoneNumber, Class classLevel, Client client, Tutor tutor, Gender gender) : base(name, surname, phoneNumber)
        {
            id = currentId;
            this.classLevel = classLevel;
            this.client = client;
            this.tutor = tutor;
            currentId++;
        }
        #endregion Constructors
    }
}
