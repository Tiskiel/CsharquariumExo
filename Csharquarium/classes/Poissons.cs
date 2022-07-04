using Csharquarium.Enumeration;
using Csharquarium.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public abstract class Poisson : EtreVivant, IPoisson
    {
        

        public Sexe Sexe { get; set; }
        
        
        private string _Name;

        public string Name { get => _Name; set => _Name = value; }

        string[] letter = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j",
                    "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        string[] body = new string[26] { "lar", "bre", "por", "lur", "pper", "cre", "mil", "pro", "pig", "gre",
                    "jer", "ker", "nir", "mer", "pre", "oreo", "ploc", "soci",
                "riti", "crit", "titi", "zor", "crow", "wor", "yop", "xor" };

        public Poisson(Sexe sexe, string name, int age, int vie)
        {
            Sexe = sexe;
            Name = name;
            Age = age;
            PtsVie = vie;
            
        }
        public Poisson(Sexe sexe, string name, int age)
        {
            Sexe = sexe;
            Name = name;
            Age = age;
            

        }

        List<string> nameF = new List<string>();


        public void Faim()
        {
            if (PtsVie >= 5)
            {
                PtsVie--;
            }
        }
        public virtual string RandomNameF()
        {
            
            

            for (int i = 0; i < letter.Length; i++)
            {
                string fName = letter[RandomAll.GetRandom(letter.Length)] + body[RandomAll.GetRandom(letter.Length)] + letter[RandomAll.GetRandom(letter.Length)];
                nameF.Add(fName);
                
            }

            string femmeN = nameF[RandomAll.GetRandom(letter.Length)];
            return femmeN;

            

        }

        List<string> nameM = new List<string>();

        public virtual string RandomNameM()
        {
            
            
            
            

            for (int i = 0; i < letter.Length; i++)
            {
                
                string mName = letter[RandomAll.GetRandom(letter.Length)] + body[RandomAll.GetRandom(letter.Length)] + letter[RandomAll.GetRandom(letter.Length)];
                nameM.Add(mName);
            }


            string maleN = nameM[RandomAll.GetRandom(letter.Length)];
            return maleN;

        }
    }
}
