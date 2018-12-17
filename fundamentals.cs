using ProjetBaye_Sakila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjetBaye_Sakila
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "fundamentals" à la fois dans le code et le fichier de configuration.
    public class fundamentals : Ifundamentals
    {
        BdContext Context = new BdContext();

        public void AddAddress(Address a)
        {
            Context.Adresses.Add(a);
            
            Context.SaveChanges();
        }

        public void AddStaff(Staff staff)
        {
            Context.Staffs.Add(staff);
            Context.SaveChanges();
        }

        public string AddStaff2(Staff staff)
        {
            try
            {
                Context.Staffs.Add(staff);
                Context.SaveChanges();
                return "reussi";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public void AddStores(Store store)
        {
            Context.Stores.Add(store);
            Context.SaveChanges();
        }

        public void Ajouter()
        {

            //if (o is Country)
            //{
            Country c = new Country();
            c.Country_Lib = "Gambie";
            Context.Countries.Add(c);
            Context.SaveChanges();
            //}
        }

        public ICollection<Address> GetAddresses()
        {
            return Context.Adresses.ToList();
        }

        public ICollection<City> GetCities()
        {
            return Context.Cities.ToList();
        }

        public ICollection<Country> GetCountries()
        {
            return Context.Countries.ToList();
        }

        public ICollection<Staff> GetStaffs()
        {
            return Context.Staffs.ToList();
        }

        public ICollection<Store> GetStores()
        {
            return Context.Stores.ToList();
        }

        /*public void GlobalAdd<T>(T a)
        {
            Context.Set<Staff>.Add(a);
        }*/

      
        public int LastId()
        {
            List<Store> s = Context.Stores.ToList();
            return s[s.Count - 1].Store_ID;
        }

        public void UpdateStaff(int idStaff, int IdStore)
        {
            Staff s=Context.Staffs.Find(idStaff);
            s.Store_ID = IdStore;
            Context.SaveChanges();
        }
    }
}
