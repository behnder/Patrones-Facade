using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Facade
{
    class SelectorDeEscena
    {

        public void BuscarEscena(string tipo, string nombre)
        {
            Console.WriteLine($"Sea ha encontrado la escena {nombre} del tipo {tipo}");
            Console.WriteLine($"Agregándola a tu biblioteca de recursos");
        }
    }
}
