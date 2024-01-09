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
    public partial class AddStudent : WindowBase
    {
        private StudentList studentList;
        private ListBox studentsListBox;
        private TutorList tutorList;
        private ClientList clientList;

        public AddStudent(StudentList studentList, ListBox studentsListBox, TutorList tutorList, ClientList clientList)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add students");

            this.studentList = studentList;
            this.studentsListBox = studentsListBox;
            this.tutorList = tutorList;
            this.clientList = clientList;
        }
        private void addStudent2_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student(studentName.Text, studentSurname.Text, studentPhone.Text, (Class)Enum.Parse(typeof(Class), studentClass.Text), (Client)studentClient.SelectedItem, Tutor(studentTutor),(Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)studentGender.SelectedItem).Content.ToString()));
            studentList.AddStudent(newStudent);
            studentsListBox.ItemsSource = new ObservableCollection<Student>(studentList.Students);
            MessageBox.Show("Student added correctly.");
        }
        private void studentClient_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var filter = studentClient.Text.ToLower();
            if (clientList != null)
            {
                var filteredData = clientList.Clients
                    .Where(client => client.Name.ToLower().Contains(filter) || client.Surname.ToLower().Contains(filter)).ToList();

                studentClient.ItemsSource = filteredData;
                studentClient.IsDropDownOpen = true;
            }
            else
            {
                studentClient.ItemsSource = null;
                studentClient.IsDropDownOpen = false;
            }
        }

        private Tutor Tutor(TextBox studentTutor)
        {
            
            throw new NotImplementedException();
        }
        
        private Client Client(ComboBox studentClient)
        {
            throw new NotImplementedException();
        }
    }
}
