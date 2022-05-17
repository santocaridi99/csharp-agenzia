using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csharp_agenzia
{
    class box : immobile
    {
        public int postiAuto { get; set; }  
        
        public box (string codice, string indirizzo ,string cap , string citta , int superficie , int postiAuto) : base (codice, indirizzo , cap , citta , superficie)
        {
            this.postiAuto = postiAuto;
        }

        public override string ToString()
        {
            return string.Format("Box:\n{0}", Write());
        }

        public override string Write()
        {
            return string.Format("{0}\npostiAuto: {1}",
                base.Write(),
                this.postiAuto);
        }

        public override bool Contains(string key)
        {
            if (base.Contains(key)) return true;
            else if (this.postiAuto.ToString().Contains(key)) return true;
            else return false;
        }

    }
}
