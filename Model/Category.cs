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
    public class Category
    {
        [DataMember]
        public int CategoryID { get; set; }

        [DataMember]
        [MaxLength(25)]
        public string Name { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }

        [DataMember]
        public ICollection<Film_Category> Film_Categories { get; set; }

    }
}
