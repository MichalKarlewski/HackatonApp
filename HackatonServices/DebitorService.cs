using System;
using System.Collections.Generic;
using System.Text;
using HackatonData;
using HackatonData.Models;

namespace HackatonServices
{
    public class DebitorService : IDebtorService
    {
        private HackatonContext _context;
        public DebitorService(HackatonContext context)
        {
            _context = context;
        }

        public void CreateNewDebtor(Debitor debtor)
        {
            _context.Add(debtor);
        }
    }
}
