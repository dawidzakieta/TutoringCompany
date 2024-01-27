using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TutoringCompany
{
    /// <summary>
    /// Class Student represents a student which has to be connected with a Client that pays for him and a Tutor that teaches him (Student can also be the Client),
    /// the class inherits from the class Person
    /// </summary>
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
        /// <summary>
        /// Initializes an instance of class Student
        /// </summary>
        /// <param name="name">Student's name</param>
        /// <param name="surname">Student's surname</param>
        /// <param name="phoneNumber">Student's phone number</param>
        /// <param name="classLevel">Student's educational level</param>
        /// <param name="client">Client connected to student</param>
        /// <param name="tutor">Tutor connected to student</param>
        /// <param name="gender">Student's gender</param>
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
