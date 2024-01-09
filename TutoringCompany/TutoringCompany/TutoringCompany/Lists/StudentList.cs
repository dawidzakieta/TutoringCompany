using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class StudentList
    {
        private ObservableCollection<Student> students = new ObservableCollection<Student>();

        public ObservableCollection<Student> Students => students;

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }
        public void Sort()
        {
            ObservableCollection<Student> sortedStudents = new ObservableCollection<Student>(students.OrderBy(student => student.Surname));
            students.Clear();
            students = sortedStudents;
        }
    }
}
