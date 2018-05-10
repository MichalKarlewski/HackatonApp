using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HackatonData.Models
{
    public class Sreg
    {
        [Key]
        public int Sak_Nr { get; set; }
        public string Sak_BrukerID { get; set; }
        public string Sak_Referanse { get; set; }
        public string Sak_Ref2 { get; set; }
        [ForeignKey("Sak_DebNr")]
        public Debitor Sak_DebtorNr { get; set; }
        [ForeignKey("Sak_KredNr")]
        public Kreditor Sak_KreditorNr { get; set; }
        public string Sak_Status { get; set; }
        public string Sak_Dato { get; set; }
        public string Sak_AvsluttDato { get; set; }
        public string Sak_StatusTekst { get; set; }
        public double Sak_Rentegrunnlag { get; set; }
        public double Sak_Capital { get; set; }
        public double Sak_Fee { get; set; }
        public double Sak_BrukesIkke10 { get; set; }
        public double Sak_Sum { get; set; }
        public double Sak_SaldoHovedstol { get; set; }
    }
}
