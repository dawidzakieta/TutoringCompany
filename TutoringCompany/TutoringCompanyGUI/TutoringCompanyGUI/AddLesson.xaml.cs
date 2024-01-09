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
    public partial class AddLesson : WindowBase
    {
        private LessonList lessonList;
        private StudentList studentList;
        private ListBox lessonsListBox;

        public AddLesson(LessonList lessonList, ListBox lessonsListBox, StudentList studentList)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add lessons");

            this.lessonList = lessonList;
            this.studentList = studentList;
            this.lessonsListBox = lessonsListBox;
        }
        private void addLesson_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDate;
            DateTime selectedTime;
            if (DateTime.TryParse(lessonDate.Text, out selectedDate) && DateTime.TryParse(lessonTime.Text, out selectedTime))
            {
                DateTime combinedDateTime = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, selectedTime.Hour, selectedTime.Minute, selectedTime.Second);
                Lesson newLesson = new Lesson(Client(lessonStudent.SelectedItem), combinedDateTime);
                lessonList.AddLesson(newLesson);
                lessonsListBox.ItemsSource = new ObservableCollection<Lesson>(lessonList.Lessons);
                MessageBox.Show("Lesson added correctly.");
            }
            else
            {
                MessageBox.Show("Lesson can't be added. Wrong date or time input");
            }
        }

        private void lessonStudent_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var filter = lessonStudent.Text.ToLower();
            if (studentList != null)
            {
                var filteredData = studentList.Students
                    .Where(student => student.Name.ToLower().Contains(filter) || student.Surname.ToLower().Contains(filter)).ToList();

                lessonStudent.ItemsSource = filteredData;
                lessonStudent.IsDropDownOpen = true;
            }
            else
            {
                lessonStudent.ItemsSource = null;
                lessonStudent.IsDropDownOpen = false;
            }
        }

        private Student Client(object selectedItem)
        {
            throw new NotImplementedException();
        }

    }
}
