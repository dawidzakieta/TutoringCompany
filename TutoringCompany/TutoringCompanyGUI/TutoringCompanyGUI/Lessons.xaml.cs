using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The Lessons class represents a window in the Tutoring Company GUI application for managing lessons.
    /// </summary>
    public partial class Lessons : WindowBase
    {
        private LessonList lessonList;
        private StudentList studentList;
        /// <summary>
        /// Initializes a new instance of the Lessons class.
        /// </summary>
        /// <param name="lessonList">The LessonList object that manages the list of lessons.</param>
        /// <param name="studentList">The StudentList object that manages the list of students.</param>
        public Lessons(LessonList lessonList, StudentList studentList)
        {
            InitializeComponent();

            TitleBar(TitleContent, "Lessons");

            this.lessonList = lessonList ?? new LessonList();
            this.studentList = studentList;

            lessonsListBox.ItemsSource = this.lessonList.Lessons;
        }
        /// <summary>
        /// Event handler for the "addLesson_Click" event, triggered when the user clicks the "Add Lesson" button.
        /// Opens the AddLesson window to add a new lesson.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void addLesson_Click(object sender, RoutedEventArgs e)
        {
            AddLesson addLessonWindow = new AddLesson(lessonList, lessonsListBox, studentList);
            addLessonWindow.Show();
        }
        /// <summary>
        /// Event handler for the "deleteLesson_Click" event, triggered when the user clicks the "Delete Lesson" button.
        /// Removes the selected lesson from the lessonList and shows a confirmation message.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void deleteLesson_Click(object sender, RoutedEventArgs e)
        {
            if (lessonsListBox.SelectedItem != null)
            {
                Lesson selectedLesson = (Lesson)lessonsListBox.SelectedItem;
                lessonList.RemoveLesson(selectedLesson);
                MessageBox.Show("Lesson removed successfully.");
            }
            else
            {
                MessageBox.Show("Please select a lesson to remove.");
            }
        }
        /// <summary>
        /// Event handler for the "sortLesson_Click" event, triggered when the user clicks the "Sort Lessons" button.
        /// Sorts the lessons in the lessonList and updates the lessonsListBox.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void sortLesson_Click(object sender, RoutedEventArgs e)
        {
            lessonList.Sort();
            lessonsListBox.ItemsSource = lessonList.Lessons;
        }
        /// <summary>
        /// Event handler for the "searchBox_TextChanged" event, triggered when the text in the searchBox changes.
        /// Filters the displayed lessons based on the entered search text.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            if (searchText == "search lessons") return;

            if (lessonList != null)
            {
                var filteredLessons = lessonList.Lessons.Where(lesson => lesson.Student.Name.ToLower().Contains(searchText) || lesson.Student.Surname.ToLower().Contains(searchText) || lesson.Student.PhoneNumber.ToLower().Contains(searchText));
                lessonsListBox.ItemsSource = new ObservableCollection<Lesson>(filteredLessons.ToList());
            }
            else
            {
                lessonsListBox.ItemsSource = null;
            }
        }
        #region TextBox
        /// <summary>
        /// Event handler for the "TextBox_GotFocus" event, triggered when the searchBox receives focus.
        /// Clears the default placeholder text in the searchBox.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search lessons") { searchBox.Text = ""; }
        }
        /// <summary>
        /// Event handler for the "TextBox_LostFocus" event, triggered when the searchBox loses focus.
        /// Sets the default placeholder text in the searchBox if it is empty.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search lessons";
            }
        }
        #endregion

    }
}
