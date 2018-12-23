using PROJETBAYE2018.Modeltest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjetBaye_Sakila
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IThiouneService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IThiouneService
    {
        [OperationContract]
        void Ajouterfilm(Film F);

        [OperationContract]
        void ajouterfilm_actor(Film_Actor fa);

        [OperationContract]
        void ajouterfilm_categories(Film_Category fc);

        [OperationContract]
        List<Film> Film_Par_Categorie1(String categori);

        [OperationContract]
        List<Film> Film_Par_Categorie2(String categori1, String categori2);

        [OperationContract]
        List<Film> Film_Par_Acteur(string act);
        [OperationContract]
        List<Film> Film_Par_Langue(string langue);
        [OperationContract]
        ICollection<Film> GetFilms();

        [OperationContract]
        ICollection<Language> GetLang();

        [OperationContract]
        ICollection<Category> GetCat();

        [OperationContract]
        ICollection<Actor> GetActor();

        [OperationContract]
        void ajouterActor(Actor fa);
        [OperationContract]
        int LastIdFilm();

        [OperationContract]
        void AddFilms(Film F,List<Actor>Actor, List<Category> Category);

        [OperationContract]
        void AddActors(Actor A, ICollection<Film> F);
    }
}
