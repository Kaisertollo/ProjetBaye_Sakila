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
    public class Address
    {
        [DataMember]
        public int Address_ID { get; set; }

        [DataMember]
        public string Address_Lib { get; set; }

        [DataMember]
        public string Address_Lib2 { get; set; }

        [DataMember]
        public string District { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Postal_Code { get; set; }

        [DataMember]       
        public int? City_ID { get; set; }
        public City City { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }


        public ICollection<Staff> Staffs { get; set; }

       
        public ICollection<Store> Stores { get; set; }
        
        public ICollection<Customer> Customers { get; set; }

    }
}
