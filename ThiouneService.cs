using PROJETBAYE2018.Modeltest;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjetBaye_Sakila
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ThiouneService" à la fois dans le code et le fichier de configuration.
    public class ThiouneService : IThiouneService
    {
        BdContext Context = new BdContext();
        public void Ajouterfilm(Film F)
        {
            try
            {


                Context.Films.Add(F);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public void ajouterfilm_actor(Film_Actor fa)
        {
            try
            {


                Context.Film_Actors.Add(fa);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public void ajouterfilm_categories(Film_Category fc)
        {
            try
            {


                Context.Film_Categories.Add(fc);
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }


        }

        public List<Film> Film_Par_Categorie1(string categori)
        {
            return Context.Films.SqlQuery("select * from Film inner join Film_Category fc on Film.Film_ID=fc.Film_ID " +
                "inner join Categories c on c.CategoryID=fc.Category_ID Where c.Name=@cat", new SqlParameter("@cat", categori)).ToList<Film>();

        }

        public List<Film> Film_Par_Categorie2(string categori1, string categori2)
        {
            return Context.Films.SqlQuery("select * from Film f inner join  Film_Category fc on f.Film_ID=fc.Film_ID" +
                " inner join " +
                "Category c on c.CategoryID=fc.CategoryID Where c.Name=@cat1 and c.Name=@cat2", new SqlParameter("@cat1", categori1), new SqlParameter("@cat2", categori2)).ToList<Film>();
        }
        public List<Film> Film_Par_Acteur(string acteur)
        {
            return Context.Films.SqlQuery("select * from Film f inner join Film_Actor fa on f.Film_ID =fa.Film_ID " +
                 "inner join Actor a on a.ActorID =fa.ActorID Where a.Firstname = @act " +
                 "and a.Lastname = @act ", new SqlParameter("@act", acteur)).ToList<Film>();


        }

        public List<Film> Film_Par_Langue(string langue)
        {
            return Context.Films.SqlQuery("select * from Film f inner join Languages l" +
                " on f.LanguageID = l.LanguageID Where l.Name=@act1", new SqlParameter("@act1", langue)).ToList<Film>();
        }
    }
}
