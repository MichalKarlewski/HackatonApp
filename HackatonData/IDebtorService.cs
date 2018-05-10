using System;
using System.Collections.Generic;
using System.Text;
using HackatonData.Models;

namespace HackatonData
{
    public interface IDebtorService
    {
        void CreateNewDebtor(Debitor debtor);
    }
}
