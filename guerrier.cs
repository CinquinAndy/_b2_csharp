using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Guerrier:Metier
    {
        int tauxRage;
        public Guerrier(int experience,int tauxRage)
        {
            experienceMetier = experience;
            this.tauxRage = tauxRage;
        }
    }
}
