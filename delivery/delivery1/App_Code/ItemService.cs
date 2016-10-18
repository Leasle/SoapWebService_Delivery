using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using delivery1.App_Code.Model;
using delivery1.DAL;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя класса "ItemService" в коде, системе контроля версий и файле конфигурации.
namespace delivery1
{
    public class ItemService : IItemService
    {
        DeliveryDBContext deliverydb = new DeliveryDBContext();

        public void AddItem(Item item)
        {
            deliverydb.Items.Add(item);
            deliverydb.SaveChanges();
        }

        public List<Item> AllItems()
        {
            return deliverydb.Items.ToList();
        }

        public void DeleteItem(int id)
        {
            Item item = deliverydb.Items.Find(id);
            if (item != null)
            {
                deliverydb.Items.Remove(item);
                deliverydb.SaveChanges();
            }
        }

        public void EditItem(Item item)
        {
            deliverydb.Entry(item).State = System.Data.Entity.EntityState.Modified;
            deliverydb.SaveChanges();
        }

        public Item FindItem(int id)
        {
            return deliverydb.Items.Find(id);
        }
    }
}
