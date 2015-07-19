using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Visualizador.views;

namespace Visualizador.viewModels
{
    public class PropriedadesViewModel : INotifyPropertyChanged
    {
        public Escala EscalaSelecionada { get; set; }
        public object CorSelecionada { get; set; }
        public string TracejadoSelecionado { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
