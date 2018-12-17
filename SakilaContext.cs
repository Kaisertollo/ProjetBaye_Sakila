using ProjetBaye_Sakila.Model;
using PROJETBAYE2018.Modeltest;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBaye_Sakila
{
    using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
    public class BdContext:DbContext
    {
        public BdContext():base("name=SakilaContext")
        {
            Database.SetInitializer<BdContext>(new DropCreateDatabaseIfModelChanges<BdContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*Configuration Country
             *PrimaryKey
             * Personalisation Column Country Nom et Taille 
             */
            modelBuilder.Entity<Country>()
                .HasKey<int>(X => X.Country_ID);
            modelBuilder.Entity<Country>().ToTable("Country");
            modelBuilder.Entity<Country>()
                .Property(X => X.Country_Lib)
                .HasColumnName("Country")
                .HasMaxLength(50);

            /*Configuration City
             * PrimaryKEY
             * ForeignKEY Country_ID
             * Personalisation Column City Nom et Taille
             * */
            modelBuilder.Entity<City>()
               .HasKey<int>(X => X.City_ID);
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<City>()
                .Property(X => X.City_Lib)
                .HasColumnName("City")
                .HasMaxLength(50);

            

            /*Configuration Adress
             * PrimaryKEY
             *  Personalisation Column Address and Adress2 Nom et Taille
             * taille phone postal_code District
             * ForeignKEY City_ID
              */
            modelBuilder.Entity<Address>()
               .HasKey<int>(X => X.Address_ID);
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Address>()
                .Property(X => X.Address_Lib)
                .HasColumnName("Address")
                .HasMaxLength(50);

            modelBuilder.Entity<Address>()
                .Property(X => X.Address_Lib2)
                .HasColumnName("Address2")
                .HasMaxLength(50);

            modelBuilder.Entity<Address>().Property(X => X.Phone)
                .HasMaxLength(20);
            modelBuilder.Entity<Address>().Property(X => X.Postal_Code)
                .HasMaxLength(10);
            modelBuilder.Entity<Address>().Property(X => X.District)
                .HasMaxLength(20);

           

            

            /*Configuration Store
             * PrimaryKEY
             * ForeignKEY Address_ID
             * ForeignKEY Manager_Staff_ID
              */

            modelBuilder.Entity<Store>()
               .HasKey<int>(X => X.Store_ID);

            modelBuilder.Entity<Store>().ToTable("Store");
            modelBuilder.Entity<Payememt>()
                .HasRequired(X => X.Rental)
                .WithMany(X => X.payememts)
                .HasForeignKey<int>(X => X.Rental_ID)
                .WillCascadeOnDelete(false); ;

            /*modelBuilder.Entity<Store>()
               .HasRequired(X => X.Staff)
               .WithMany(X => X.Stores)
               .HasForeignKey<int>(X => X.Manager_Staff_ID)
               .WillCascadeOnDelete(false); ;*/

            /*Configuration Staff
             * PrimaryKEY
             * ForeignKEY Address_ID
             * ForeignKEY Store_ID
              */

            modelBuilder.Entity<Staff>()
               .HasKey<int>(X => X.Staff_ID);
            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.Entity<Staff>()
                .HasOptional(X => X.Store)
                .WithMany(X => X.Staffs)
                .HasForeignKey(X => X.Store_ID);

            /*Configuration Customer
            * PrimaryKEY
            * ForeignKEY Address_ID
            * ForeignKEY Store_ID
             */
            modelBuilder.Entity<Customer>()
              .HasKey<int>(X => X.Customer_ID);
            modelBuilder.Entity<Customer>().ToTable("Customer");

            /*modelBuilder.Entity<Customer>()
                .HasRequired(X => X.Store)
                .WithMany(X => X.Customers)
                .HasForeignKey(X => X.Store_ID);

            modelBuilder.Entity<Customer>()
               .HasRequired(X => X.Address)
               .WithMany(X => X.Customers)
               .HasForeignKey(X => X.Address_ID);*/

            /*Configuration Email,FirstName,LastName de Personne
             * Active CUSTOMER Column 
             */
            modelBuilder.Entity<Staff>().Property(X => X.FirstName)
               .HasMaxLength(45);
            modelBuilder.Entity<Customer>().Property(X => X.FirstName)
                .HasMaxLength(45);

            modelBuilder.Entity<Staff>().Property(X => X.LastName)
               .HasMaxLength(45);
            modelBuilder.Entity<Customer>().Property(X => X.LastName)
                .HasMaxLength(45);

            modelBuilder.Entity<Staff>().Property(X => X.Email)
               .HasMaxLength(50);
            modelBuilder.Entity<Customer>().Property(X => X.Email)
                .HasMaxLength(50);

            modelBuilder.Entity<Customer>().Property(X => X.Active)
                .HasMaxLength(1);

            modelBuilder.Entity<Staff>().Property(X => X.Picture)
               .HasColumnType("VarBinary(Max)");

            modelBuilder.Entity<Staff>().Property(X => X.Password)
             .HasMaxLength(40);
            modelBuilder.Entity<Staff>().Property(X => X.UserName)
               .HasMaxLength(16);
            ///Thioune's Modifs
            ///
            ///ForeignKEy and TableName
            modelBuilder.Entity<Film>()
                .ToTable("Film")
                .HasRequired(X => X.Language1)
                .WithMany(X => X.Films)
                .HasForeignKey<int>(X => X.LanguageID).WillCascadeOnDelete(false);

            modelBuilder.Entity<Film>().HasKey(X => X.Film_ID);

            modelBuilder.Entity<Film>()
                .ToTable("Film")
                .HasRequired(X => X.Language2)
                .WithMany(X => X.OFilms)
                .HasForeignKey<int>(X => X.Original_Language_ID).WillCascadeOnDelete(false);

            modelBuilder.Entity<Film_Category>()
                .ToTable("Film_Category")
                .HasRequired(X => X.Film)
                .WithMany(X => X.Film_Categories)
                .HasForeignKey<int>(X => X.Film_ID).WillCascadeOnDelete(false);

            modelBuilder.Entity<Film_Category>()
               .ToTable("Film_Category")
               .HasRequired(X => X.Category)
               .WithMany(X => X.Film_Categories)
               .HasForeignKey<int>(X => X.Category_ID).WillCascadeOnDelete(false);
            //Configure composite primary key
            modelBuilder.Entity<Film_Category>().HasKey(f => new { f.Category_ID, f.Film_ID });

            modelBuilder.Entity<Film_Actor>()
               .ToTable("Film_Actor")
               .HasRequired(X => X.Actor)
               .WithMany(X => X.Film_actor)
               .HasForeignKey<int>(X => X.Actor_ID).WillCascadeOnDelete(false);
            modelBuilder.Entity<Film_Actor>()
               .ToTable("Film_Actor")
               .HasRequired(X => X.Film)
               .WithMany(X => X.Film_Actor)
               .HasForeignKey<int>(X => X.Film_ID).WillCascadeOnDelete(false);

            modelBuilder.Entity<Film_Actor>().HasKey(f => new { f.Actor_ID, f.Film_ID });

            modelBuilder.Entity<Film>().Property(X => X.Description).HasColumnType("text");
            modelBuilder.Entity<Film>().Property(X => X.Rental_rate).HasPrecision(4, 2);
            modelBuilder.Entity<Film>().Property(X => X.Replacement_cost).HasPrecision(5, 2);


            modelBuilder.Entity<Inventory>().HasKey<int>(i => i.Inventory_ID);
            modelBuilder.Entity<Inventory>().ToTable("Inventory");

            modelBuilder.Entity<Rental>().HasKey<int>(i => i.Rental_ID);
            modelBuilder.Entity<Rental>().ToTable("Rental");

            modelBuilder.Entity<Payememt>().HasKey<int>(i => i.Payement_ID);
            modelBuilder.Entity<Payememt>().ToTable("Payement");
            modelBuilder.Entity<Payememt>().Property(X => X.Amount).HasPrecision(5, 2);

        }


       public DbSet<Country> Countries { get; set; }
       public DbSet<City> Cities { get; set; }
       public DbSet<Address> Adresses { get; set; }
       public DbSet<Store> Stores { get; set; }
       public DbSet<Staff> Staffs { get; set; }
       public DbSet<Customer> Customers { get; set; }
        ///Thioune
        public DbSet<Language> Languages { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film_Actor> Film_Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Film_Category> Film_Categories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Rental> Rentals{ get; set; }
        public DbSet<Payememt> Payememts { get; set; }

    }
}
