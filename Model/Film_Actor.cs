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
    public class Film_Actor
    {
        [DataMember]
        public int Film_ActorID { get; set; }

        [DataMember]
        public int Film_ID { get; set; }
        public Film Film { get; set; }

        [DataMember]
        public int Actor_ID { get; set; }
        public Actor Actor { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }
      
        



    }
}
