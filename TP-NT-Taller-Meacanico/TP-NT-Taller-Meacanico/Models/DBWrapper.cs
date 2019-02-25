using System.Linq;
using System.Collections.Generic;
using TP_NT_Taller_Meacanico.Models;

namespace TP_NT_Taller_Meacanico.Models
{
    public class DBWrapper
    {
        private ProyectoORTEntities5 dbObject;
        private const int ERROR_SAVING = 0;

        public DBWrapper()
        {
            dbObject = new ProyectoORTEntities5();
        }

        public int CloseOrderByID(int orderID, decimal total)
        {
            Order orderToClose = GetOrderByID(orderID);
            if (orderToClose != null)
            {
                orderToClose.total = total;
                orderToClose.state = "DONE";
                orderToClose.date_ended = Utils.Util.GetCurrentTime();

                return dbObject.SaveChanges();
            }

            return ERROR_SAVING;
        }

        public string GetWorkShopName()
        {
            return dbObject.Mechanical_Workshop.First().name;
        }

        public List<Order> GetAllOrders()
        {
            return dbObject.Orders.ToList();
        }

        public List<Client> GetAllClients()
        {
            return dbObject.Clients.ToList();
        }

        public Order GetOrderByID(int id)
        {
            return dbObject.Orders.Find(id);
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

        public List<AutoPartsOrderWrapper> GetAllAutopartsByOrderID(int orderID)
        {
            List<Order_Autopart> orderAutopartsRelations = dbObject.Order_Autopart.Where(a => a.order_id == orderID).ToList();

            if (orderAutopartsRelations != null && orderAutopartsRelations.Count() > 0)
            {
                AutoPartsOrderWrapper aoObject = null;
                List<AutoPartsOrderWrapper> autoparts = new List<AutoPartsOrderWrapper>();
                foreach (Order_Autopart oa in orderAutopartsRelations)
                {
                    Autopart autopart = dbObject.Autoparts.Find(oa.autopart_id);
                    if (autopart != null)
                    {
                        aoObject = new AutoPartsOrderWrapper
                        {
                            name = autopart.name,
                            price = autopart.price,
                            hours = oa.hours,
                            quantity = oa.quantity
                        };

                        autoparts.Add(aoObject);
                    }
                }

                return autoparts;
            }

            return null;
        }

        public List<Autopart> GetAllAutoparts()
        {
            return dbObject.Autoparts.ToList();
        }

        public void AddAutoPartOrder(Order_Autopart oa)
        {
            Order updatedOrder = GetOrderByID(oa.order_id);
            if (updatedOrder.state == "PEND")
            {
                updatedOrder.state = "WIP";
            }

            dbObject.Order_Autopart.Add(oa);
            dbObject.SaveChanges();
        }
    }
}