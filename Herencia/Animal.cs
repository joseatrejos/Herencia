using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    // Haciendola abstract logras evitar que se creen instancias (entidades) de esta clase. http://www.upv.es/amiga/43.htm
    abstract class Animal
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }

        abstract public string desplazar();
    }
}
