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
    public partial class AddClient : WindowBase
    {
        
        private ClientList clientList;

        public AddClient(ClientList clientList)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add clients");

            this.clientList = clientList;
        }
        /*
        private void addClient1_Click(object sender, RoutedEventArgs e)
        {
            decimal rate1value;
            if (decimal.TryParse(rate1.Text, out rate1value))
            {
                Client newClient = new Client(name1.Text, phone1.Text, rate1value);
                clientList.AddClient(newClient);
                MessageBox.Show("Client added correctly.");
            }
            else
            {
                MessageBox.Show("Invalid value for hour rate. Please enter a valid decimal number.");
            }
        }
        */
        private void addClient2_Click(object sender, RoutedEventArgs e)
        {
            decimal rate2Value;
            if (decimal.TryParse(clientRate.Text, out rate2Value))
            {
                Client newClient = new Client(clientName.Text, clientSurname.Text, rate2Value, clientPhone.Text, clientEmail.Text, (Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)clientGender.SelectedItem).Content.ToString()));
                clientList.AddClient(newClient);
                MessageBox.Show("Client added correctly.");
            }
            else
            {
                MessageBox.Show("Invalid value for hour rate. Please enter a valid decimal number.");
            }
        }
    }
}
