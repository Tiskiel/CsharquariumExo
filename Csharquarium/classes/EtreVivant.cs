using Csharquarium.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public abstract class EtreVivant
    {
        private int _ptsVie = 10;
        private int _age;
        private Sexe _sexe;
        
        

        public int PtsVie { get => _ptsVie; set => _ptsVie = value; }
        public int Age { get => _age; set => _age = value; }
        public Sexe Sexe { get => _sexe; set => _sexe = value; }
        

        public abstract EtreVivant SeReproduire();
        public abstract EtreVivant SeReproduire(EtreVivant a);



        public void Viellir()
        {
            this.Age++;
        }
        
    }
}
