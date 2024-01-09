using System;
using System.Windows;
using System.Windows.Controls;
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
                clientsListBox.ItemsSource = clientList.Clients;
                MessageBox.Show("Client added correctly.");
            }
            else
            {
                MessageBox.Show("Invalid value for hour rate. Please enter a valid decimal number.");
            }
        }
    }
}
