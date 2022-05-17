using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class appartamento : immobile
    {
        public int numeroVani { get; set; }
        public int numeroBagni { get; set; }

        public appartamento(string codice, string indirizzo, string cap, string citta, int superficie, int numeroVani , int numeroBagni) : base (codice, indirizzo, cap, citta, superficie)
        {
            this.numeroVani = numeroVani;
            this.numeroBagni = numeroBagni;
        }

        public override string ToString()
        {
            return string.Format("appartamento:\n{0}", Write());
        }

        public override string Write()
        {
            return string.Format("{0}\nnumeroVani: {1} \nnumeroBagni: {2}",
                base.Write(),
                this.numeroVani,
                this.numeroBagni);
        }

        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.numeroVani.ToString().Contains(key)) return true;
            else if (this.numeroBagni.ToString().Contains(key)) return true;    
            else return false;
        }
    }
}
