using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBdata.EF;
using DBdata.EntityModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentHotel.Models.Referent;

namespace StudentHotel.Controllers
{
    public class Referent : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PrikazPrijava(string pretraga)
        {
            MojDbContext dBcONTEXT = new MojDbContext();
            var prijave = dBcONTEXT.Konkurs.Where(a=>pretraga==null || (a.Ime+' '+a.Prezime).ToLower().StartsWith(pretraga.ToLower())
            || (a.Prezime + ' ' + a.Ime).ToLower().StartsWith(pretraga.ToLower()))
                .Select(a => new PrikazPrijavaVM.Row()
            {
                ID = a.ID,
                Ime = a.Ime,
                Prezime = a.Prezime,
                DatumRodjenja = a.DatumRodjenja,
                OpstinaPrebivalista = a.MjestoStanovanja.Naziv,
                StudentID=a.StudentID,
                Bodovi=a.RezultatKonkursa==null?0:a.RezultatKonkursa.BrojBodova
            }).ToList();
            //prijave=prijave.OrderByDescending(a => a.Bodovi).ToList();
            PrikazPrijavaVM model = new PrikazPrijavaVM(); 
            model.Students = prijave;
            model.Pretraga = pretraga;
            return View(model);
        }
       
        public IActionResult DetaljiPrikazPrijava(int KonkursID)
        {
            MojDbContext dBcONTEXT = new MojDbContext();
            var student = dBcONTEXT.Konkurs.Where(a => KonkursID == a.ID).Select(admir => new DetaljiPrikazPrijavaVM
            {
                ID = admir.ID,
                Ime = admir.Ime,
                Prezime = admir.Prezime,
                ImeOca = admir.ImeOca,
                MjestoRodjenjaID = admir.MjestoRodjenjaID,
                MjestoRodjenja = admir.MjestoRodjenja.Naziv,
                ZanimanjeRoditelja = admir.ZanimanjeRoditelja,
                PolID = admir.PolID,
                Pol = admir.Pol.Naziv,
                JMBG = admir.JMBG,
                LicnaKarta = admir.LicnaKarta,
                DatumRodjenja = admir.DatumRodjenja.ToString(),
                Mobitel = admir.Mobitel,
                Email = admir.Email,

                Adresa = admir.Adresa,
                MjestoStanovanjaID = admir.MjestoStanovanjaID,
                MjestoStanovanja = admir.MjestoStanovanja.Naziv,
                KantonID = admir.KantonID,
                Kanton = admir.Kanton.Naziv,

                FakultetID = admir.FakultetID,
                Fakultet = admir.Fakultet.Naziv,
                TipKandidataID = admir.TipKandidataID,
                TipKandidata = admir.TipKandidata.Naziv,
                BrojIndeksa = admir.BrojIndeksa,
                CiklusStudijaID = admir.CiklusStudijaID,
                CiklusStudija = admir.CiklusStudija.Naziv,
                GodinaStudijaID = admir.GodinaStudijaID,
                GodinaStudija = admir.GodinaStudija.Naziv,
                Bodovi=admir.RezultatKonkursa==null?0:admir.RezultatKonkursa.BrojBodova,
                VrsteStanjaKonkursaID=admir.RezultatKonkursa==null?null:admir.RezultatKonkursa.VrstaStanjaKonkursaID,
                VrstaRazlogaOdbijanjaID=admir.RezultatKonkursa==null?null:admir.RezultatKonkursa.VrstaRazlogaOdbijanjaID
                
            }).Single();
          
            var stanje = dBcONTEXT.VrstaStanjaKonkursas.Select(a => new SelectListItem
            {
                Value = a.ID.ToString(),
                Text = a.Naziv
            }).ToList(); 
            var razlog  = dBcONTEXT.vrstaRazlogaOdbijanjas.Select(a => new SelectListItem
            {
                Value = a.ID.ToString(),
                Text = a.Naziv
            }).ToList();
            student.VrsteStanjaKonkursa = stanje;
            student.VrstaRazlogaOdbijanja = razlog;
            return View(student);
        }
        public IActionResult SnimiPrimljenogStudenta(DetaljiPrikazPrijavaVM admir)
        {
            MojDbContext dbContext = new MojDbContext();
            var konkurs = dbContext.Konkurs.Find(admir.ID);

            var rezultat = konkurs.RezultatKonkursaID == null ? new RezultatKonkursa() : dbContext.RezultatKonkursas.Find(konkurs.RezultatKonkursaID);

            rezultat.BrojBodova = admir.Bodovi;
            rezultat.VrstaStanjaKonkursaID = admir.VrsteStanjaKonkursaID;
            rezultat.VrstaRazlogaOdbijanjaID= rezultat.VrstaStanjaKonkursaID != 3? null: admir.VrstaRazlogaOdbijanjaID;
            var st = dbContext.Students.Find(konkurs.StudentID);

            if (konkurs.StudentID>0 && rezultat.VrstaStanjaKonkursaID>1 && st.Uselio==false)
            {
                dbContext.Remove(konkurs.Student);
                dbContext.SaveChanges();
            }
            if (rezultat.ID == 0)
            {
                dbContext.Add(rezultat);
                dbContext.SaveChanges();

                konkurs.RezultatKonkursaID = rezultat.ID;
            }

            dbContext.SaveChanges();

            if (rezultat.VrstaStanjaKonkursaID == 1)
            {
                Student student = new Student();
                student.Ime = admir.Ime;
                student.Prezime = admir.Prezime;
                student.ImeOca = admir.ImeOca;
                student.MjestoRodjenjaID = admir.MjestoRodjenjaID;
                student.ZanimanjeRoditelja = admir.ZanimanjeRoditelja;
                student.JMBG = admir.JMBG;
                student.PolID = admir.PolID;
                student.LicnaKarta = admir.LicnaKarta;
                student.DatumRodjenja = admir.DatumRodjenja.ToString();
                student.Mobitel = admir.Mobitel;
                student.Email = admir.Email;
                student.FakultetID = admir.FakultetID;
                student.TipKandidataID = admir.TipKandidataID;
                student.BrojIndeksa = admir.BrojIndeksa;
                student.CiklusStudijaID = admir.CiklusStudijaID;
                student.GodinaStudijaID = admir.GodinaStudijaID;
                student.Uselio = false;
                Lokacija lokacija = new Lokacija();
                lokacija.Adresa = admir.Adresa;
                lokacija.MjestoStanovanjaID = admir.MjestoRodjenjaID;
                lokacija.KantonID = admir.KantonID;
                dbContext.Add(lokacija);
                dbContext.SaveChanges();

                student.LokacijaID = lokacija.ID;
                dbContext.Add(student);
                dbContext.SaveChanges();

                konkurs.StudentID = student.ID;
                dbContext.SaveChanges();

            }
            return Redirect(url: "/Referent/PrikazPrijava"); 
        }
    }

}
//TREBA U DB SET DODAT 