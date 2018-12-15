using ProjetBaye_Sakila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjetBaye_Sakila
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "Ifundamentals" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface Ifundamentals
    {
        [OperationContract]
        void Ajouter();

        [OperationContract]
        ICollection<Store> GetStores();

        [OperationContract]
        ICollection<Country> GetCountries();

        [OperationContract]
        ICollection<Staff> GetStaffs();

        [OperationContract]
        ICollection<City> GetCities();

        [OperationContract]
        ICollection<Address> GetAddresses();


        [OperationContract]
        void AddStores(Store store);

        [OperationContract]
        void AddStaff(Staff staff);

        [OperationContract]
       string AddStaff2(Staff staff);

        [OperationContract]
        void AddAddress(Address address);

        

    }
}
