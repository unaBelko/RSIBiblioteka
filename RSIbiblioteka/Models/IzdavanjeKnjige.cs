using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSIbiblioteka.Models
{
    public class IzdavanjeKnjige
    {
        public int IzdavanjeKnjigeId { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
        public int BibliotekarId { get; set; }
        public Bibliotekar Bibliotekar { get; set; }
        public int KnjigaId { get; set; }
        public Knjiga Knjiga { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public int BrojDana { get; set; }
    }
}
