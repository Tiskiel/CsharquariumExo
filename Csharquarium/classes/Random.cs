using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.classes
{
    [Serializable]
    public static class RandomAll
    {
        static Random rdn = new Random();
        public static int GetRandom(int max)
        {
            return rdn.Next(max);
        }

        
    }
}
