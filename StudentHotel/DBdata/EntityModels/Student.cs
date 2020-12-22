using System;
using System.Collections.Generic;
using System.Text;

namespace DBdata.EntityModels
{
    public class Student
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string DatumRodjenja { get; set; }

        public Fakultet Fakultet { get; set; }
        public int FakultetID { get; set; }
        public int BrojUpozorenja { get; set; }

        public Lokacija Lokacija { get; set; }
        public int LokacijaID { get; set; }
    }
}
