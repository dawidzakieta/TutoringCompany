    using System;
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.Windows.Controls;
    using TutoringCompany;

    namespace TutoringCompanyGUI
    {
        /// <summary>
        /// The AddTutor class represents a window in the Tutoring Company GUI application for adding new tutors.
        /// </summary>
        public partial class AddTutor : WindowBase
        {

            private TutorList tutorList;
            private ListBox tutorsListBox;
            /// <summary>
            /// Initializes a new instance of the AddTutor class.
            /// </summary>
            /// <param name="tutorList">The TutorList object that manages the list of tutors.</param>
            /// <param name="tutorsListBox">The ListBox control displaying the list of tutors.</param>
            public AddTutor(TutorList tutorList, ListBox tutorsListBox)
            {
                InitializeComponent();
                TitleBar(TitleContent, "Add tutors");

                this.tutorList = tutorList;
                this.tutorsListBox = tutorsListBox;
            }
            /// <summary>
            /// Event handler for the "addTutor_Click" event, triggered when the user clicks the "Add Tutor" button.
            /// Validates input, creates a new Tutor object, adds it to the tutorList, updates the tutorsListBox, and shows a confirmation message.
            /// </summary>
            /// <param name="sender">The object that raised the event.</param>
            /// <param name="e">Event arguments.</param>
            private void addTutor_Click(object sender, RoutedEventArgs e)
            {
                decimal rateValue;
                if (decimal.TryParse(tutorRate.Text, out rateValue))
                {
                    Tutor newTutor = new Tutor(tutorName.Text, tutorSurname.Text, rateValue, tutorPhone.Text, tutorEmail.Text, (Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)tutorGender.SelectedItem).Content.ToString()));
                    tutorList.AddTutor(newTutor);
                    tutorsListBox.ItemsSource = new ObservableCollection<Tutor>(tutorList.Tutors);
                    MessageBox.Show("Tutor added correctly.");
                }
                else MessageBox.Show("Invalid value for hour rate. Please enter a valid decimal number.");
            }
        }
    }
