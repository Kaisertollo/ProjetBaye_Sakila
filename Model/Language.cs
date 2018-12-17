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
   public class Language
    {
        [DataMember]
        public int LanguageID { get; set; }

        [DataMember]
        [MaxLength(20)]
        public string Name { get; set; }

        [Timestamp]
        public byte[] LAST_UPDATE { get; set; }
        [DataMember]
        public ICollection<Film> Films { get; set; }
        [DataMember]
        public ICollection<Film> OFilms { get; set; }
    }
}
