using System;
using System.Collections.Generic;
using System.Text;

namespace DBdata.EntityModels
{
    public class Grad
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public Drzava Drzava { get; set; }
        public int DrzavaID { get; set; }
    }
}
