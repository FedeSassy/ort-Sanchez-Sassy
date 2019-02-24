using System.Linq;
using System.Collections.Generic;
using TP_NT_Taller_Meacanico.Models;

namespace TP_NT_Taller_Meacanico.Models
{
    public class DBWrapper
    {
        private ProyectoORTEntities5 dbObject;
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

            dbObject.Clients.Add(client);
            dbObject.SaveChanges();
        }

        public int RemoveClientByPersonalID(int personalID)
        {
            Client client = GetClientByPersonalID(personalID);
            dbObject.Clients.Remove(client);
            return dbObject.SaveChanges();
        }
    }
}