using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The Clients class represents a window in the Tutoring Company GUI application for managing clients.
    /// </summary>
    public partial class Clients : WindowBase
    {
        private ClientList clientList;
        /// <summary>
        /// Initializes a new instance of the Clients class.
        /// </summary>
        /// <param name="clientList">The ClientList object that manages the list of clients.</param>
        public Clients(ClientList clientList)
        {
            InitializeComponent();

            TitleBar(TitleContent, "Clients");

            this.clientList = clientList ?? new ClientList();

            clientsListBox.ItemsSource = this.clientList.Clients;

            clientsListBox.ItemsSource = this.clientList.Clients;
        }
        /// <summary>
        /// Event handler for the "addClient_Click" event, triggered when the user clicks the "Add Client" button.
        /// Opens the AddClient window to add a new client.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClientWindow = new AddClient(clientList, clientsListBox);
            addClientWindow.Show();
        }
        /// <summary>
        /// Event handler for the "deleteClient_Click" event, triggered when the user clicks the "Delete Client" button.
        /// Removes the selected client from the clientList and shows a confirmation message.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
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
        /// <summary>
        /// Event handler for the "sortClient_Click" event, triggered when the user clicks the "Sort Clients" button.
        /// Sorts the clients in the clientList and updates the clientsListBox.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void sortClient_Click(object sender, RoutedEventArgs e)
        {
            clientList.Sort();
            clientsListBox.ItemsSource = clientList.Clients;
        }
        /// <summary>
        /// Event handler for the "searchBox_TextChanged" event, triggered when the text in the searchBox changes.
        /// Filters the displayed clients based on the entered search text.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = searchBox.Text.ToLower();

            if (searchText == "search clients") return;

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
            else clientsListBox.ItemsSource = null;
        }
        #region TextBox
        /// <summary>
        /// Event handler for the "TextBox_GotFocus" event, triggered when the searchBox receives focus.
        /// Clears the default placeholder text in the searchBox.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "Search clients") { searchBox.Text = ""; }
        }
        /// <summary>
        /// Event handler for the "TextBox_LostFocus" event, triggered when the searchBox loses focus.
        /// Sets the default placeholder text in the searchBox if it is empty.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
            {
                searchBox.Text = "Search clients";
            }
        }
        #endregion
    }
}
