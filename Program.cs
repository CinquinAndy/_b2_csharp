using System;
using System.Collections.Generic;

namespace _2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage monNouveauPersonnage = new Personnage("Albert", 
                new Mage(0, 100),
                new List<Arme> { new Arme("Pistolet laser", "uidPisto"), 
                    new Arme("Hache laser", "uidHache"), 
                    new Arme("Epee laser", "uidEpee") },
                20, 10, 10, 5);
            Console.WriteLine(monNouveauPersonnage.NomPerso);
        }
    }
}
