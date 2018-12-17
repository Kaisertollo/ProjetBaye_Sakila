using PROJETBAYE2018.Modeltest;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBaye_Sakila.Model
{
    [DataContract]
    public class Inventory
    {
        [DataMember]
        public int Inventory_ID { get;  set; }

        [DataMember]
        public int Film_ID { get; set; }
        public Film Film { get; set; }

        [DataMember]
        public int Store_ID { get; set; }
        public Store Store { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }

        public ICollection<Rental> Rentals { get; set; }

    }
}
