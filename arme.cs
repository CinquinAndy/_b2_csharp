using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Arme
    {
        string identifiant = "temp";
        string nomArme;
        public Arme(string nomArme, string identifiant)
        {
            this.nomArme = nomArme;
            this.identifiant = identifiant;
        }

        public string NomArme { get => nomArme;}
    }
}
