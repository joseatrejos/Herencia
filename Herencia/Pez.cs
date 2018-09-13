using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Pez : Animal
    {
        // Con override, sobreescribes el abstract de la clase animal para poder instanciar la función desplazar
        override public string desplazar()
        {
            return Nombre + " está nadando";
        }

        public string comioPlankton()
        {
            return Nombre + " comió plankton\n";
        }
    }
}
