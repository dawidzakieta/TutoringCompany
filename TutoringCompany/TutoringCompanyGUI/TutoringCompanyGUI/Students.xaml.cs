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
    public partial class Students : WindowBase
    {
        private StudentList studentList;
        private TutorList tutorList;
        private ClientList clientList;
        public Students(StudentList studentList, TutorList tutorList, ClientList clientList)
        {
            InitializeComponent();

            TitleBar(TitleContent, "Students");

            this.studentList = studentList ?? new StudentList();
            this.tutorList = tutorList;
            this.clientList = clientList;



            studentsListBox.ItemsSource = this.studentList.Students;
        }

        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudentWindow = new AddStudent(studentList, studentsListBox, tutorList, clientList);
            addStudentWindow.Show();
        }

        private void deleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (studentsListBox.SelectedItem != null)
            {
                Student selectedStudent = (Student)studentsListBox.SelectedItem;
                studentList.RemoveStudent(selectedStudent);
                MessageBox.Show("Student removed successfully.");
            }
            else
            {
                MessageBox.Show("Please select a student to remove.");
            }
        }
        private void sortStudent_Click(object sender, RoutedEventArgs e)
        {
            studentList.Sort();
            studentsListBox.ItemsSource = studentList.Students;
        }
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            if (searchText == "search students") return;

            if (studentList != null)
            {
                var filteredStudents = studentList.Students
                    .Where(student =>
                        student.Name.ToLower().Contains(searchText) ||
                        student.Surname.ToLower().Contains(searchText) ||
                        student.PhoneNumber.Contains(searchText));
                studentsListBox.ItemsSource = new ObservableCollection<Student>(filteredStudents.ToList());
            }
            else studentsListBox.ItemsSource = null;
        }
        #region TextBox
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search students") { searchBox.Text = ""; }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search students";
            }
        }
        #endregion

    }
}
