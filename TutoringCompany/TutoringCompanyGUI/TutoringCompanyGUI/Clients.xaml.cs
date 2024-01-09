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

            clientsListBox.ItemsSource = this.clientList.Clients;
        }
        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClientWindow = new AddClient(clientList, clientsListBox);
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
        private void sortClient_Click(object sender, RoutedEventArgs e) { 
            clientList.Sort();
            clientsListBox.ItemsSource = clientList.Clients;
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchBox.Text.ToLower();
            
            if (searchText == "search clients") return;
            
            if (clientList != null) {
                var filteredClients = clientList.Clients
                    .Where(client =>
                        client.Name.ToLower().Contains(searchText) ||
                        client.Surname.ToLower().Contains(searchText) ||
                        client.PhoneNumber.Contains(searchText) ||
                        client.Email.ToLower().Contains(searchText));
                clientsListBox.ItemsSource = new ObservableCollection<Client>(filteredClients.ToList());
            }
            else clientsListBox.ItemsSource = null;
        }
       #region TextBox
        private void TextBox_GotFocus(object sender, RoutedEventArgs e) {
            if (searchBox.Text == "Search clients") { searchBox.Text = ""; }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(searchBox.Text)) {
                searchBox.Text = "Search clients";
            }
        }
        #endregion
    }
}
