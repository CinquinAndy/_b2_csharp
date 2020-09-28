using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Guerrier:Personnage
    {
        Byte tauxRage;
        public Guerrier(string nomPerso, List<Arme> listeArmes, Byte tauxRage):base(nomPerso,listeArmes)
        {
            this.tauxRage = tauxRage;
        }
        public override void o_attaquer() { 
            Console.WriteLine("Classe Guerrier attaque 'o'"); 
        }
        public override void n_attaquer()
        {
            Console.WriteLine("Classe Guerrier attaque 'n'");
        }
    }
}
