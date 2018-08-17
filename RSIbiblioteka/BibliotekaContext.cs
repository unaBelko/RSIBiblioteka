using Microsoft.EntityFrameworkCore;
using RSIbiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSIbiblioteka
{
    public class BibliotekaContext:DbContext 
    {
        public BibliotekaContext(DbContextOptions<BibliotekaContext> options):base(options)
        {

        }
        public DbSet<Autor> Autori { get; set; }
        public DbSet<AutorKnjiga> AutoriKnjige{ get; set; }
        public DbSet<Bibliotekar> Bibliotekari { get; set; }
        public DbSet<Clan> Clanovi { get; set; }
        public DbSet<IzdavanjeKnjige> IzdavanjeKnjiga { get; set; }
        public DbSet<Knjiga> Knjige { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
    }
}
