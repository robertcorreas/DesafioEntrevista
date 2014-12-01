using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Xml.Serialization;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Visualizador.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        ushort _MaxX;
        public ushort MaxX
        {
            get
            {
                return _MaxX;
            }
            set
            {
                if (value > MaxXPontos())
                {
                    throw new Exception("X acima do limite superior");
                }
                else
                {
                    _MaxX = value;
                    NotifyPropertyChanged("Pontos");
                }
                NotifyPropertyChanged("MaxX");
            }
        }
        decimal _MaxY;
        public decimal MaxY
        {
            get
            {
                return _MaxY;
            }
            set
            {
                if (value > MaxYPontos()) throw new Exception("Y acima do limite superior.");
                else
                {
                    _MaxY = value;
                    NotifyPropertyChanged("Pontos");
                }
                NotifyPropertyChanged("MaxY");
            }
        }
        ushort _MinX;
        public ushort MinX
        {
            get
            {
                return _MinX;
            }
            set
            {
                if (value < MinXPontos()) throw new Exception("X abaixo do limite inferior.");
                else
                {
                    _MinX = value;
                    NotifyPropertyChanged("Pontos");
                }
                NotifyPropertyChanged("MinX");
            }
        }
        decimal _MinY;
        public decimal MinY
        {
            get
            {
                return _MinY;
            }
            set
            {
                if (value < MinYPontos()) throw new Exception("Y abaixo do limite inferior.");
                else
                {
                    _MinY = value;
                    NotifyPropertyChanged("Pontos");
                }
                NotifyPropertyChanged("MinY");
            }
        }
        public ICollection<CurvaPonto> Pontos
        {
            get
            {
                return _curva.Pontos.Where(ponto => ponto.X <= MaxX && ponto.X >= MinX && ponto.Y <= MaxY && ponto.Y >= MinY).ToList();
                NotifyPropertyChanged("Pontos");
            }
            set
            {

            }
        }
        Curva _curva;
        ushort MinXPontos()
        {
            return _curva.Pontos.Select(p => p.X).Min();
        }
        decimal MinYPontos()
        {
            return _curva.Pontos.Select(p => p.Y).Min();
        }
        ushort MaxXPontos()
        {
            return _curva.Pontos.Select(p => p.X).Max();
        }
        decimal MaxYPontos()
        {
            return _curva.Pontos.Select(p => p.Y).Max();
        }

        public void Restaurar()
        {
            MinX = MinXPontos();
            MaxX = MaxXPontos();
            MinY = MinYPontos();
            MaxY = MaxYPontos();
        }
        public ViewModel() : base()
        {
            //string filePath = @"C:\Users\IDCE\Documents\Visual Studio 2010\Projects\Visualizador\Visualizador\bin\Debug\Dados da curva.xml";//
            string filePath = @"Dados da curva.xml";

            _curva = (Curva)new XmlSerializer(typeof(Curva)).Deserialize(new StreamReader(filePath));
            Restaurar();            
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
