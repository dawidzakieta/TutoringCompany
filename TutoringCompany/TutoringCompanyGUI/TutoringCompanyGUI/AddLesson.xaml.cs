using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The AddLesson class represents a window in the Tutoring Company GUI application for adding new lessons.
    /// </summary>
    public partial class AddLesson : WindowBase
    {
        private LessonList lessonList;
        private StudentList studentList;
        private ListBox lessonsListBox;
        /// <summary>
        /// Initializes a new instance of the AddLesson class.
        /// </summary>
        /// <param name="lessonList">The LessonList object that manages the list of lessons.</param>
        /// <param name="lessonsListBox">The ListBox control displaying the list of lessons.</param>
        /// <param name="studentList">The StudentList object that manages the list of students.</param>
        public AddLesson(LessonList lessonList, ListBox lessonsListBox, StudentList studentList)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add lessons");

            this.lessonList = lessonList;
            this.studentList = studentList;
            this.lessonsListBox = lessonsListBox;

            lessonStudentItems();
        }
        /// <summary>
        /// Event handler for the "addLesson_Click" event, triggered when the user clicks the "Add Lesson" button.
        /// Validates input, creates a new Lesson object, adds it to the lessonList, updates the lessonsListBox, and shows a confirmation message.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void addLesson_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate;
            DateTime selectedTime;
            if (DateTime.TryParse(lessonDate.Text, out selectedDate) && DateTime.TryParse(lessonTime.Text, out selectedTime))
            {
                DateTime combinedDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hour, selectedTime.Minute, selectedTime.Second);
                Lesson newLesson = new Lesson((Student)lessonStudent.SelectedItem, combinedDateTime);
                lessonList.AddLesson(newLesson);
                lessonsListBox.ItemsSource = new ObservableCollection<Lesson>(lessonList.Lessons);
                MessageBox.Show("Lesson added correctly.");
            }
            else
            {
                MessageBox.Show("Lesson can't be added. Wrong date or time input");
            }
        }
        /// <summary>
        /// Shows in the lessonStudent ComboBox possible students to pick, filtered based on the entered text.
        /// </summary>
        private void lessonStudentItems()
        {
            var filter = lessonStudent.Text.ToLower();
            if (studentList != null)
            {
                var filteredData = studentList.Students
                    .Where(student => student.Name.ToLower().Contains(filter) || student.Surname.ToLower().Contains(filter)).ToList();

                lessonStudent.ItemsSource = filteredData;
            }
            else
            {
                lessonStudent.ItemsSource = null;
            }
        }
    }
}
