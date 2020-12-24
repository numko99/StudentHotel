﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DBdata.Migrations
{
    public partial class StudentHotel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CiklusStudijas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CiklusStudijas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Drzavas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzavas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fakultets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakultets", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GodinaStudijas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GodinaStudijas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kantons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kantons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Karticas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojKartice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StanjeNaKartici = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karticas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NacinUplates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NacinUplates", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sobas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sprat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojSobe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojKreveta = table.Column<int>(type: "int", nullable: false),
                    ImaBalkon = table.Column<bool>(type: "bit", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sobas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tipKandidatas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipKandidatas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VrstaStanjaZahtjevas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaStanjaZahtjevas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VrstaZahtjevas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaZahtjevas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Grads",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KantonID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grads", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Grads_Kantons_KantonID",
                        column: x => x.KantonID,
                        principalTable: "Kantons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lokacijas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostanskiBroj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MjestoStanovanjaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lokacijas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lokacijas_Grads_MjestoStanovanjaID",
                        column: x => x.MjestoStanovanjaID,
                        principalTable: "Grads",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Osobljes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodinaZaposlenja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumZaposlenja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LokacijaID = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osobljes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Osobljes_Lokacijas_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacijas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImeOca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MjestoRodjenjaID = table.Column<int>(type: "int", nullable: false),
                    ZanimanjeRoditelja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicnaKarta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mjesto_izdavanja_LK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobitel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FakultetID = table.Column<int>(type: "int", nullable: false),
                    TipKandidataID = table.Column<int>(type: "int", nullable: false),
                    BrojIndeksa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiklusStudijaID = table.Column<int>(type: "int", nullable: false),
                    GodinaStudijaID = table.Column<int>(type: "int", nullable: false),
                    LokacijaID = table.Column<int>(type: "int", nullable: false),
                    Uselio = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_CiklusStudijas_CiklusStudijaID",
                        column: x => x.CiklusStudijaID,
                        principalTable: "CiklusStudijas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Fakultets_FakultetID",
                        column: x => x.FakultetID,
                        principalTable: "Fakultets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_GodinaStudijas_GodinaStudijaID",
                        column: x => x.GodinaStudijaID,
                        principalTable: "GodinaStudijas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Grads_MjestoRodjenjaID",
                        column: x => x.MjestoRodjenjaID,
                        principalTable: "Grads",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Students_Lokacijas_LokacijaID",
                        column: x => x.LokacijaID,
                        principalTable: "Lokacijas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Students_tipKandidatas_TipKandidataID",
                        column: x => x.TipKandidataID,
                        principalTable: "tipKandidatas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DnevnaPonudas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KuharicaID = table.Column<int>(type: "int", nullable: false),
                    KarticaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DnevnaPonudas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DnevnaPonudas_Karticas_KarticaID",
                        column: x => x.KarticaID,
                        principalTable: "Karticas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DnevnaPonudas_Osobljes_KuharicaID",
                        column: x => x.KuharicaID,
                        principalTable: "Osobljes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Obavijests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumVrijeme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecepcioerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijests", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Obavijests_Osobljes_RecepcioerID",
                        column: x => x.RecepcioerID,
                        principalTable: "Osobljes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Obroks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iznos = table.Column<float>(type: "real", nullable: false),
                    Detalji = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KuharicaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obroks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Obroks_Osobljes_KuharicaID",
                        column: x => x.KuharicaID,
                        principalTable: "Osobljes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Konkurs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImeOca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MjestoRodjenjaID = table.Column<int>(type: "int", nullable: false),
                    ZanimanjeRoditelja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicnaKarta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mjesto_izdavanja_LK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobitel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MjestoStanovanjaID = table.Column<int>(type: "int", nullable: false),
                    DrzavaID = table.Column<int>(type: "int", nullable: false),
                    FakultetID = table.Column<int>(type: "int", nullable: false),
                    TipKandidataID = table.Column<int>(type: "int", nullable: false),
                    BrojIndeksa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiklusStudijaID = table.Column<int>(type: "int", nullable: false),
                    GodinaStudijaID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konkurs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Konkurs_CiklusStudijas_CiklusStudijaID",
                        column: x => x.CiklusStudijaID,
                        principalTable: "CiklusStudijas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Konkurs_Drzavas_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzavas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Konkurs_Fakultets_FakultetID",
                        column: x => x.FakultetID,
                        principalTable: "Fakultets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Konkurs_GodinaStudijas_GodinaStudijaID",
                        column: x => x.GodinaStudijaID,
                        principalTable: "GodinaStudijas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Konkurs_Grads_MjestoRodjenjaID",
                        column: x => x.MjestoRodjenjaID,
                        principalTable: "Grads",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Konkurs_Grads_MjestoStanovanjaID",
                        column: x => x.MjestoStanovanjaID,
                        principalTable: "Grads",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Konkurs_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Konkurs_tipKandidatas_TipKandidataID",
                        column: x => x.TipKandidataID,
                        principalTable: "tipKandidatas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ugovors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SobaID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    KarticaID = table.Column<int>(type: "int", nullable: false),
                    DodanUgovorOsobljeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugovors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ugovors_Karticas_KarticaID",
                        column: x => x.KarticaID,
                        principalTable: "Karticas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ugovors_Osobljes_DodanUgovorOsobljeID",
                        column: x => x.DodanUgovorOsobljeID,
                        principalTable: "Osobljes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ugovors_Sobas_SobaID",
                        column: x => x.SobaID,
                        principalTable: "Sobas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ugovors_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "NajavaOdlaskas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumPolaska = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumPovratka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UgovorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NajavaOdlaskas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NajavaOdlaskas_Ugovors_UgovorID",
                        column: x => x.UgovorID,
                        principalTable: "Ugovors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uplatas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stanje = table.Column<float>(type: "real", nullable: false),
                    NacinUplateID = table.Column<int>(type: "int", nullable: false),
                    RecepcioerID = table.Column<int>(type: "int", nullable: false),
                    UgovorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplatas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Uplatas_NacinUplates_NacinUplateID",
                        column: x => x.NacinUplateID,
                        principalTable: "NacinUplates",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uplatas_Osobljes_RecepcioerID",
                        column: x => x.RecepcioerID,
                        principalTable: "Osobljes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uplatas_Ugovors_UgovorID",
                        column: x => x.UgovorID,
                        principalTable: "Ugovors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Upozorenjes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumSlanja = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UgovorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upozorenjes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Upozorenjes_Ugovors_UgovorID",
                        column: x => x.UgovorID,
                        principalTable: "Ugovors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjevs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VrstaZahtjevaID = table.Column<int>(type: "int", nullable: false),
                    VrstaStanjaZahtjevaID = table.Column<int>(type: "int", nullable: false),
                    UgovorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjevs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Zahtjevs_Ugovors_UgovorID",
                        column: x => x.UgovorID,
                        principalTable: "Ugovors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zahtjevs_VrstaStanjaZahtjevas_VrstaStanjaZahtjevaID",
                        column: x => x.VrstaStanjaZahtjevaID,
                        principalTable: "VrstaStanjaZahtjevas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zahtjevs_VrstaZahtjevas_VrstaZahtjevaID",
                        column: x => x.VrstaZahtjevaID,
                        principalTable: "VrstaZahtjevas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DnevnaPonudas_KarticaID",
                table: "DnevnaPonudas",
                column: "KarticaID");

            migrationBuilder.CreateIndex(
                name: "IX_DnevnaPonudas_KuharicaID",
                table: "DnevnaPonudas",
                column: "KuharicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Grads_KantonID",
                table: "Grads",
                column: "KantonID");

            migrationBuilder.CreateIndex(
                name: "IX_Konkurs_CiklusStudijaID",
                table: "Konkurs",
                column: "CiklusStudijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Konkurs_DrzavaID",
                table: "Konkurs",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Konkurs_FakultetID",
                table: "Konkurs",
                column: "FakultetID");

            migrationBuilder.CreateIndex(
                name: "IX_Konkurs_GodinaStudijaID",
                table: "Konkurs",
                column: "GodinaStudijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Konkurs_MjestoRodjenjaID",
                table: "Konkurs",
                column: "MjestoRodjenjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Konkurs_MjestoStanovanjaID",
                table: "Konkurs",
                column: "MjestoStanovanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Konkurs_StudentID",
                table: "Konkurs",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Konkurs_TipKandidataID",
                table: "Konkurs",
                column: "TipKandidataID");

            migrationBuilder.CreateIndex(
                name: "IX_Lokacijas_MjestoStanovanjaID",
                table: "Lokacijas",
                column: "MjestoStanovanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_NajavaOdlaskas_UgovorID",
                table: "NajavaOdlaskas",
                column: "UgovorID");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijests_RecepcioerID",
                table: "Obavijests",
                column: "RecepcioerID");

            migrationBuilder.CreateIndex(
                name: "IX_Obroks_KuharicaID",
                table: "Obroks",
                column: "KuharicaID");

            migrationBuilder.CreateIndex(
                name: "IX_Osobljes_LokacijaID",
                table: "Osobljes",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CiklusStudijaID",
                table: "Students",
                column: "CiklusStudijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_FakultetID",
                table: "Students",
                column: "FakultetID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GodinaStudijaID",
                table: "Students",
                column: "GodinaStudijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LokacijaID",
                table: "Students",
                column: "LokacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_MjestoRodjenjaID",
                table: "Students",
                column: "MjestoRodjenjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_TipKandidataID",
                table: "Students",
                column: "TipKandidataID");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovors_DodanUgovorOsobljeID",
                table: "Ugovors",
                column: "DodanUgovorOsobljeID");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovors_KarticaID",
                table: "Ugovors",
                column: "KarticaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovors_SobaID",
                table: "Ugovors",
                column: "SobaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovors_StudentID",
                table: "Ugovors",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplatas_NacinUplateID",
                table: "Uplatas",
                column: "NacinUplateID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplatas_RecepcioerID",
                table: "Uplatas",
                column: "RecepcioerID");

            migrationBuilder.CreateIndex(
                name: "IX_Uplatas_UgovorID",
                table: "Uplatas",
                column: "UgovorID");

            migrationBuilder.CreateIndex(
                name: "IX_Upozorenjes_UgovorID",
                table: "Upozorenjes",
                column: "UgovorID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevs_UgovorID",
                table: "Zahtjevs",
                column: "UgovorID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevs_VrstaStanjaZahtjevaID",
                table: "Zahtjevs",
                column: "VrstaStanjaZahtjevaID");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevs_VrstaZahtjevaID",
                table: "Zahtjevs",
                column: "VrstaZahtjevaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DnevnaPonudas");

            migrationBuilder.DropTable(
                name: "Konkurs");

            migrationBuilder.DropTable(
                name: "NajavaOdlaskas");

            migrationBuilder.DropTable(
                name: "Obavijests");

            migrationBuilder.DropTable(
                name: "Obroks");

            migrationBuilder.DropTable(
                name: "Uplatas");

            migrationBuilder.DropTable(
                name: "Upozorenjes");

            migrationBuilder.DropTable(
                name: "Zahtjevs");

            migrationBuilder.DropTable(
                name: "Drzavas");

            migrationBuilder.DropTable(
                name: "NacinUplates");

            migrationBuilder.DropTable(
                name: "Ugovors");

            migrationBuilder.DropTable(
                name: "VrstaStanjaZahtjevas");

            migrationBuilder.DropTable(
                name: "VrstaZahtjevas");

            migrationBuilder.DropTable(
                name: "Karticas");

            migrationBuilder.DropTable(
                name: "Osobljes");

            migrationBuilder.DropTable(
                name: "Sobas");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "CiklusStudijas");

            migrationBuilder.DropTable(
                name: "Fakultets");

            migrationBuilder.DropTable(
                name: "GodinaStudijas");

            migrationBuilder.DropTable(
                name: "Lokacijas");

            migrationBuilder.DropTable(
                name: "tipKandidatas");

            migrationBuilder.DropTable(
                name: "Grads");

            migrationBuilder.DropTable(
                name: "Kantons");
        }
    }
}
