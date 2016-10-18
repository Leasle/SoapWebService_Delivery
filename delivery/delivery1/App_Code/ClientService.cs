using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using delivery1.App_Code.Model;
using delivery1.DAL;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя класса "ClientService" в коде, системе контроля версий и файле конфигурации.
namespace delivery1
{
    public class ClientService : IClientService
    {
        DeliveryDBContext deliverydb = new DeliveryDBContext();

        public void AddClient(Client client)
        {
            //deliverydb.Database.Delete();

            deliverydb.Clients.Add(client);
            deliverydb.SaveChanges();
        }

        public List<Client> AllClient()
        {
            return deliverydb.Clients.ToList();
        }

        public void DeleteClient(int id)
        {
            Client client = deliverydb.Clients.Find(id);

            if (client != null)
            {
                deliverydb.Clients.Remove(client);
                deliverydb.SaveChanges();
            }
        }

        public void EditClient(Client client)
        {
            deliverydb.Entry(client).State = System.Data.Entity.EntityState.Modified;
            deliverydb.SaveChanges();
        }

        public Client FindClient(int id)
        {
            return deliverydb.Clients.Find(id);
        }
    }
}
