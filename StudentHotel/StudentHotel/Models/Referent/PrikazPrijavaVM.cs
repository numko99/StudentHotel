﻿using DBdata.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentHotel.Models.Referent
{
    public class PrikazPrijavaVM
    {
        public class Row
        {
          
            public int ID { get; set; }
            public string Ime { get; set; }
            public string Prezime { get; set; }
            public string OpstinaPrebivalista { get; set; }
            public string DatumRodjenja { get; set; }
            public int ?StudentID { get; set; }
        }
        public List<Row> Students { get; set; }

    }
}