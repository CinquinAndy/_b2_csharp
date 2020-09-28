using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Chaman: Personnage
    {
        Byte maitriseDeLaNature;
        public Chaman(string nomPerso, List<Arme> listeArmes, Byte maitriseDeLaNature) : base(nomPerso, listeArmes)
        {
            this.maitriseDeLaNature = maitriseDeLaNature;
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
