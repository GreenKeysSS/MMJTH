using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;
using System.Data;

namespace Domain
{
    public class ClientModel
    {

        ClientAccess client = new ClientAccess();
        public DataTable ListClients()
        {

            return client.ListClients();
        }

        public void DeleteClient(int clientcode)
        {

            client.DeleteClient(clientcode);
        }
        public void UpdateClientData(int clientcode, string clientname, string movil, string email, string address, string fijo)
        {
            client.UpdateClientData(clientcode, clientname, movil, email, address, fijo);
        }

        public void InsertNewClient(string clientname, string movil, string email, string address, string fijo, DateTime dt)
        {

            client.InsertNewClient(clientname, movil, email, address, fijo, dt);

        }

        public bool SearchClientByName(string clientname)
        {
            return client.SearchClientByName(clientname);
        }

        public DataTable ListClientBySearch(string tosearch) {
           return  client.ListClientBySearch(tosearch);
        }
    }

}
