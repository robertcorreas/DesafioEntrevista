using System;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Windows.Forms;
using Visualizador.Properties;

namespace Visualizador.viewModels
{
    public class FiltroViewModel : INotifyPropertyChanged
    {
        private int _filtroMinX;
        public int FiltroMinX
        {
            get
            {
                return _filtroMinX;
            }
            set
            {
                if (value < 0)
                {
                    System.Windows.MessageBox.Show(Resources.RangeExceptionMessage);
                    throw new ArgumentException(Resources.RangeExceptionMessage);
                }
                _filtroMinX = value;
            }
        }

        private int _filtroMaxX;
        public int FiltroMaxX
        {
            get { return _filtroMaxX; }
            set
            {
                if (value < 0)
                {
                    System.Windows.MessageBox.Show(Resources.RangeExceptionMessage);
                    throw new ArgumentException(Resources.RangeExceptionMessage);
                }

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
                if (value < 0)
                {
                    System.Windows.MessageBox.Show(Resources.RangeExceptionMessage);
                    throw new ArgumentException(Resources.RangeExceptionMessage);
                }

                _filtroMinY = value;
            }
        }

        private decimal _filtroMaxY;
        public decimal FiltroMaxY
        {
            get { return _filtroMaxY; }
            set
            {
                if (value < 0)
                {
                    System.Windows.MessageBox.Show(Resources.RangeExceptionMessage);
                    throw new ArgumentException(Resources.RangeExceptionMessage);
                }
                _filtroMaxY = value;
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