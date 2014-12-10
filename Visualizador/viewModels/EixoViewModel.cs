using System;
using System.ComponentModel;
using System.Windows.Media;
using Visualizador.Properties;

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
                if (value < 0)
                {
                    System.Windows.MessageBox.Show(Resources.RangeExceptionMessage);
                    throw new ArgumentException(Resources.RangeExceptionMessage);
                }
                _eixoMinX = value;
            }
        }

        private int _eixoMaxX;
        public int EixoMaxX
        {
            get { return _eixoMaxX; }
            set
            {
                if (value < 0)
                {
                    System.Windows.MessageBox.Show(Resources.RangeExceptionMessage);
                    throw new ArgumentException(Resources.RangeExceptionMessage);
                }
                _eixoMaxX = value;
            }
        }

        private int _eixoMinY;
        public int EixoMinY
        {
            get
            {
                return _eixoMinY;
            }
            set
            {
                if (value < 0)
                {
                    System.Windows.MessageBox.Show(Resources.RangeExceptionMessage);
                    throw new ArgumentException(Resources.RangeExceptionMessage);
                }
                _eixoMinY = value;
            }
        }

        private int _eixoMaxY;
        public int EixoMaxY
        {
            get { return _eixoMaxY; }
            set
            {
                if (value < 0)
                {
                    System.Windows.MessageBox.Show(Resources.RangeExceptionMessage);
                    throw new ArgumentException(Resources.RangeExceptionMessage);
                }
                _eixoMaxY = value;
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