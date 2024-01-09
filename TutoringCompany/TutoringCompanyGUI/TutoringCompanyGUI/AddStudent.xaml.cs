﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
            Student newStudent = new Student(studentName.Text, studentSurname.Text, studentPhone.Text, (Class)Enum.Parse(typeof(Class), studentClass.Text), (Client)studentClient.SelectedItem, (Tutor)studentTutor.SelectedItem, (Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)studentGender.SelectedItem).Content.ToString()));
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
        private void studentTutor_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var filter = studentTutor.Text.ToLower();
            if (tutorList != null)
            {
                var filteredData = tutorList.Tutors
                    .Where(tutor => tutor.Name.ToLower().Contains(filter) || tutor.Surname.ToLower().Contains(filter)).ToList();

                studentTutor.ItemsSource = filteredData;
                studentTutor.IsDropDownOpen = true;
            }
            else
            {
                studentTutor.ItemsSource = null;
                studentTutor.IsDropDownOpen = false;
            }
        }
    }
}
