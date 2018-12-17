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
    public class Payememt
    {
        [DataMember]
        public int Payement_ID { get; set; }

        [DataMember]
        public DateTime Payement_Date { get; set; }

        [DataMember]
        public decimal Amount { get; set; }


        [DataMember]
        public int Customer_ID { get; set; }
        public Customer Customer { get; set; }

        [DataMember]
        public int Staff_ID { get; set; }
        public Staff Staff { get; set; }

        [DataMember]
        public int Rental_ID { get; set; }
        public Rental Rental { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }
    }
}
