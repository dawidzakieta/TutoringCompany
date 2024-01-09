using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TutoringCompany;

namespace TutoringCompanyGUI {
    public partial class MainWindow : WindowBase {
        private ClientList clientList;
        private TutorList tutorList;
        private StudentList studentList;
        private LessonList lessonList;

        public MainWindow() {
            InitializeComponent();
            base.TitleBar(TitleContent, "Tutoring");
            clientList = new ClientList();
            studentList = new StudentList();
            tutorList = new TutorList();
            lessonList = new LessonList();
        }
        private void clients_Click(object sender, RoutedEventArgs e) {
            Clients clientsWindow = new Clients(clientList);
            clientsWindow.Show();
        }
        private void tutors_Click(object sender, RoutedEventArgs e)
        {
            Tutors tutorsWindow = new Tutors(tutorList);
            tutorsWindow.Show();
        }
        private void students_Click(object sender, RoutedEventArgs e)
        {
            Students studentsWindow = new Students(studentList, tutorList, clientList);
            studentsWindow.Show();
        }
        private void lessons_Click(object sender, RoutedEventArgs e)
        {
            Lessons lessonsWindow = new Lessons(lessonList, studentList);
            lessonsWindow.Show();
        }
    }
}
