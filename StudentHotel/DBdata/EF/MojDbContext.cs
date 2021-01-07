using DBdata.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBdata.EF
{
    public class MojDbContext:DbContext
    {
        public DbSet<CiklusStudija> CiklusStudijas { get; set; }
        public DbSet<DnevnaPonuda> DnevnaPonudas { get; set; }
        public DbSet<Drzava> Drzavas { get; set; }
        public DbSet<Fakultet> Fakultets { get; set; }
        public DbSet<GodinaStudija> GodinaStudijas { get; set; }
        public DbSet<Grad> Grads { get; set; }
        public DbSet<Kanton> Kantons { get; set; }
        public DbSet<Pol> Pols { get; set; }
        public DbSet<Kartica> Karticas { get; set; }
        public DbSet<Konkurs> Konkurs { get; set; }
        public DbSet<Kuharica> Kuharicas { get; set; }
        public DbSet<Lokacija> Lokacijas { get; set; }
        public DbSet<NacinUplate> NacinUplates { get; set; }
        public DbSet<NajavaOdlaska> NajavaOdlaskas { get; set; }
        public DbSet<Obavijest> Obavijests { get; set; }
        public DbSet<Obrok> Obroks { get; set; }
        public DbSet<Osoblje> Osobljes { get; set; }
        public DbSet<Recepcioer> Recepcioers { get; set; }
        public DbSet<Soba> Sobas { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TipKandidata> tipKandidatas { get; set; }
        public DbSet<Ugovor> Ugovors { get; set; }
        public DbSet<Uplata> Uplatas { get; set; }
        public DbSet<Upozorenje> Upozorenjes { get; set; }
        public DbSet<VrstaStanjaZahtjeva> VrstaStanjaZahtjevas { get; set; }
        public DbSet<VrstaZahtjeva> VrstaZahtjevas { get; set; }
        public DbSet<Zahtjev> Zahtjevs { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@" Server=.;
                                        Database=StudentHotel4;   
                                        Trusted_Connection=true;
                                        MultipleActiveResultSets=true; ");
        }
    }
}
