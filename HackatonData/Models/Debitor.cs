using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HackatonData.Models
{
    public class Debitor
    {
        [Key]
        public int Debitor_Nr { get; set; }
        public string Debitor_KontoNr { get; set; }
        public string Debitor_Ident { get; set; }
        public string Debitor_Fodselsdato { get; set; }
        public string Debitor_Navn1 { get; set; }
        public string Debitor_Navn2 { get; set; }
        public string Debitor_Adresse1 { get; set; }
        public string Debitor_Adresse2 { get; set; }
        public string Debitor_Postnr { get; set; }
        public string Debitor_Sted { get; set; }
        public string Debitor_LandKode { get; set; }
        public string Debitor_Kategori { get; set; }
        public string Debitor_Kontakt { get; set; }
        public string Debitor_EPost { get; set; }
        public string Debitor_Sprak { get; set; }
        public int Unik { get; set; }
    }
}
