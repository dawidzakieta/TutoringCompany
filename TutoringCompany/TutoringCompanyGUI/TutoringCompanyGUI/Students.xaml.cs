using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The Students class represents the window for managing student-related operations in the Tutoring Company GUI application.
    /// </summary>
    public partial class Students : WindowBase
    {
        private StudentList studentList;
        private TutorList tutorList;
        private ClientList clientList;
        /// <summary>
        /// Initializes a new instance of the Students class.
        /// </summary>
        /// <param name="studentList">The list of students to be managed.</param>
        /// <param name="tutorList">The list of tutors associated with the students.</param>
        /// <param name="clientList">The list of clients associated with the students.</param>
        public Students(StudentList studentList, TutorList tutorList, ClientList clientList)
        {
            InitializeComponent();

            TitleBar(TitleContent, "Students");

            this.studentList = studentList ?? new StudentList();
            this.tutorList = tutorList;
            this.clientList = clientList;



            studentsListBox.ItemsSource = this.studentList.Students;
        }
        /// <summary>
        /// Event handler for the "addStudent_Click" event, triggered when the "Add Student" button is clicked.
        /// Opens the AddStudent window to add a new student.
        /// </summary>
        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudentWindow = new AddStudent(studentList, studentsListBox, tutorList, clientList);
            addStudentWindow.Show();
        }
        /// <summary>
        /// Event handler for the "deleteStudent_Click" event, triggered when the "Delete Student" button is clicked.
        /// Removes the selected student from the studentList.
        /// </summary>
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
        /// <summary>
        /// Event handler for the "sortStudent_Click" event, triggered when the "Sort Students" button is clicked.
        /// Sorts the studentList and updates the studentsListBox data source.
        /// </summary>
        private void sortStudent_Click(object sender, RoutedEventArgs e)
        {
            studentList.Sort();
            studentsListBox.ItemsSource = studentList.Students;
        }
        /// <summary>
        /// Event handler for the "searchBox_TextChanged" event, triggered when the text in the searchBox changes.
        /// Filters and updates the studentsListBox based on the entered search text.
        /// </summary>
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
        /// <summary>
        /// Event handler for the "TextBox_GotFocus" event, triggered when the searchBox gets focus.
        /// Clears the default placeholder text if it is present.
        /// </summary>
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search students") { searchBox.Text = ""; }
        }
        /// <summary>
        /// Event handler for the "TextBox_LostFocus" event, triggered when the searchBox loses focus.
        /// Restores the default placeholder text if the searchBox is empty.
        /// </summary>
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
