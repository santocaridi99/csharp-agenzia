using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Esercizio 2: Agenzia immobiliare

Si vuole progettare un’applicazione in grado di gestire un’agenzia 
immobiliare. 

Gli immobili sono caratterizzati da:
- un codice alfanumerico, 
- indirizzo, 
- cap, 
- città 
- una superficie espressa in mq attraverso un numero intero. 


L’agenzia gestisce diverse tipologie di immobili: 
- Box, 
- Appartamenti 
- Ville.

Per i box è riportato il numero di posti auto. 
Per gli appartamenti è 
riportato in numero di vani e il numero di bagni.

Per le ville è previsto, 
in aggiunta rispetto all’appartamento, la dimensione in mq di giardino.

Ridefinire per ciascuna delle tre classi il metodo ToString in modo da fornire 
una descrizione completa dell'immobile. StampaSchedaImmobile

Provare a pensare ad una funzione di ricerca.

 * 
 * 
 */


namespace csharp_agenzia
{
    internal class agenzia
    {

        public agenzia(string Nome)
        {
            this.Nome = Nome;
            this.Immobili = new List<immobile>();
        }

        public string Nome { get; set; }
        public List<immobile> Immobili { get; set; }

        public void Addimmobile(immobile immobile)
        {
            this.Immobili.Add(immobile);
        }

        public List<immobile> SearchImmobili(string key)
        {
            return this.Immobili.FindAll(i=>i.Contains(key));
        }
    }
}
