using System.ComponentModel;

namespace Visualizador.viewModels
{
    public class EixoViewModel : INotifyPropertyChanged
    {
        private int _eixoMinX;
        public int EixoMinX
        {
            get
            {
                return _eixoMinX;
            }
            set
            {
                _eixoMinX = value;
                NotifyPropertyChanged("EixoMinX");
                NotifyPropertyChanged("PontosNaEscalaNoEixo");
            }
        }
        private int _eixoMaxX;
        public int EixoMaxX
        {
            get { return _eixoMaxX; }
            set
            {
                _eixoMaxX = value;
                NotifyPropertyChanged("EixoMaxX");
                NotifyPropertyChanged("PontosNaEscalaNoEixo");
            }
        }
        private int _eixoMinY;
        public int EixoMinY
        {
            get { return _eixoMinY; }
            set
            {
                _eixoMinY = value;
                NotifyPropertyChanged("EixoMinY");
                NotifyPropertyChanged("PontosNaEscalaNoEixo");
            }
        }
        private int _eixoMaxY;
        public int EixoMaxY
        {
            get { return _eixoMaxY; }
            set
            {
                _eixoMaxY = value;
                NotifyPropertyChanged("EixoMaxY");
                NotifyPropertyChanged("PontosNaEscalaNoEixo");
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