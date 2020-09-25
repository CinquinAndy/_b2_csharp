using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Mage:Metier
    {
        int maitriseMagie;
        public Mage(int experience, int maitriseMagie)
        {
            experienceMetier = experience;
            this.maitriseMagie = maitriseMagie;
        }
    }
}
