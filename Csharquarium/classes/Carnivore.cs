using Csharquarium.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public abstract class Carnivore : Poisson
    {
        public Carnivore(Sexe sexe, string name, int age, int vie) : base(sexe, name, age, vie)
        {

        }
        public Carnivore(Sexe sexe, string name, int age) : base(sexe, name, age)
        {

        }

        public void Manger(Poisson poisson)
        {
            if (this.GetType() != poisson.GetType())
            {
                int dgtsC = 4;
                if (poisson.PtsVie <= 4 && poisson.PtsVie > 0)
                {
                    
                    this.PtsVie += 5;
                    poisson.PtsVie -= dgtsC;
                }
                else if(poisson.PtsVie > 0)
                {
                    poisson.PtsVie -= dgtsC;
                }
            }
        }
    }
}
