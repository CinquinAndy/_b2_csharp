using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Personnage
    {
        private string nomPerso;
        private Metier metierPerso;
        // string aussi
        // dictionnaire
        // byte plus opti
        private int vitessePerso;
        private int forcePerso;
        private int endurancePerso;
        private int viePerso;
        private List<Arme> listeArmes;
        //private Arme[] armesPerso;
        public Personnage(string nomPerso, Metier metierPerso, List<Arme> listeArmes,
            int viePerso = 25, int vitessePerso=25, int forcePerso=25, int endurancePerso=25)
        {
            this.NomPerso= nomPerso;
            this.MetierPerso= metierPerso;
            this.ViePerso = viePerso;
            this.ListeArmes = listeArmes;
            // possibilité 1
            if (endurancePerso + vitessePerso + forcePerso >= 25)
            {
                this.VitessePerso = 10;
                this.EndurancePerso = 10;
                this.ForcePerso = 5;
            }
            else { 
                this.VitessePerso= vitessePerso;
                this.EndurancePerso = endurancePerso;
                this.ForcePerso= forcePerso;
            }
            // possibilité 2 -> retour erreur
            // possibilité 3 -> gestion de la saisie, avec un prompt
            // Console.ReadLine(); + do while pour gestion de saisie tant que saisie pas ok
            //this.armesPerso =new Arme[this.forcePerso];
        }
        public string NomPerso { get => nomPerso; set => nomPerso = value; }
        public int VitessePerso { get => vitessePerso; set => vitessePerso = value; }
        public int ForcePerso { get => forcePerso; set { 
                if (vitessePerso + endurancePerso + value >= 25){}
                else
                {
                    forcePerso = value;
                    // pour accédé à mon extension, il faut que la variable soit une string
                    forcePerso.ToString().affichageInfo();
                }
            } 
        }
        public int EndurancePerso { get => endurancePerso; set => endurancePerso = value; }
        public int ViePerso { get => viePerso; set => viePerso = value; }
        internal Metier MetierPerso { get => metierPerso; set => metierPerso = value; }
        internal List<Arme> ListeArmes { get => listeArmes; set => listeArmes = value; }
    }
}

// out -> sans assignation au début
// ref -> avec assignation au début
// --> out / ref --> pour passé par une référence, un pointeur