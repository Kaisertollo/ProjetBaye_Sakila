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
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "fundamentals" à la fois dans le code et le fichier de configuration.
    public class fundamentals : Ifundamentals
    {
        BdContext Context = new BdContext();

        public void AddAddress(Address a)
        {
            try
            {
                Context.Adresses.Add(a);
                Context.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
        }

      
        //STAFF
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
        public void Block(int id)
        {
            try
            {
                Staff S = Context.Staffs.Find(id);
                S.Active = 0;
                Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeBlock(int id)
        {
            try
            {
                Staff S = Context.Staffs.Find(id);
                S.Active = 1;
                Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddStores(Store store)
        {
            Context.Stores.Add(store);
            Context.SaveChanges();
        }
        public ICollection<Staff> GetStaffs()
        {
            return Context.Staffs.ToList();
        }
        public void UpdateStaff(Staff S, int id)
        {
            try
            {
                Staff s = Context.Staffs.Find(id);
                s = S;
                Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //STORE
        public ICollection<Store> GetStores()
        {
            try
            {
                return Context.Stores.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void UpdateStaff_Store(int idStaff, int IdStore)
        {
            try
            {
                Staff s = Context.Staffs.Find(idStaff);
                s.Store_ID = IdStore;
                Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int LastIdStore()
        {
            List<Store> s = Context.Stores.ToList();
            return s[s.Count - 1].Store_ID;
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

        
        /// <summary>
        /// ADRESSE 
        /// </summary>
        /// <returns></returns>
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



        public ICollection<Film> GetFilms()
        {
            return Context.Films.ToList();
        }

      


        /*public void GlobalAdd<T>(T a)
        {
            Context.Set<Staff>.Add(a);
        }*/




    }
}
