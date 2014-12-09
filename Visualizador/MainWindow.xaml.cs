using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Visualizador2.models;
using Visualizador2.views;

namespace Visualizador2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RestaurarEixo();
            RestaurarFiltro();
        }

        public void OnSelecionouEscala(object sender, SeleciouEscalaArgs args)
        {
            ((Model)DataContext).Escala = args.escala;
            RestaurarEixo();
            RestaurarFiltro();
        }

        public void RestaurarEixo()
        {
            EixoControl.PontosNaEscalaXMin = ((Model)DataContext).PontosNaEscala.Min(ponto => ponto.X);
            EixoControl.PontosNaEscalaXMax = ((Model)DataContext).PontosNaEscala.Max(ponto => ponto.X);
            EixoControl.PontosNaEscalaYMin = (int)((Model)DataContext).PontosNaEscala.Min(ponto => ponto.Y);
            EixoControl.PontosNaEscalaYMax = (int)((Model)DataContext).PontosNaEscala.Max(ponto => ponto.Y);
            EixoControl.RestaurarEixo();
        }
        
        public void RestaurarFiltro()
        {
            FiltroControl.PontosNaEscalaXMin = ((Model)DataContext).PontosNaEscala.Min(ponto => ponto.X);
            FiltroControl.PontosNaEscalaXMax = ((Model)DataContext).PontosNaEscala.Max(ponto => ponto.X);
            FiltroControl.PontosNaEscalaYMin = (int)((Model)DataContext).PontosNaEscala.Min(ponto => ponto.Y);
            FiltroControl.PontosNaEscalaYMax = (int)((Model)DataContext).PontosNaEscala.Max(ponto => ponto.Y);
            ((Model)DataContext).RestaurarFiltro();
        }
    }
}
