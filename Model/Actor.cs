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
  public  class Actor
    {

        [DataMember]
        public int ActorID { get; set; }
        [DataMember]
        [MaxLength(45)]
        public string Firstname { get; set; }
        [DataMember]
        [MaxLength(45)]
        public string Lastname { get; set; }
        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }
        public ICollection<Film_Actor> Film_actor { get; set; }
    }
}
