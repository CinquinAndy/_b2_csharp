using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020
{
    abstract class Personnage
    {
        private string nomPerso;
        //private Metier metierPerso;
        private Byte vitessePerso;
        private Byte forcePerso;
        private Byte endurancePerso;
        private Byte viePerso =25;
        private List<Arme> listeArmes;
        public Personnage(string nomPerso, List<Arme> listeArmes)
        {
            Console.WriteLine("Création de personnage :\n");
            var saisieValid = false;
            string saisie;
            do
            {
                Console.WriteLine("Veuillez saisir les statistiques du personnages, vous avez 25 points à distribués");
                do
                {
                    Console.WriteLine("Vitesse du personnage : (nombre) ");
                    saisie = Console.ReadLine();
                    saisieValid = Byte.TryParse(saisie,out this.vitessePerso);
                    if (this.vitessePerso > 25)
                    {
                        saisieValid = false;
                    }
                    if (saisieValid == false)
                    {
                        Console.WriteLine("Erreur de saisie, veuillez recommencer !");
                    }
                } while (saisieValid == false);
                saisieValid = false;
                do
                {
                    Console.WriteLine("Force du personnage : (nombre) ");
                    saisie = Console.ReadLine();
                    saisieValid = Byte.TryParse(saisie, out this.forcePerso);
                    if (this.forcePerso > 25)
                    {
                        saisieValid = false;
                    }
                    if (saisieValid == false)
                    {
                        Console.WriteLine("Erreur de saisie, veuillez recommencer !");
                    }
                } while (saisieValid == false);
                saisieValid = false;
                do
                {
                    Console.WriteLine("Endurance du personnage : (nombre) ");
                    saisie = Console.ReadLine();
                    saisieValid = Byte.TryParse(saisie, out this.endurancePerso);
                    if (this.endurancePerso > 25)
                    {
                        saisieValid = false;
                    }
                    if (saisieValid == false)
                    {
                        Console.WriteLine("Erreur de saisie, veuillez recommencer !");
                    }
                } while (saisieValid == false);
                saisieValid = false;
                if (this.endurancePerso + this.forcePerso + this.vitessePerso > 25)
                {
                    Console.WriteLine("Vous avez donner trop de point !!");
                }
                else
                {
                    saisieValid = true;
                }

            } while (saisieValid == false);
            this.nomPerso = nomPerso;
            this.listeArmes = listeArmes;
        }
        public virtual void afficherStats()
        {
        Console.WriteLine($"Nom : {this.nomPerso}, " +
            $"Vitesse : {this.vitessePerso}, " +
            $"Force : {this.forcePerso}, " +
            $"Endurance : {this.endurancePerso}, " +
            $"Vie : {this.viePerso}.");
            Console.WriteLine("Equipement :");
            foreach (Arme armes in listeArmes)
            {
                Console.WriteLine("- "+armes.NomArme);
            }
        }
        public abstract void o_attaquer();
        public abstract void n_attaquer();
        public string NomPerso { get => nomPerso; set => nomPerso = value; }
        public Byte ViePerso { get => viePerso;}
        internal List<Arme> ListeArmes { get => listeArmes; set => listeArmes = value; }
        

    }
}