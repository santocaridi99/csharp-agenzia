using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_agenzia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo box
            box esempioBox = new box("b1000", "via san sperato", "89100", "Reggio cal", 15, 2);
            //creo un appartamento
            appartamento appartamento = new appartamento("a0001", "via modena", "89100", "Reggio cal", 20, 5, 2);
            //creo una villa
            villa villa = new villa("v0001", "via modena", "89102", "Reggio cal",40,4,4,5);
            agenzia agenzia = new agenzia("Agenzia Santo");

            //aggiungo all'agenzia l'appartamento , il box e la vlla
            agenzia.Addimmobile(appartamento);
            agenzia.Addimmobile(esempioBox);
            agenzia.Addimmobile(villa);

            //cerco per cap
            List<immobile> immobileList = agenzia.SearchImmobili("89100");

            foreach (immobile immobile in immobileList)
            {
                Console.WriteLine(immobile.ToString());
            }
        }
    }
}
