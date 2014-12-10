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
        private Escala _escalaSelecionada;
        public Escala EscalaSelecionada
        {
            get { return _escalaSelecionada; }
            set
            {
                _escalaSelecionada = value;
                NotifyPropertyChanged("Escala");
            }
        }

        private object _corSelecionada;
        public object CorSelecionada
        {
            get
            {
                return _corSelecionada;
            }
            set
            {
                _corSelecionada = value;
                NotifyPropertyChanged("CorSelecionada");
            }
        }

        private string _tracejadoSelecionado;
        public string TracejadoSelecionado
        {
            get
            {
                return _tracejadoSelecionado;
            }
            set
            {
                _tracejadoSelecionado = value;
                NotifyPropertyChanged("TracejadoSelecionado");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
