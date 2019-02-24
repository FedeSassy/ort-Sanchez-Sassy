using System.Linq;
using System.Collections.Generic;
using TP_NT_Taller_Meacanico.Models;

namespace TP_NT_Taller_Meacanico.Models
{
    public class DBWrapper
    {
        private ProyectoORTEntities3 dbObject;
        private static int ERROR_SAVING = 0;

        public DBWrapper()
        {
            dbObject = new ProyectoORTEntities5();
        }

        public string GetWorkShopName()
        {
            return dbObject.Mechanical_Workshop.First().name;
        }

        public List<Client> GetAllClients()
        {
            return dbObject.Clients.ToList();
        }

        public Client GetClientByPersonalID(int personalID)
        {
            return dbObject.Clients.Where(c => c.personal_id == personalID).ToList().First();
        }

        public void AddClient(Client client)
        {
            client.workshop_id = 1;
            //TODO no harcodear el address_id
            client.address_id = 4;

            dbObject.Clients.Add(client);
            dbObject.SaveChanges();
        }

        public int RemoveClientByPersonalID(int personalID)
        {
            Client client = GetClientByPersonalID(personalID);
            Address clientAddress = GetAddressByClientID(client.id);
            if (RemoveAddressFirst(clientAddress) > 1)
            {
                dbObject.Clients.Remove(client);
                return dbObject.SaveChanges();
            } else
            {
                return ERROR_SAVING;
            }

        }

        private Address GetAddressByClientID(int clientID)
        {
            return dbObject.Addresses.Where(a => a.client_id == clientID).ToList().First();
        }

        private int RemoveAddressFirst(Address address)
        {
            dbObject.Addresses.Remove(address);
            return dbObject.SaveChanges();
        }
    }
}