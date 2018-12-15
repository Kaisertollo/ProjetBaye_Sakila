using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ProjetBaye_Sakila.Model
{
    [DataContract]
    public class City
    {
        [DataMember]
        public int City_ID { get; set; }

        [DataMember]
        public string City_Lib { get; set; }

        [DataMember]
        public int? Country_ID { get; set; }
        [DataMember]
        public Country Country { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }

        public ICollection<Address> Adresses { get; set; }
    }
}