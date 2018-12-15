using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ProjetBaye_Sakila.Model
{
    public class Country
    {
        [DataMember]
        public int Country_ID { get; set; }

        [DataMember]
        public string Country_Lib { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }
        [DataMember]
        public ICollection<City> Cities  { get; set; }
    }
}