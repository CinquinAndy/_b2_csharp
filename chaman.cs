using System;
using System.Collections.Generic;
using System.Text;

namespace _2020
{
    class Chaman:Metier
    {
        int maitriseDeLaNature;
        public Chaman(int experience,int maitriseDeLaNature)
        {
            experienceMetier = experience;
            this.maitriseDeLaNature = maitriseDeLaNature;
        }
    }
}
