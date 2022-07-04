using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharquarium.Enumeration;
using Csharquarium.Interface;

namespace Csharquarium.classes
{
    [Serializable]
    public abstract class Herbivore : Poisson
    {
        
        public Herbivore(Sexe sexe, string name, int age, int  vie ) : base(sexe, name, age, vie )
        {

        }
        public Herbivore(Sexe sexe, string name, int age) : base(sexe, name, age)
        {

        }
        public void Manger(Algue algue)
        {   
            int dgtsH = 2;
            algue.PtsVie -= dgtsH;
            PtsVie += 3;
            
        }
    }
}
