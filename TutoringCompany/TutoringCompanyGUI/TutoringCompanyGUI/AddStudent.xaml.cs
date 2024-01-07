using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    public partial class AddStudent : WindowBase
    {
        private StudentList studentList;
        private ListBox studentsListBox;

        public AddStudent(StudentList studentList, ListBox studentsListBox)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add students");

            this.studentList = studentList;
            this.studentsListBox = studentsListBox;
        }
        private void addStudent2_Click(object sender, RoutedEventArgs e)
        {
            decimal rate2Value;
            if (decimal.TryParse(studentRate.Text, out rate2Value))
            {
                Student newStudent = new Student(studentName.Text, studentSurname.Text, rate2Value, studentPhone.Text, studentEmail.Text, (Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)studentGender.SelectedItem).Content.ToString()));
                studentList.AddStudent(newStudent);
                studentsListBox.ItemsSource = new ObservableCollection<Student>(studentList.Students);
                MessageBox.Show("Student added correctly.");
            }
            else
            {
                MessageBox.Show("Invalid value for hour rate. Please enter a valid decimal number.");
            }
        }
    }
}
