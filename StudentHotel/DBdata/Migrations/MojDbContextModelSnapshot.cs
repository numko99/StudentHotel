﻿// <auto-generated />
using DBdata.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBdata.Migrations
{
    [DbContext(typeof(MojDbContext))]
    partial class MojDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DBdata.EntityModels.CiklusStudija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CiklusStudijas");
                });

            modelBuilder.Entity("DBdata.EntityModels.DnevnaPonuda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Datum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KarticaID")
                        .HasColumnType("int");

                    b.Property<int>("KuharicaID")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KarticaID");

                    b.HasIndex("KuharicaID");

                    b.ToTable("DnevnaPonudas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Drzava", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Drzavas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Fakultet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Fakultets");
                });

            modelBuilder.Entity("DBdata.EntityModels.GodinaStudija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GodinaStudijas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Grad", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("KantonID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KantonID");

                    b.ToTable("Grads");
                });

            modelBuilder.Entity("DBdata.EntityModels.Kanton", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kantons");
                });

            modelBuilder.Entity("DBdata.EntityModels.Kartica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BrojKartice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("StanjeNaKartici")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Karticas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Konkurs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojIndeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CiklusStudijaID")
                        .HasColumnType("int");

                    b.Property<string>("DatumRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FakultetID")
                        .HasColumnType("int");

                    b.Property<int>("GodinaStudijaID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImeOca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicnaKarta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MjestoRodjenjaID")
                        .HasColumnType("int");

                    b.Property<int>("MjestoStanovanjaID")
                        .HasColumnType("int");

                    b.Property<string>("Mjesto_izdavanja_LK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobitel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("TipKandidataID")
                        .HasColumnType("int");

                    b.Property<string>("ZanimanjeRoditelja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CiklusStudijaID");

                    b.HasIndex("DrzavaID");

                    b.HasIndex("FakultetID");

                    b.HasIndex("GodinaStudijaID");

                    b.HasIndex("MjestoRodjenjaID");

                    b.HasIndex("MjestoStanovanjaID");

                    b.HasIndex("StudentID");

                    b.HasIndex("TipKandidataID");

                    b.ToTable("Konkurs");
                });

            modelBuilder.Entity("DBdata.EntityModels.Lokacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MjestoStanovanjaID")
                        .HasColumnType("int");

                    b.Property<string>("PostanskiBroj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MjestoStanovanjaID");

                    b.ToTable("Lokacijas");
                });

            modelBuilder.Entity("DBdata.EntityModels.NacinUplate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("NacinUplates");
                });

            modelBuilder.Entity("DBdata.EntityModels.NajavaOdlaska", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DatumPolaska")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatumPovratka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UgovorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UgovorID");

                    b.ToTable("NajavaOdlaskas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Obavijest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DatumVrijeme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecepcioerID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RecepcioerID");

                    b.ToTable("Obavijests");
                });

            modelBuilder.Entity("DBdata.EntityModels.Obrok", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Datum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalji")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Iznos")
                        .HasColumnType("real");

                    b.Property<int>("KuharicaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KuharicaID");

                    b.ToTable("Obroks");
                });

            modelBuilder.Entity("DBdata.EntityModels.Osoblje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DatumRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DatumZaposlenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GodinaZaposlenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LokacijaID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("LokacijaID");

                    b.ToTable("Osobljes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Osoblje");
                });

            modelBuilder.Entity("DBdata.EntityModels.Soba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrojKreveta")
                        .HasColumnType("int");

                    b.Property<string>("BrojSobe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ImaBalkon")
                        .HasColumnType("bit");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sprat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Sobas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BrojIndeksa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CiklusStudijaID")
                        .HasColumnType("int");

                    b.Property<string>("DatumRodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FakultetID")
                        .HasColumnType("int");

                    b.Property<int>("GodinaStudijaID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImeOca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicnaKarta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LokacijaID")
                        .HasColumnType("int");

                    b.Property<int>("MjestoRodjenjaID")
                        .HasColumnType("int");

                    b.Property<string>("Mjesto_izdavanja_LK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobitel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipKandidataID")
                        .HasColumnType("int");

                    b.Property<bool>("Uselio")
                        .HasColumnType("bit");

                    b.Property<string>("ZanimanjeRoditelja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CiklusStudijaID");

                    b.HasIndex("FakultetID");

                    b.HasIndex("GodinaStudijaID");

                    b.HasIndex("LokacijaID");

                    b.HasIndex("MjestoRodjenjaID");

                    b.HasIndex("TipKandidataID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DBdata.EntityModels.TipKandidata", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("tipKandidatas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Ugovor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DodanUgovorOsobljeID")
                        .HasColumnType("int");

                    b.Property<int>("KarticaID")
                        .HasColumnType("int");

                    b.Property<int>("SobaID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DodanUgovorOsobljeID");

                    b.HasIndex("KarticaID");

                    b.HasIndex("SobaID");

                    b.HasIndex("StudentID");

                    b.ToTable("Ugovors");
                });

            modelBuilder.Entity("DBdata.EntityModels.Uplata", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Datum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NacinUplateID")
                        .HasColumnType("int");

                    b.Property<int>("RecepcioerID")
                        .HasColumnType("int");

                    b.Property<float>("Stanje")
                        .HasColumnType("real");

                    b.Property<int>("UgovorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("NacinUplateID");

                    b.HasIndex("RecepcioerID");

                    b.HasIndex("UgovorID");

                    b.ToTable("Uplatas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Upozorenje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DatumSlanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UgovorID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UgovorID");

                    b.ToTable("Upozorenjes");
                });

            modelBuilder.Entity("DBdata.EntityModels.VrstaStanjaZahtjeva", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("VrstaStanjaZahtjevas");
                });

            modelBuilder.Entity("DBdata.EntityModels.VrstaZahtjeva", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("VrstaZahtjevas");
                });

            modelBuilder.Entity("DBdata.EntityModels.Zahtjev", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Datum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UgovorID")
                        .HasColumnType("int");

                    b.Property<int>("VrstaStanjaZahtjevaID")
                        .HasColumnType("int");

                    b.Property<int>("VrstaZahtjevaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UgovorID");

                    b.HasIndex("VrstaStanjaZahtjevaID");

                    b.HasIndex("VrstaZahtjevaID");

                    b.ToTable("Zahtjevs");
                });

            modelBuilder.Entity("DBdata.EntityModels.Kuharica", b =>
                {
                    b.HasBaseType("DBdata.EntityModels.Osoblje");

                    b.HasDiscriminator().HasValue("Kuharica");
                });

            modelBuilder.Entity("DBdata.EntityModels.Recepcioer", b =>
                {
                    b.HasBaseType("DBdata.EntityModels.Osoblje");

                    b.HasDiscriminator().HasValue("Recepcioer");
                });

            modelBuilder.Entity("DBdata.EntityModels.DnevnaPonuda", b =>
                {
                    b.HasOne("DBdata.EntityModels.Kartica", "Kartica")
                        .WithMany()
                        .HasForeignKey("KarticaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Kuharica", "Kuharica")
                        .WithMany()
                        .HasForeignKey("KuharicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kartica");

                    b.Navigation("Kuharica");
                });

            modelBuilder.Entity("DBdata.EntityModels.Grad", b =>
                {
                    b.HasOne("DBdata.EntityModels.Kanton", "Kanton")
                        .WithMany()
                        .HasForeignKey("KantonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kanton");
                });

            modelBuilder.Entity("DBdata.EntityModels.Konkurs", b =>
                {
                    b.HasOne("DBdata.EntityModels.CiklusStudija", "CiklusStudija")
                        .WithMany()
                        .HasForeignKey("CiklusStudijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Fakultet", "Fakultet")
                        .WithMany()
                        .HasForeignKey("FakultetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.GodinaStudija", "GodinaStudija")
                        .WithMany()
                        .HasForeignKey("GodinaStudijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Grad", "MjestoRodjenja")
                        .WithMany()
                        .HasForeignKey("MjestoRodjenjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Grad", "MjestoStanovanja")
                        .WithMany()
                        .HasForeignKey("MjestoStanovanjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.TipKandidata", "TipKandidata")
                        .WithMany()
                        .HasForeignKey("TipKandidataID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CiklusStudija");

                    b.Navigation("Drzava");

                    b.Navigation("Fakultet");

                    b.Navigation("GodinaStudija");

                    b.Navigation("MjestoRodjenja");

                    b.Navigation("MjestoStanovanja");

                    b.Navigation("Student");

                    b.Navigation("TipKandidata");
                });

            modelBuilder.Entity("DBdata.EntityModels.Lokacija", b =>
                {
                    b.HasOne("DBdata.EntityModels.Grad", "MjestoStanovanja")
                        .WithMany()
                        .HasForeignKey("MjestoStanovanjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MjestoStanovanja");
                });

            modelBuilder.Entity("DBdata.EntityModels.NajavaOdlaska", b =>
                {
                    b.HasOne("DBdata.EntityModels.Ugovor", "Ugovor")
                        .WithMany()
                        .HasForeignKey("UgovorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ugovor");
                });

            modelBuilder.Entity("DBdata.EntityModels.Obavijest", b =>
                {
                    b.HasOne("DBdata.EntityModels.Recepcioer", "Recepcioer")
                        .WithMany()
                        .HasForeignKey("RecepcioerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recepcioer");
                });

            modelBuilder.Entity("DBdata.EntityModels.Obrok", b =>
                {
                    b.HasOne("DBdata.EntityModels.Kuharica", "Kuharica")
                        .WithMany()
                        .HasForeignKey("KuharicaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kuharica");
                });

            modelBuilder.Entity("DBdata.EntityModels.Osoblje", b =>
                {
                    b.HasOne("DBdata.EntityModels.Lokacija", "Lokacija")
                        .WithMany()
                        .HasForeignKey("LokacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lokacija");
                });

            modelBuilder.Entity("DBdata.EntityModels.Student", b =>
                {
                    b.HasOne("DBdata.EntityModels.CiklusStudija", "CiklusStudija")
                        .WithMany()
                        .HasForeignKey("CiklusStudijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Fakultet", "Fakultet")
                        .WithMany()
                        .HasForeignKey("FakultetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.GodinaStudija", "GodinaStudija")
                        .WithMany()
                        .HasForeignKey("GodinaStudijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Lokacija", "Lokacija")
                        .WithMany()
                        .HasForeignKey("LokacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Grad", "MjestoRodjenja")
                        .WithMany()
                        .HasForeignKey("MjestoRodjenjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.TipKandidata", "TipKandidata")
                        .WithMany()
                        .HasForeignKey("TipKandidataID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CiklusStudija");

                    b.Navigation("Fakultet");

                    b.Navigation("GodinaStudija");

                    b.Navigation("Lokacija");

                    b.Navigation("MjestoRodjenja");

                    b.Navigation("TipKandidata");
                });

            modelBuilder.Entity("DBdata.EntityModels.Ugovor", b =>
                {
                    b.HasOne("DBdata.EntityModels.Osoblje", "DodanUgovorOsoblje")
                        .WithMany()
                        .HasForeignKey("DodanUgovorOsobljeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Kartica", "Kartica")
                        .WithMany()
                        .HasForeignKey("KarticaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Soba", "Soba")
                        .WithMany()
                        .HasForeignKey("SobaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DodanUgovorOsoblje");

                    b.Navigation("Kartica");

                    b.Navigation("Soba");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DBdata.EntityModels.Uplata", b =>
                {
                    b.HasOne("DBdata.EntityModels.NacinUplate", "NacinUplate")
                        .WithMany()
                        .HasForeignKey("NacinUplateID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Recepcioer", "Recepcioer")
                        .WithMany()
                        .HasForeignKey("RecepcioerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.Ugovor", "Ugovor")
                        .WithMany()
                        .HasForeignKey("UgovorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NacinUplate");

                    b.Navigation("Recepcioer");

                    b.Navigation("Ugovor");
                });

            modelBuilder.Entity("DBdata.EntityModels.Upozorenje", b =>
                {
                    b.HasOne("DBdata.EntityModels.Ugovor", "Ugovor")
                        .WithMany()
                        .HasForeignKey("UgovorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ugovor");
                });

            modelBuilder.Entity("DBdata.EntityModels.Zahtjev", b =>
                {
                    b.HasOne("DBdata.EntityModels.Ugovor", "Ugovor")
                        .WithMany()
                        .HasForeignKey("UgovorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.VrstaStanjaZahtjeva", "VrstaStanjaZahtjeva")
                        .WithMany()
                        .HasForeignKey("VrstaStanjaZahtjevaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBdata.EntityModels.VrstaZahtjeva", "VrstaZahtjeva")
                        .WithMany()
                        .HasForeignKey("VrstaZahtjevaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ugovor");

                    b.Navigation("VrstaStanjaZahtjeva");

                    b.Navigation("VrstaZahtjeva");
                });
#pragma warning restore 612, 618
        }
    }
}
