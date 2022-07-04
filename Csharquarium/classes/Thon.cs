using Csharquarium.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public class Thon : Carnivore
    {
        

        public Sexuality sexu = Sexuality.monoSexue;

        public Thon(Sexe sexe, string name, int age, int vie) : base(sexe, name, age, vie)
        {

        }
        public Thon(Sexe sexe, string name, int age) : base(sexe, name, age)
        {

        }
        public Thon(string name, int age) : base(Sexe.Femelle, name, age)
        {

        }
        public override EtreVivant SeReproduire(EtreVivant partenaire)
        {
            if ((this.PtsVie > 5 && partenaire.PtsVie > 5) && (this.GetType() == partenaire.GetType()) && (this.Sexe != partenaire.Sexe))
            {
                
                int rdnValue = RandomAll.GetRandom(1);

                string randomNameF = RandomNameF();
                string randomNameM = RandomNameM();


                
                    if (rdnValue == 1)
                    {

                        EtreVivant fPoisson = new Thon(Sexe.Femelle, randomNameF, 0);
                        return fPoisson;
                    }
                    else
                    {

                        EtreVivant mPoisson = new Thon(Sexe.Male, randomNameM, 0);
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
