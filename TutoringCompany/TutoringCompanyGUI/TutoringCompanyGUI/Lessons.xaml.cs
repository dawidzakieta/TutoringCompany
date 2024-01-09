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
    public partial class Lessons : WindowBase
    {
        private LessonList lessonList;
        private StudentList studentList;

        public Lessons(LessonList lessonList, StudentList studentList)
        {
            InitializeComponent();

            TitleBar(TitleContent, "Lessons");

            this.lessonList = lessonList ?? new LessonList();
            this.studentList = studentList;

            lessonsListBox.ItemsSource = this.lessonList.Lessons;
        }

        private void addLesson_Click(object sender, RoutedEventArgs e)
        {
            AddLesson addLessonWindow = new AddLesson(lessonList, lessonsListBox, studentList);
            addLessonWindow.Show();
        }

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
            private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search lessons") { searchBox.Text = ""; }
        }
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
