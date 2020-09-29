using System;
using System.Collections.Generic;

namespace _2020
{
    // possibilité de déclaration de liste
    static class ArmeClassList
    {
        public static readonly Arme Pistolet = new Arme("Pistolet laser", "769e4e15-b9ba-456d-942e-17fe49af4d34");
        public static readonly Arme HacheLaser = new Arme("Hache laser", "b8dfd23f-bb1c-45d5-87f6-fe82f52381a4");
        public static readonly Arme EpeeLaser = new Arme("Epee laser", "dc8e49be-2f7e-41ec-bee4-55c50f92641c");
        public static readonly Arme Ak47 = new Arme("Ak47", "40056ce6-924c-44c0-a7ed-9ff35d6785d2");
        public static readonly Arme Dague = new Arme("Dague", "809f1c0a-65b3-4f30-a366-a03565e6b95d");
        public static readonly Arme Couteau = new Arme("Couteau", "00012a00-f398-48e4-8b48-8fb5de89ae51");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personnage monPersonnage = new Guerrier("Albert", new List<Arme> { ArmeClassList.Ak47,
                    ArmeClassList.EpeeLaser,
                    ArmeClassList.HacheLaser}, 100);
            monPersonnage.afficherStats();
        }
    }
}
