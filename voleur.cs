using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Voleur:Metier
    {
        int maitriseVol;
        public Voleur(int experience, int maitriseVol)
        {
            experienceMetier = experience;
            this.maitriseVol = maitriseVol;
        }
    }
}
