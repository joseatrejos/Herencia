using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Mamifero : Animal
    {
        // Con override, sobreescribes el abstract de la clase animal para poder instanciar la función desplazar
        override public string desplazar()
        {
            return Nombre + " está caminando";
        }

        public string cazo()
        {
            return Nombre + " cazó un animal\n";
        }
    }
}
