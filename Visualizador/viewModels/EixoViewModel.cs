using System;
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
                if (value > EixoMaxX) throw new ArgumentException("O valor deve ser inferior à " + EixoMaxX);
                _eixoMinX = value;
            }
        }

        private int _eixoMaxX;
        public int EixoMaxX
        {
            get { return _eixoMaxX; }
            set
            {
                if (value < EixoMinX) throw new ArgumentException("O valor deve ser superior à " + EixoMinX);
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
                if (value > EixoMaxY) throw new ArgumentException("O valor deve ser inferior à " + EixoMaxY);
                _eixoMinY = value;
            }
        }

        private int _eixoMaxY;
        public int EixoMaxY
        {
            get { return _eixoMaxY; }
            set
            {
                if (value < EixoMinY) throw new ArgumentException("O valor deve ser superior à " + EixoMinY);
                _eixoMaxY = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public EixoViewModel()
        {
            EixoMinX = int.MinValue;
            EixoMaxX = int.MaxValue;
            EixoMinY = int.MinValue;
            EixoMaxY = int.MaxValue;
        }
    }
}