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
using Visualizador.views;
using Visualizador.models;

namespace Visualizador.viewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Model model;

        public EixoViewModel eixoViewModel;
        public FiltroViewModel filtroViewModel;
        public PropriedadesViewModel propriedadesViewModel;

        public int EixoXMin
        {
            get { return eixoViewModel.EixoMinX; }
            set { eixoViewModel.EixoMinX = value; }
        }
        public int EixoXMax
        {
            get { return eixoViewModel.EixoMaxX; }
            set { eixoViewModel.EixoMaxX = value; }
        }
        public int EixoYMin
        {
            get { return eixoViewModel.EixoMinY; }
            set { eixoViewModel.EixoMinY = value; }
        }
        public int EixoYMax
        {
            get { return eixoViewModel.EixoMaxY; }
            set { eixoViewModel.EixoMaxY = value; }
        }
        public string Tracejado
        {
            get { return propriedadesViewModel.TracejadoSelecionado; }
            set { propriedadesViewModel.TracejadoSelecionado = value; }
        }
        public object Cor
        {
            get { return propriedadesViewModel.CorSelecionada; }
            set { propriedadesViewModel.CorSelecionada = value; }
        }
        
        public IEnumerable<CurvaPonto> PontosNaEscala
        {
            get
            {
                Func<double, double> escalador;
                switch (propriedadesViewModel.EscalaSelecionada)
                {
                    default:
                        escalador = (d) => d;
                        break;
                    case Escala.Logaritmica:
                        escalador = (d) => Math.Log(d);
                        break;
                }

                return model.Pontos.Select(ponto => new CurvaPonto
                {
                    X = ponto.X,
                    Y = (decimal)escalador((double)ponto.Y)
                });
            }
        }
        public IEnumerable<CurvaPonto> PontosNaEscalaNoFiltro
        {
            get
            {
                return PontosNaEscala.Where(ponto => ponto.X >= filtroViewModel.FiltroMinX && ponto.X <= filtroViewModel.FiltroMaxX &&
                                                     ponto.Y >= filtroViewModel.FiltroMinY && ponto.Y <= filtroViewModel.FiltroMaxY);
            }
        }

        public MainViewModel()
        {
            model = new Model();

            eixoViewModel = new EixoViewModel();
            filtroViewModel = new FiltroViewModel();
            propriedadesViewModel = new PropriedadesViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NotifyPropertiesChanged()
        {
            NotifyPropertyChanged("EixoXMin");
            NotifyPropertyChanged("EixoXMax");
            NotifyPropertyChanged("EixoYMin");
            NotifyPropertyChanged("EixoYMax");
            NotifyPropertyChanged("Tracejado");
            NotifyPropertyChanged("Cor");
            NotifyPropertyChanged("PontosNaEscalaNoFiltro");
        }
    }
}