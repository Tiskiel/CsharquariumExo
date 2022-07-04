using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public class Algue : EtreVivant
    {
        public Algue(int vie,  int age)
        {
            PtsVie = vie;
            Age = age;
        }
        public override EtreVivant SeReproduire()
        {
            if (this.Age >= 10)
            {
                this.PtsVie = this.PtsVie / 2;
                Algue nAlgue = new Algue((int)this.PtsVie / 2, 0);
                return nAlgue;
            }
            return null;
        }
        public void PvUp()
        {
            PtsVie++;
        }

        public override EtreVivant SeReproduire(EtreVivant a)
        {
            return null;
        }
    }
}
