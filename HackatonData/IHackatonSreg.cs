using System;
using System.Collections.Generic;
using System.Text;
using HackatonData.Models;

namespace HackatonData
{
    public interface IHackatonSreg
    {
        IEnumerable<Sreg> GetCases();
        Sreg GetCaseById(int id);
        IEnumerable<Sreg> GetCaseByDebtor(int debtorNr);
        IEnumerable<Sreg> GetCasesByKreditor(int krediotrNr);
        void InsertCase(Sreg sreg);
    }
}
