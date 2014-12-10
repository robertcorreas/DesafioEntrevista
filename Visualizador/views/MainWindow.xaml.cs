using System;
using System.Linq;
using System.Windows;
using Visualizador.viewModels;
using Visualizador.views;

namespace Visualizador.views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel;

        public MainWindow()
        {
            mainViewModel = new MainViewModel();
            Focus();
            InitializeComponent();
            DataContext = mainViewModel;
            eixoControl.DataContext = mainViewModel.eixoViewModel;
            filtroControl.DataContext = mainViewModel.filtroViewModel;
            propriedadesControl.DataContext = mainViewModel.propriedadesViewModel;

            RestaurarEixo();
            RestaurarFiltro();
        }

        public void OnSelecionouEscala(object sender, SelecionouEscalaArgs args)
        {
            mainViewModel.EixoXMin = int.MinValue;
            mainViewModel.EixoXMax = int.MaxValue;
            mainViewModel.EixoYMin = int.MinValue;
            mainViewModel.EixoYMax = int.MaxValue;
            XAxe.MinimumValue = int.MinValue;
            XAxe.MaximumValue = int.MaxValue;
            YAxe.MinimumValue = int.MinValue;
            YAxe.MaximumValue = int.MaxValue;
            RestaurarEixo();
            RestaurarFiltro();
            mainViewModel.NotifyPropertiesChanged();
        }

        public void RestaurarEixo()
        {
            mainViewModel.eixoViewModel.EixoMinX = ((MainViewModel)DataContext).PontosNaEscala.Min(ponto => ponto.X);
            mainViewModel.eixoViewModel.EixoMaxX = ((MainViewModel)DataContext).PontosNaEscala.Max(ponto => ponto.X);
            mainViewModel.eixoViewModel.EixoMinY = (int)((MainViewModel)DataContext).PontosNaEscala.Min(ponto => ponto.Y);
            mainViewModel.eixoViewModel.EixoMaxY = (int)((MainViewModel)DataContext).PontosNaEscala.Max(ponto => ponto.Y);
        }
        
        public void RestaurarFiltro()
        {
            mainViewModel.filtroViewModel.FiltroMinX = ((MainViewModel)DataContext).PontosNaEscala.Min(ponto => ponto.X);
            mainViewModel.filtroViewModel.FiltroMaxX = ((MainViewModel)DataContext).PontosNaEscala.Max(ponto => ponto.X);
            mainViewModel.filtroViewModel.FiltroMinY = ((MainViewModel)DataContext).PontosNaEscala.Min(ponto => ponto.Y);
            mainViewModel.filtroViewModel.FiltroMaxY = ((MainViewModel)DataContext).PontosNaEscala.Max(ponto => ponto.Y);
        }

        private void Window_ContentRendered(object sender, System.EventArgs e)
        {
            propriedadesControl.CorComboBox.SelectedIndex = 0;
            propriedadesControl.TracejadoComboBox.SelectedIndex = 0;
            propriedadesControl.EscalaComboBox.SelectedIndex = 0;
        }

        private void FiltroControl_OnClicouRestaurar(object arg1, EventArgs arg2)
        {
            RestaurarFiltro();
            mainViewModel.NotifyPropertiesChanged();
        }

        private void OnInseriuCoordenada(object arg1, EventArgs arg2)
        {
            mainViewModel.NotifyPropertiesChanged();
        }

        private void EixoControl_OnClicouRestaurar(object arg1, EventArgs arg2)
        {
            RestaurarEixo();
            mainViewModel.NotifyPropertiesChanged();
        }

        private void OnSelecionou(object arg1, EventArgs arg2)
        {
            mainViewModel.NotifyPropertiesChanged();
        }
    }
}