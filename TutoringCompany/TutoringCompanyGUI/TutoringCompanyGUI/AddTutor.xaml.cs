using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    public partial class AddTutor : WindowBase
    {

        private TutorList tutorList;
        private ListBox tutorsListBox;

        public AddTutor(TutorList tutorList, ListBox tutorsListBox)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add tutors");

            this.tutorList = tutorList;
            this.tutorsListBox = tutorsListBox;
        }
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
