using Csharquarium.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharquarium.Interface
{
    public interface IPoisson 
    {
        string Name { get; set; }
        Sexe Sexe { get;}

        int Age { get; set; }

        
    }
}
