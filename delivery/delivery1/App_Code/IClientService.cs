using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using delivery1.App_Code.Model;

// ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IClientService" в коде и файле конфигурации.
namespace delivery1
{
    [ServiceContract]
    public interface IClientService
    {
        [OperationContract]
        void AddClient(Client client);

        [OperationContract]
        void DeleteClient(int id);

        [OperationContract]
        void EditClient(Client client);

        [OperationContract]
        Client FindClient(int id);

        [OperationContract]
        List<Client> AllClient();
    }
}
