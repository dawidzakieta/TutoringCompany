using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The AddStudent class represents a window in the Tutoring Company GUI application for adding new students.
    /// </summary>
    public partial class AddStudent : WindowBase
    {
        private StudentList studentList;
        private ListBox studentsListBox;
        private TutorList tutorList;
        private ClientList clientList;
        /// <summary>
        /// Initializes a new instance of the AddStudent class.
        /// </summary>
        /// <param name="studentList">The StudentList object that manages the list of students.</param>
        /// <param name="studentsListBox">The ListBox control displaying the list of students.</param>
        /// <param name="tutorList">The TutorList object that manages the list of tutors.</param>
        /// <param name="clientList">The ClientList object that manages the list of clients.</param>
        public AddStudent(StudentList studentList, ListBox studentsListBox, TutorList tutorList, ClientList clientList)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add students");

            this.studentList = studentList;
            this.studentsListBox = studentsListBox;
            this.tutorList = tutorList;
            this.clientList = clientList;

            studentClientItems();
            studentTutorItems();
        }
        /// <summary>
        /// Event handler for the "addStudent2_Click" event, triggered when the user clicks the "Add Student" button.
        /// Creates a new Student object using the entered information, adds it to the studentList, updates the studentsListBox, and shows a confirmation message.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void addStudent2_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student(studentName.Text, studentSurname.Text, studentPhone.Text, (Class)Enum.Parse(typeof(Class), studentClass.Text), (Client)studentClient.SelectedItem, (Tutor)studentTutor.SelectedItem, (Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)studentGender.SelectedItem).Content.ToString()));
            studentList.AddStudent(newStudent);
            studentsListBox.ItemsSource = new ObservableCollection<Student>(studentList.Students);
            MessageBox.Show("Student added correctly.");
        }
        /// <summary>
        /// Populates the studentClient ComboBox with client items filtered based on the entered text.
        /// </summary>
        private void studentClientItems()
        {
            var filter = studentClient.Text.ToLower();
            if (clientList != null) {

                var filteredData = clientList.Clients
                    .Where(client => client.Name.ToLower().Contains(filter) || client.Surname.ToLower().Contains(filter)).ToList();

                studentClient.ItemsSource = filteredData;
            }
            else studentClient.ItemsSource = null;
        }
        /// <summary>
        /// Populates the studentTutor ComboBox with tutor items filtered based on the entered text.
        /// </summary>
        private void studentTutorItems()
        {
            var filter = studentTutor.Text.ToLower();
            if (tutorList != null)
            {
                var filteredData = tutorList.Tutors
                    .Where(tutor => tutor.Name.ToLower().Contains(filter) || tutor.Surname.ToLower().Contains(filter)).ToList();

                studentTutor.ItemsSource = filteredData;
            }
            else studentTutor.ItemsSource = null;
        }
    }
}
