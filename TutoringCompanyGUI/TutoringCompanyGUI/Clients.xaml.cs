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

namespace TutoringCompanyGUI {
    public partial class Clients : WindowBase {
        private ClientList clientList;

        public Clients(ClientList clientList) {
            InitializeComponent();
            TitleBar(TitleContent, "Clients");

            this.clientList = clientList ?? new ClientList();

            clientsListBox.ItemsSource = this.clientList.Clients;
        }

        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClientWindow = new AddClient(clientList);
            addClientWindow.Show();
        }

        private void deleteClient_Click(object sender, RoutedEventArgs e)
        {
            if (clientsListBox.SelectedItem != null)
            {
                Client selectedClient = (Client)clientsListBox.SelectedItem;
                clientList.RemoveClient(selectedClient);
                MessageBox.Show("Client removed successfully.");
            }
            else
            {
                MessageBox.Show("Please select a client to remove.");
            }
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            if (clientList != null)
            {
                var filteredClients = clientList.Clients
                    .Where(client =>
                        client.Name.ToLower().Contains(searchText) ||
                        client.Surname.ToLower().Contains(searchText) ||
                        client.PhoneNumber.Contains(searchText) ||
                        client.Email.ToLower().Contains(searchText));

                clientsListBox.ItemsSource = new ObservableCollection<Client>(filteredClients.ToList());
            }
            else
            {
                clientsListBox.ItemsSource = null;
            }
        }
    }
}
