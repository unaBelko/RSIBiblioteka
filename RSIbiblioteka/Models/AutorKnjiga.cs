using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSIbiblioteka.Models
{
    public class AutorKnjiga
    {
        public int AutorKnjigaId { get; set; }
        public int AutorId { get; set; }
        public Autor Autor { get; set; }
        public int KnjigaId { get; set; }
        public Knjiga Knjiga { get; set; }
    }
}
