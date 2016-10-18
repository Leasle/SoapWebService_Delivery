using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using delivery1.App_Code.Model;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IItemService" в коде и файле конфигурации.
namespace delivery1
{
    [ServiceContract]
    public interface IItemService
    {
        [OperationContract]
        void AddItem(Item item);

        [OperationContract]
        void DeleteItem(int id);

        [OperationContract]
        void EditItem(Item item);

        [OperationContract]
        Item FindItem(int id);

        [OperationContract]
        List<Item> AllItems();     
    }
}
