using System.Windows;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    public partial class MainWindow : WindowBase
    {
        private ClientList clientList;
        private TutorList tutorList;
        private StudentList studentList;
        private LessonList lessonList;

        public MainWindow()
        {
            InitializeComponent();
            base.TitleBar(TitleContent, "Tutoring");
            clientList = new ClientList();
            studentList = new StudentList();
            tutorList = new TutorList();
            lessonList = new LessonList();
        }
        private void clients_Click(object sender, RoutedEventArgs e)
        {
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
