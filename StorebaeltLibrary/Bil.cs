using System;
using BilletLibrary;

namespace storebaeltlibrary_InSorteDiaboli
{
    public class Bil : Køretøj
    {
        public override decimal Pris()
        {
            return Pris();
        }

        public override string KøretøjNavn()
        {
            return KøretøjNavn();
        }

        public Bil()
        {
            
        }

        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        public decimal WeekendRabat()
        {
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return (Pris() * (0.80m)) + (Pris()*0.05m);
            }
            
            return Pris();
        }
    }
}
