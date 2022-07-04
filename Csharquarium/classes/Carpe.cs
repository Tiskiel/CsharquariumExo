using Csharquarium.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public class Carpe : Herbivore
    {
        

        public Sexuality sexu = Sexuality.monoSexue;
        public Carpe(Sexe sexe, string name, int age, int vie) : base(sexe, name, age, vie)
        {

        }
        public Carpe(Sexe sexe, string name, int age) : base(sexe, name, age)
        {

        }
        public Carpe(string name, int age) : base(Sexe.Femelle, name, age)
        {

        }
        public override EtreVivant SeReproduire(EtreVivant partenaire)
        {
            if ((this.PtsVie > 5 && partenaire.PtsVie >5) && (this.GetType() == partenaire.GetType()))
            {
                
                int rdnValue = RandomAll.GetRandom(1);

                string randomNameF = RandomNameF();
                string randomNameM = RandomNameM();


                if ((this.GetType() == partenaire.GetType()) && (this.Sexe != partenaire.Sexe))
                {
                    if (rdnValue == 1)
                    {
                        
                        EtreVivant fPoisson = new Carpe(Sexe.Femelle, randomNameF, 0);
                        return fPoisson;
                    }
                    else
                    {
                        
                        EtreVivant mPoisson = new Carpe(Sexe.Male, randomNameM, 0);
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
