using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSIbiblioteka.Models
{
    public class Bibliotekar
    {
        public int BibliotekarId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime PocetakRada { get; set; }
        public int SpolId { get; set; }
        public Spol Spol { get; set; }
    }
}
