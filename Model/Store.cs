using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ProjetBaye_Sakila.Model
{
    [DataContract]
    public class Store
    {
        [DataMember]
        public int Store_ID { get; set; }

        [DataMember]
        public int? Address_ID { get; set; }
        public Address Address { get; set; }

        [DataMember]
        [ForeignKey("Staff")]
        public int? Manager_Staff_ID { get; set; }
        public Staff Staff { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }


        public ICollection<Staff> Staffs { get; set; }

    }
}