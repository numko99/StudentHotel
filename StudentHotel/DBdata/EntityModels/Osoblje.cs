﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DBdata.EntityModels
{
   public class Osoblje
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
        public string GodinaZaposlenja { get; set; }
        public string DatumZaposlenja { get; set; }
 
        public Lokacija Lokacija { get; set; }
        public int LokacijaID { get; set; }
    }
}
