using System;
using System.IO;
using System.Windows;
using Newtonsoft.Json;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The MainWindow class represents the main window of the Tutoring Company GUI application.
    /// </summary>
    public partial class MainWindow : WindowBase
    {
        private ClientList clientList;
        private TutorList tutorList;
        private StudentList studentList;
        private LessonList lessonList;
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            base.TitleBar(TitleContent, "Tutoring");
            clientList = LoadJsonClient() ?? new ClientList();
            studentList = LoadJsonStudent() ?? new StudentList();
            tutorList = LoadJsonTutor() ?? new TutorList();
            lessonList = LoadJsonLesson() ?? new LessonList();

            Closing += MainWindowClosing;
        }
        /// <summary>
        /// Event handler for the "Closing" event, triggered when the main window is closing.
        /// Asks the user for confirmation before closing and saves data to JSON files.
        /// </summary>
        private void MainWindowClosing(object sender, System.ComponentModel.CancelEventArgs e){
            MessageBoxResult result = MessageBox.Show("Are you sure?", "Apply", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No){
                e.Cancel = true;
            }
                SaveJson(clientList, tutorList, studentList, lessonList);
        }
        /// <summary>
        /// Event handler for the "clients_Click" event, triggered when the "Clients" button is clicked.
        /// Opens the Clients window to manage clients.
        /// </summary>
        private void clients_Click(object sender, RoutedEventArgs e)
        {
            Clients clientsWindow = new Clients(clientList);
            clientsWindow.Show();
        }
        /// <summary>
        /// Event handler for the "tutors_Click" event, triggered when the "Tutors" button is clicked.
        /// Opens the Tutors window to manage tutors.
        /// </summary>
        private void tutors_Click(object sender, RoutedEventArgs e)
        {
            Tutors tutorsWindow = new Tutors(tutorList);
            tutorsWindow.Show();
        }
        /// <summary>
        /// Event handler for the "students_Click" event, triggered when the "Students" button is clicked.
        /// Opens the Students window to manage students.
        /// </summary>
        private void students_Click(object sender, RoutedEventArgs e)
        {
            Students studentsWindow = new Students(studentList, tutorList, clientList);
            studentsWindow.Show();
        }
        /// <summary>
        /// Event handler for the "lessons_Click" event, triggered when the "Lessons" button is clicked.
        /// Opens the Lessons window to manage lessons.
        /// </summary>
        private void lessons_Click(object sender, RoutedEventArgs e)
        {
            Lessons lessonsWindow = new Lessons(lessonList, studentList);
            lessonsWindow.Show();
        }
        /// <summary>
        /// Saves the current state of various lists to JSON files.
        /// </summary>
        /// <param name="clientList">The list of clients to be saved.</param>
        /// <param name="tutorList">The list of tutors to be saved.</param>
        /// <param name="studentList">The list of students to be saved.</param>
        /// <param name="lessonList">The list of lessons to be saved.</param>
        public static void SaveJson(ClientList clientList, TutorList tutorList, StudentList studentList, LessonList lessonList) {
            try {
                string jsonStr = JsonConvert.SerializeObject(clientList);
                string jsonStr2 = JsonConvert.SerializeObject(tutorList);
                string jsonStr3 = JsonConvert.SerializeObject(studentList);
                string jsonStr4 = JsonConvert.SerializeObject(lessonList);
                File.WriteAllText("SaveJSON", jsonStr);
                File.WriteAllText("SaveJSON2", jsonStr2);
                File.WriteAllText("SaveJSON3", jsonStr3);
                File.WriteAllText("SaveJSON4", jsonStr4);
                MessageBox.Show("Saved to JSON");
            }
            catch (Exception ex) { Console.WriteLine("Error saving JSON: " + ex.Message); }
        }
        #region Don't look under no circumstances
        /// <summary>
        /// Loads a ClientList from a JSON file.
        /// </summary>
        /// <returns>The loaded ClientList or null if an error occurs.</returns>
        public static ClientList LoadJsonClient() {
            string fileName = "SaveJSON";
            try {
                if (!File.Exists(fileName)) return null;

                string jsonstr = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<ClientList>(jsonstr);
            }
            catch (Exception ex) { return null; }
        }
        /// <summary>
        /// Loads a TutorList from a JSON file.
        /// </summary>
        /// <returns>The loaded TutorList or null if an error occurs.</returns>
        public static TutorList LoadJsonTutor() {
            string fileName = "SaveJSON2";
            try {
                if (!File.Exists(fileName)) return null;
                string jsonstr = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<TutorList>(jsonstr);
            }
            catch (Exception ex) { return null; }
        }
        /// <summary>
        /// Loads a StudentList from a JSON file.
        /// </summary>
        /// <returns>The loaded StudentList or null if an error occurs.</returns>
        public static StudentList LoadJsonStudent() {
            string fileName = "SaveJSON3";
            try {
                if (!File.Exists(fileName)) return null;

                string jsonstr = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<StudentList>(jsonstr);
            }
            catch (Exception ex) { return null; }
        }
        /// <summary>
        /// Loads a LessonList from a JSON file.
        /// </summary>
        /// <returns>The loaded LessonList or null if an error occurs.</returns>
        public static LessonList LoadJsonLesson() {
            string fileName = "SaveJSON4";
            try {
                if (!File.Exists(fileName)) return null; 
                string jsonstr = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<LessonList>(jsonstr);
            }
            catch (Exception ex) { return null; }
        }
        #endregion
    }
}
