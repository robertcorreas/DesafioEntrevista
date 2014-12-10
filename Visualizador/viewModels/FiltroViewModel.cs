using System;
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
                if (value > FiltroMaxX) throw new ArgumentException("O valor deve ser inferior à " + FiltroMaxX);
                _filtroMinX = value;
            }
        }

        private ushort _filtroMaxX;
        public ushort FiltroMaxX
        {
            get { return _filtroMaxX; }
            set
            {
                if (value < FiltroMinX) throw new ArgumentException("O valor deve ser superior à " + FiltroMinX);
                _filtroMaxX = value;
            }
        }

        private decimal _filtroMinY;
        public decimal FiltroMinY
        {
            get
            {
                return _filtroMinY;
            }
            set
            {
                if (value > FiltroMaxY) throw new ArgumentException("O valor deve ser inferior à " + FiltroMaxY);
                _filtroMinY = value;
            }
        }

        private decimal _filtroMaxY;
        public decimal FiltroMaxY
        {
            get { return _filtroMaxY; }
            set
            {
                if (value < FiltroMinY) throw new ArgumentException("O valor deve ser superior à " + FiltroMinY);
                _filtroMaxY = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public FiltroViewModel()
        {
            FiltroMinX = ushort.MinValue;
            FiltroMaxX = ushort.MaxValue;
            FiltroMinY = decimal.MinValue;
            FiltroMaxY = decimal.MaxValue;
        }
    }
}