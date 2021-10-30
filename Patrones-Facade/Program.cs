using System;

namespace Patrones_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckFacade usuario1 = new CheckFacade();
            usuario1.Buscar("SnowDragon", "Bestia", "Bosque de Gnash", "Bosque");
            Console.ReadKey();

        }
    }
}
