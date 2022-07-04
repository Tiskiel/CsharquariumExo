using Csharquarium.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public class Sole : Herbivore
    {
        
        

        public Sexuality sexu = Sexuality.hermaphroditeOpportuniste;

        public Sole(Sexe sexe, string name, int age, int vie )  : base(sexe, name, age, vie )
        {

        }
        public Sole(Sexe sexe, string name, int age) : base(sexe, name, age)
        {

        }
        public Sole(string  name, int age) : base(Sexe.Femelle, name, age)
        {

        }
        public override EtreVivant SeReproduire(EtreVivant partenaire)
        {
            if ((this.PtsVie > 5 && partenaire.PtsVie > 5) && (this.GetType() == partenaire.GetType()))
            {

                int rdnValue = RandomAll.GetRandom(1);

                string randomNameF = RandomNameF();
                string randomNameM = RandomNameM();


                
                    if ((this.Sexe == partenaire.Sexe) && (this.Sexe == Sexe.Femelle))
                    {
                        this.Sexe = Sexe.Male;
                    }
                    else this.Sexe = Sexe.Femelle;
                    if (rdnValue == 1)
                    {

                        EtreVivant fPoisson = new Sole(Sexe.Femelle, randomNameF, 0);
                        return fPoisson;
                    }
                    else
                    {

                        EtreVivant mPoisson = new Sole(Sexe.Male, randomNameM, 0);
                        return mPoisson;
                    }



                


                
            }
            return null;
        }

        public override EtreVivant SeReproduire()
        {
            return null;
        }

        
    }
}
