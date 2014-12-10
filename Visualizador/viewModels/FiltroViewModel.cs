using System.ComponentModel;

namespace Visualizador.viewModels
{
    public class FiltroViewModel : INotifyPropertyChanged
    {
        private ushort _filtroMinX;
        public ushort FiltroMinX
        {
            get
            {
                return _filtroMinX;
            }
            set
            {
                _filtroMinX = value;
                NotifyPropertyChanged("FiltroMinX");
                NotifyPropertyChanged("PontosNaEscalaNoFiltro");
            }
        }
        private ushort _filtroMaxX;
        public ushort FiltroMaxX
        {
            get { return _filtroMaxX; }
            set
            {
                _filtroMaxX = value;
                NotifyPropertyChanged("FiltroMaxX");
                NotifyPropertyChanged("PontosNaEscalaNoFiltro");
            }
        }
        private decimal _filtroMinY;
        public decimal FiltroMinY
        {
            get { return _filtroMinY; }
            set
            {
                _filtroMinY = value;
                NotifyPropertyChanged("FiltroMinY");
                NotifyPropertyChanged("PontosNaEscalaNoFiltro");
            }
        }
        private decimal _filtroMaxY;
        public decimal FiltroMaxY
        {
            get { return _filtroMaxY; }
            set
            {
                _filtroMaxY = value;
                NotifyPropertyChanged("FiltroMaxY");
                NotifyPropertyChanged("PontosNaEscalaNoFiltro");
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