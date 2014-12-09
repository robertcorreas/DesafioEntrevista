using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using Visualizador;
using Visualizador2.views;

namespace Visualizador2.models
{
    public class Model : INotifyPropertyChanged
    {
        List<CurvaPonto> _pontos;

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

        private Escala _escala;

        public Escala Escala
        {
            get { return _escala; }
            set
            {
                _escala = value;
                NotifyPropertyChanged("PontosNaEscalaNoFiltro");
            }
        }

        public IEnumerable<CurvaPonto> PontosNaEscala
        {
            get
            {
                Func<double, double> escalador;
                switch (_escala)
                {
                    default:
                        escalador = (d) => d;
                        break;
                    case Escala.Logaritmica:
                         escalador = (d) => Math.Log(d);
                        break;
                }

                return _pontos.Select(ponto => new CurvaPonto
                {
                    X = ponto.X,
                    Y = (decimal) escalador((double)ponto.Y)
                });
            }
        }
        public IEnumerable<CurvaPonto> PontosNaEscalaNoFiltro
        {
            get
            {
                return PontosNaEscala.Where(ponto => ponto.X >= FiltroMinX && ponto.X <= FiltroMaxX && ponto.Y >= FiltroMinY && ponto.Y <= FiltroMaxY);
            }
        }

        public Model()
        {
            string filePath = @"Dados da curva.xml";
            string folderPath = @"C:\Users\Jyc\Documents\visual studio 2012\Projects\Visualizador2\Visualizador2\models\";
            filePath = folderPath + filePath;

            _pontos = ((Curva)new XmlSerializer(typeof(Curva)).Deserialize(new StreamReader(filePath))).Pontos;

            Escala = Escala.Normal;
        }

        public void RestaurarFiltro()
        {
            FiltroMinX = PontosNaEscala.Min(ponto => ponto.X);
            FiltroMaxX = PontosNaEscala.Max(ponto => ponto.X);
            FiltroMinY = (int)PontosNaEscala.Min(ponto => ponto.Y);
            FiltroMaxY = (int)PontosNaEscala.Max(ponto => ponto.Y);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}