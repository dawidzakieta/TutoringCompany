using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The Tutors class represents the window for managing tutor-related operations in the Tutoring Company GUI application.
    /// </summary>
    public partial class Tutors : WindowBase
    {
        private TutorList tutorList;
        /// <summary>
        /// Initializes a new instance of the Tutors class.
        /// </summary>
        /// <param name="tutorList">The list of tutors to be managed.</param>
        public Tutors(TutorList tutorList)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Tutors");

            this.tutorList = tutorList ?? new TutorList();

            tutorsListBox.ItemsSource = this.tutorList.Tutors;
        }
        /// <summary>
        /// Event handler for the "addTutor_Click" event, triggered when the "Add Tutor" button is clicked.
        /// Opens the AddTutor window to add a new tutor.
        /// </summary>
        private void addTutor_Click(object sender, RoutedEventArgs e)
        {
            AddTutor addTutorWindow = new AddTutor(tutorList, tutorsListBox);
            addTutorWindow.Show();
        }
        /// <summary>
        /// Event handler for the "deleteTutor_Click" event, triggered when the "Delete Tutor" button is clicked.
        /// Removes the selected tutor from the tutorList.
        /// </summary>
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
        /// <summary>
        /// Event handler for the "sortTutor_Click" event, triggered when the "Sort Tutors" button is clicked.
        /// Sorts the tutorList and updates the tutorsListBox data source.
        /// </summary>
        private void sortTutor_Click(object sender, RoutedEventArgs e)
        {
            tutorList.Sort();
            tutorsListBox.ItemsSource = tutorList.Tutors;
        }
        /// <summary>
        /// Event handler for the "searchBox_TextChanged" event, triggered when the text in the searchBox changes.
        /// Filters and updates the tutorsListBox based on the entered search text.
        /// </summary>
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
        /// <summary>
        /// Event handler for the "TextBox_GotFocus" event, triggered when the searchBox gets focus.
        /// Clears the default placeholder text if it is present.
        /// </summary>
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search Tutors") { searchBox.Text = ""; }
        }
        #endregion
    }
}
