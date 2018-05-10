using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HackatonData.Models
{
    public class Kreditor
    {
        [Key]
        public int Kreditor_Nr { get; set; }
        public string Kreditor_Kategori { get; set; }
        public string Kreditor_Namn1 { get; set; }
        public string Kreditor_Namn2 { get; set; }
        public string Kreditor_Adress1 { get; set; }
        public string Kreditor_Adress2 { get; set; }
        public string Kreditor_Postnr { get; set; }
        public string Kreditor_Sted { get; set; }
        public string Kreditor_Kontakt { get; set; }
        public string Kreditor_NesteAvrDato { get; set; }
        public int Kreditor_AvrIntervall { get; set; }
        public string Kreditor_Identitet { get; set; }
        public string Kreditor_CRMRef1 { get; set; }
        public string Kreditor_CRMRef2 { get; set; }
        public string Kreditor_LandKode { get; set; }
        public string Kreditor_Sprak { get; set; }
        public string Kreditor_EPost { get; set; }
        public string Kreditor_Mobil { get; set; }
        public int Kreditor_KundeNr { get; set; }
        public string Kreditor_Avsluttet { get; set; }
        public int Kreditor_SisteFakturaNr { get; set; }
        public int Unik { get; set; }
        public string BaseCurrency { get; set; }
        public int DefaultProduct { get; set; }
    }
}
