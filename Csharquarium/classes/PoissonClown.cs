using Csharquarium.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public class PoissonClown : Carnivore
    {
        

        public Sexuality sexu = Sexuality.hermaphroditeOpportuniste;
        public PoissonClown(Sexe sexe, string name, int age, int vie) : base(sexe, name, age, vie)
        {

        }
        public PoissonClown(Sexe sexe, string name, int age) : base(sexe, name, age)
        {

        }
        public PoissonClown(string name, int age) : base(Sexe.Femelle, name, age)
        {

        }
        public override EtreVivant SeReproduire(EtreVivant partenaire)
        {
            if (this.GetType() != partenaire.GetType() || this.PtsVie < 5 || partenaire.PtsVie < 5)
            {


                return null;



            }else if ((this.PtsVie > 5 && partenaire.PtsVie > 5) && (this.GetType() == partenaire.GetType()))
                {
                
                int rdnValue = RandomAll.GetRandom(1);

                string randomNameF = RandomNameF();
                string randomNameM = RandomNameM();


                
                    if ((this.Sexe == partenaire.Sexe) && (this.Sexe == Sexe.Femelle))
                    {
                        this.Sexe = Sexe.Male;

                    if (rdnValue == 1)
                    {

                        EtreVivant fPoisson = new PoissonClown(Sexe.Femelle, randomNameF, 0);
                        return fPoisson;
                    }
                    else
                    {

                        EtreVivant mPoisson = new PoissonClown(Sexe.Male, randomNameM, 0);
                        return mPoisson;
                    }
                }
                    else if ((this.Sexe == partenaire.Sexe) && (this.Sexe == Sexe.Male))
                    { 
                        this.Sexe = Sexe.Femelle;

                    if (rdnValue == 1)
                    {

                        EtreVivant fPoisson = new PoissonClown(Sexe.Femelle, randomNameF, 0);
                        return fPoisson;
                    }
                    else
                    {

                        EtreVivant mPoisson = new PoissonClown(Sexe.Male, randomNameM, 0);
                        return mPoisson;
                    }
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
