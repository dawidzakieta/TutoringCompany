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
    public partial class Tutors : WindowBase
    {
        private TutorList tutorList;

        public Tutors(TutorList tutorList)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Tutors");

            this.tutorList = tutorList ?? new TutorList();

            tutorsListBox.ItemsSource = this.tutorList.Tutors;
        }

        private void addTutor_Click(object sender, RoutedEventArgs e)
        {
            AddTutor addTutorWindow = new AddTutor(tutorList, tutorsListBox);
            addTutorWindow.Show();
        }

        private void deleteTutor_Click(object sender, RoutedEventArgs e)
        {
            if (tutorsListBox.SelectedItem != null)
            {
                Tutor selectedtutor = (Tutor)tutorsListBox.SelectedItem;
                tutorList.RemoveTutor(selectedtutor);
                MessageBox.Show("tutor removed successfully.");
            }
            else
            {
                MessageBox.Show("Please select a tutor to remove.");
            }
        }
        private void sortTutor_Click(object sender, RoutedEventArgs e)
        {
            tutorList.Sort();
            tutorsListBox.ItemsSource = tutorList.Tutors;
        }
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            if (tutorList != null)
            {
                var filteredTutors = tutorList.Tutors
                    .Where(tutor =>
                        tutor.Name.ToLower().Contains(searchText) ||
                        tutor.Surname.ToLower().Contains(searchText) ||
                        tutor.PhoneNumber.Contains(searchText) ||
                        tutor.Email.ToLower().Contains(searchText));

                tutorsListBox.ItemsSource = new ObservableCollection<Tutor>(filteredTutors.ToList());
            }
            else
            {
                tutorsListBox.ItemsSource = null;
            }
        }
        #region TextBox
        private void TextBox_GotFocus(object sender, RoutedEventArgs e) {
            if (searchBox.Text == "Search Tutors") { searchBox.Text = ""; }
        }
        #endregion
    }
}
