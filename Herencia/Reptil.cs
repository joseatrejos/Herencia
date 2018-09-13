using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Reptil : Animal
    {
        // Con override, sobreescribes el abstract de la clase animal para poder instanciar la función desplazar
        override public string desplazar()
        {
            return Nombre + " se está desplazando";
        }

        public string cambiarPiel()
        {
            return Nombre + " cambió de piel\n";
        }
    }
}
