using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HackatonData.Models
{
    public class Status
    {
       
        [ForeignKey("Status_SakNr")]
        public Sreg Status_SakNumber { get; set; }
        public int Status_SakNr { get; set; }
        public int Status_LinjeNr { get; set; }
        public string Status_Kode { get; set; }
        public string Status_Dato { get; set; }
        //[ForeignKey("Status_Kreditor")]
        //public Kreditor Status_KreditorNr { get; set; }
        public string Status_Tekst { get; set; }
        public double Status_Saldo { get; set; }
        public string Status_RegDato { get; set; }
        public double Status_Capital { get; set; }
        public double Status_Fee { get; set; }
        public int Unik { get; set; }
        public DateTime Changed { get; set; }

    }
}
