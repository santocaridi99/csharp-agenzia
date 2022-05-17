using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class villa:appartamento
    {
        public int Giardino { get; set; }

        public villa(string codice , string Indirizzo , string cap ,string citta ,int superficie , int numeroVani ,int numeroBagni , int giardino) : base(codice, Indirizzo, cap, citta, superficie, numeroVani, numeroBagni)
        {
            Giardino = giardino;
        }

        public override string ToString()
        {
            return string.Format("villa:\n{0}", Write());
        }

        public override string Write()
        {
            return string.Format("{0}\nGiardino : {1}",
                base.Write(),
                this.Giardino)
                ;
        }

        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.Giardino.ToString().Contains(key)) return true;
            else return false;
        }
    }
}
