using ProjetBaye_Sakila.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PROJETBAYE2018.Modeltest
{
    [DataContract]
   public class Film
    {
        [DataMember]
        public int Film_ID { get; set; }
        [DataMember]
        [MaxLength(255)]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        [MaxLength(4)]
        public string Release_year { get; set; }
      
        [DataMember]
        public int Rental_duration { get; set; }

        [DataMember]
        public decimal Rental_rate { get; set; }

        [DataMember]
        public int Lenght { get; set; }

        [DataMember]
        public decimal Replacement_cost { get; set; }

        [DataMember]
        [MaxLength(10)]
        public string Rating { get; set; }

        [DataMember]
        [MaxLength(100)]
        public string Special_features { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }

        [DataMember]
        public int LanguageID { get; set; }
        public Language Language1 { get; set; }

        [DataMember]
        public int  Original_Language_ID { get; set; }
        public Language Language2 { get; set; }

        public ICollection<Film_Category> Film_Categories { get; set; }
        public ICollection<Film_Actor> Film_Actor { get; set; }
        public ICollection<Inventory> inventories { get; set; }
    }
}
