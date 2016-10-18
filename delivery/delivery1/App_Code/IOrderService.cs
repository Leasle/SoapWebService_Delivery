using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using delivery1.App_Code.Model;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IOrderService" в коде и файле конфигурации.
namespace delivery1
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void AddOrder(Order order);

        [OperationContract]
        void DeleteOrder(int id);

        [OperationContract]
        Order FindOrder(int id);

        [OperationContract]
        List<Order> FindAllOrders();

        [OperationContract]
        void EditLoader(Order order);
    }
}
