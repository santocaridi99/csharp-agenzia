using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class immobile
    {
        public string Codice { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public int Superficie { get; set; }

        //faccio il costruttore 
        
            public immobile(string codice,string indirizzo , string cap , string citta , int superficie)
            { 
              this.Codice = codice; 
              this.Indirizzo = indirizzo;
              this.Cap = cap;
              this.Citta = citta;
              this.Superficie = superficie;
            }

        public override string ToString()
        {
            return string.Format("Immobile:\n{0}", Write());
        }

        public virtual string Write()
        {
            return string.Format("Codice : {0}\n Indirizzo : {1}\n Cap : {2}\n Città: {3}\n Superficie: {4}",
                this.Codice,
                this.Indirizzo,
                this.Cap,
                this.Citta,
                this.Superficie);
        }

        public virtual bool Contains(string key)
        {
            if(this.Codice.Contains(key)) return true;
            else if (this.Indirizzo.Contains(key)) return true; 
            else if(this.Cap.Contains(key)) return true;
            else if(this.Citta.Contains(key)) return true;  
            else if(this.Superficie.ToString().Contains(key)) return true;  
            else return false;
        }

    }
}
