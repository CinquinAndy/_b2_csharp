using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Mage:Personnage
    {
        Byte maitriseMagie;
        public Mage(string nomPerso, List<Arme> listeArmes, Byte maitriseMagie) : base(nomPerso, listeArmes)
        {
            this.maitriseMagie = maitriseMagie;
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
