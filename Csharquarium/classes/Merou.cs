﻿using Csharquarium.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public class Merou : Carnivore
    {
        

        public Sexuality sexu = Sexuality.hermaphroditeAge;
        public Merou(Sexe sexe, string name, int age, int vie) : base(sexe, name, age, vie)
        {

        }
        public Merou(Sexe sexe, string name, int age) : base(sexe, name, age)
        {

        }
        public Merou(string name, int age) : base(Sexe.Femelle, name, age)
        {

        }
        

        public override EtreVivant SeReproduire(EtreVivant partenaire)
        {
            if (this.PtsVie > 5)
            {
                
                int rdnValue = RandomAll.GetRandom(1);

                string randomNameF = RandomNameF();
                string randomNameM = RandomNameM();


                if ((this.GetType() == partenaire.GetType() && this.Sexe == partenaire.Sexe) &&
                    (this.Age >= 10 && partenaire.Age >= 10 || this.Age < 10 && partenaire.Age < 10) && (this.PtsVie >= 5 && partenaire.PtsVie >= 5))
                {
                    if ((this.Age >= 10 && this.Sexe == Sexe.Femelle) || 
                        (partenaire.Age >= 10 && partenaire.Sexe == Sexe.Femelle))
                    {
                        this.Sexe = Sexe.Male;
                        partenaire.Sexe = Sexe.Male;
                    }
                    else if ((this.Age >= 10 && this.Sexe == Sexe.Male) ||
                        (partenaire.Age >= 10 && partenaire.Sexe == Sexe.Male))
                    {
                        this.Sexe = Sexe.Femelle;
                        partenaire.Sexe = Sexe.Femelle;

                    }
                    if (rdnValue == 1)
                    {

                        EtreVivant fPoisson = new Merou(Sexe.Femelle, randomNameF, 0);
                        return fPoisson;
                    }
                    else
                    {

                        EtreVivant mPoisson = new Merou(Sexe.Male, randomNameM, 0);
                        return mPoisson;
                    }



                }


                return null;
            }
            return null;
        }

        public override EtreVivant SeReproduire()
        {
            return null;
        }
    }
}