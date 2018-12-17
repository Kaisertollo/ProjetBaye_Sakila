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
     public class Film_Category
    {
        

        [DataMember]
        public int Film_ID { get; set; }
        public Film Film { get; set; }
        
        [DataMember]
        public int Category_ID { get; set; }
        public Category Category { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }
        
        
        
        
     

    }
}
