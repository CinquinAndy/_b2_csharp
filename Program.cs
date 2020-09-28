using System;
using System.Collections.Generic;

namespace _2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage monPersonnage = new Guerrier("Albert", new List<Arme> { new Arme("Pistolet laser", "uidPisto"),
                    new Arme("Hache laser", "uidHache"),
                    new Arme("Epee laser", "uidEpee") }, 100);
            monPersonnage.afficherStats();
        }
    }
}
