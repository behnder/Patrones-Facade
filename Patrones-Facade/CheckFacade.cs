using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Facade
{
    class CheckFacade
    {
        private SelectorDeEnemigo selectorDeEnemigo;
        private SelectorDeEscena selectorDeEscena;

        public CheckFacade()
        {
            this.selectorDeEnemigo = new SelectorDeEnemigo();
            this.selectorDeEscena = new SelectorDeEscena();
        }

        public void Buscar(string nombreEnemigo, string tipoEnemigo, string nombreEscena, string tipoEscena)
        {
            selectorDeEnemigo.BuscarEnemigo(tipoEnemigo, nombreEnemigo);
            selectorDeEscena.BuscarEscena(tipoEscena, nombreEscena);
        }
    }
}
