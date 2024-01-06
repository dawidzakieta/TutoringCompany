using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
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
    public partial class AddTutor : Window
    {

        private TutorList tutorList;

        public AddTutor(TutorList tutorList)
        {
            InitializeComponent();
            this.tutorList = tutorList;
        }
        private void addTutor_Click(object sender, RoutedEventArgs e)
        {
            decimal rateValue;
            if (decimal.TryParse(rate.Text, out rateValue))
            {
                Tutor newTutor = new Tutor(name.Text, surname.Text, rateValue, phone.Text, email.Text, (Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)gender.SelectedItem).Content.ToString()));
                tutorList.AddTutor(newTutor);
                MessageBox.Show("Tutor added correctly.");
            }
            else
            {
                MessageBox.Show("Invalid value for hour rate. Please enter a valid decimal number.");
            }
        }
    }
}
