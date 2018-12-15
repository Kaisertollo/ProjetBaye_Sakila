using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBaye_Sakila.Model
{
    [DataContract]
    public class Customer:Personne
    {
        [DataMember]
        public int Customer_ID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int Address_ID { get; set; }
        public Address Address { get; set; }

        [DataMember]
        public int? Store_ID { get; set; }
        public Store Store { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }

        [DataMember]
        public String Active { get; set; }

        [DataMember]
        public DateTime Create_Date { get; set; }
    }
}
