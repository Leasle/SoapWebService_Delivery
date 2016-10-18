using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using delivery1.App_Code.Model;
using delivery1.DAL;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя класса "OrderService" в коде, системе контроля версий и файле конфигурации.
namespace delivery1
{
    public class OrderService : IOrderService
    {
        DeliveryDBContext deliverydb = new DeliveryDBContext();

        public void AddOrder(Order order)
        {
            deliverydb.Orders.Add(order);
            deliverydb.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            Order order = deliverydb.Orders.Find(id);
            if (order != null)
            {
                deliverydb.Orders.Remove(order);
                deliverydb.SaveChanges();
            }
        }

        public void EditLoader(Order order)
        {
            deliverydb.Entry(order).State = System.Data.Entity.EntityState.Modified;
            deliverydb.SaveChanges();
        }

        public List<Order> FindAllOrders()
        {
            return deliverydb.Orders.ToList();
        }

        public Order FindOrder(int id)
        {
            return deliverydb.Orders.Find(id);
        }
    }
}
