using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSIbiblioteka.Models
{
    public class Clan
    {
        public int ClanId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ClanskiBroj { get; set; }
        public int SpolId { get; set; }
        public Spol Spol { get; set; }
    }
}
