using System;
using System.Collections.Generic;
using System.Text;

namespace DBdata.EntityModels
{
    public class Lokacija
    {
        public int ID { get; set; }
        public string adresa { get; set; }
        public string PostanskiBroj { get; set; }
        public Grad Grad { get; set; }
        public int GradID { get; set; }
    }
}
