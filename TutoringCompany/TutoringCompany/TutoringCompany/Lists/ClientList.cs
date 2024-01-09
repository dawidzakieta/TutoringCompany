using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringCompany
{
    public class ClientList {
        private ObservableCollection<Client> clients = new ObservableCollection<Client>();
        public ObservableCollection<Client> Clients => clients;
        public void AddClient(Client client)
        {
            clients.Add(client);
        }
        public void RemoveClient(Client client)
        {
            clients.Remove(client);
        }
        public void Sort()
        {
            ObservableCollection<Client> sortedClients = new ObservableCollection<Client>(clients.OrderBy(client => client.Surname));
            clients.Clear();
            clients = sortedClients;
        }
    }
}
