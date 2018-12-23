using ProjetBaye_Sakila.Model;
using PROJETBAYE2018.Modeltest;
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
        ICollection<Country> GetCountries();
        [OperationContract]
        ICollection<City> GetCities();
        [OperationContract]
        ICollection<Address> GetAddresses();

        [OperationContract]
        void AddStores(Store store);
        [OperationContract]
        ICollection<Store> GetStores();
        [OperationContract]
        void UpdateStaff_Store(int idStaff, int IdStore);
        

        /// <summary>
        /// Staff
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        ICollection<Staff> GetStaffs();
        [OperationContract]
        string AddStaff2(Staff staff);
        [OperationContract]
        void UpdateStaff(Staff S,int id);
        [OperationContract]
        void Block(int id);
        [OperationContract]
        void DeBlock(int id);
      

        [OperationContract]
        void AddAddress(Address address);
       
        [OperationContract]
        int LastIdStore();

        [OperationContract]
        ICollection<Film>GetFilms();

      
       
        //[OperationContract]
        //void GlobalAd(Object a);
    }
}
