using System;
using System.Windows;
using System.Windows.Controls;
using TutoringCompany;

namespace TutoringCompanyGUI
{
    /// <summary>
    /// The AddClient class represents a window in the Tutoring Company GUI application for adding new clients.
    /// </summary>
    public partial class AddClient : WindowBase
    {
        private ClientList clientList;
        private ListBox clientsListBox;
        /// <summary>
        /// Initializes a new instance of the AddClient class.
        /// </summary>
        /// <param name="clientList">The ClientList object that manages the list of clients.</param>
        /// <param name="clientsListBox">The ListBox control displaying the list of clients.</param>
        public AddClient(ClientList clientList, ListBox clientsListBox)
        {
            InitializeComponent();
            TitleBar(TitleContent, "Add clients");

            this.clientList = clientList;
            this.clientsListBox = clientsListBox;
        }
        // <summary>
        /// Event handler for the "addClient2_Click" event, triggered when the user clicks the "Add Client" button.
        /// Validates input, creates a new Client object, adds it to the clientList, updates the clientsListBox, and shows a confirmation message.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
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
