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
    public class Rental
    {
        [DataMember]
        public int Rental_ID {get ;set;}

        [DataMember]
        public DateTime Rental_Date { get; set; }

        [DataMember]
        public DateTime Return_Date { get; set; }
        
        [DataMember]
        public int Customer_ID { get; set; }
        public Customer Customer { get; set; } 

        [DataMember]
        public int Staff_ID { get; set; }
        public Staff Staff { get; set; }

        [DataMember]
        public int  Inventory_ID { get; set; }
        public Inventory Inventory { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }

        public ICollection<Payememt> payememts { get; set; }
    }

}
