using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Voleur:Personnage
    {
        Byte maitriseVol;
        public Voleur(string nomPerso, List<Arme> listeArmes, Byte maitriseVol) : base(nomPerso, listeArmes)
        {
            this.maitriseVol = maitriseVol;
        }
        public override void o_attaquer()
        {
            Console.WriteLine("Classe Guerrier attaque 'o'");
        }
        public override void n_attaquer()
        {
            Console.WriteLine("Classe Guerrier attaque 'n'");
        }
    }
}
