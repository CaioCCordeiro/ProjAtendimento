using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAtendimento
{
    class Guiches
    {
        List<Guiche> listaGuiches;

        internal List<Guiche> ListaGuiches { get => listaGuiches; set => listaGuiches = value; }

        public Guiches()
        {
            ListaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche g)
        {
            ListaGuiches.Add(g);
        }
    }
}
