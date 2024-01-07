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
        private ListBox clientsListBox;

        public AddClient(ClientList clientList, ListBox clientsListBox)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add clients");

            this.clientList = clientList;
            this.clientsListBox = clientsListBox;
        }
        private void addClient2_Click(object sender, RoutedEventArgs e)
        {
            decimal rate2Value;
            if (decimal.TryParse(clientRate.Text, out rate2Value))
            {
                Client newClient = new Client(clientName.Text, clientSurname.Text, rate2Value, clientPhone.Text, clientEmail.Text, (Gender)Enum.Parse(typeof(Gender), ((ComboBoxItem)clientGender.SelectedItem).Content.ToString()));
                clientList.AddClient(newClient);
                clientsListBox.ItemsSource = new ObservableCollection<Client>(clientList.Clients);
                MessageBox.Show("Client added correctly.");
            }
            else
            {
                MessageBox.Show("Invalid value for hour rate. Please enter a valid decimal number.");
            }
        }
    }
}
