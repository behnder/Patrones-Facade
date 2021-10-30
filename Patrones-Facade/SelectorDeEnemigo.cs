using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Facade
{
    class SelectorDeEnemigo
    {
        public void BuscarEnemigo(string tipo,string nombre)
        {
            Console.WriteLine($"Sea ha encontrado el enemigo {nombre} del tipo {tipo}");
            Console.WriteLine($"Agregándolo a tu biblioteca de recursos");
        }
    }
}
