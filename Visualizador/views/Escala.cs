using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visualizador2.views
{
    public enum Escala
    {
        Normal,
        Logaritmica
    }

    public class SeleciouEscalaArgs : EventArgs
    {
        public Escala escala;
    }

    public delegate void SeleciouEscalaHandler(object sender, SeleciouEscalaArgs args);
}
