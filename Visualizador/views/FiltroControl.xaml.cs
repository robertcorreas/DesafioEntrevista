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
using System.Windows.Shapes;
using Visualizador2.models;

namespace Visualizador2.views
{
    public delegate void FiltroHandler(object sender, decimal pos);
    /// <summary>
    /// Interaction logic for FiltroWindow.xaml
    /// </summary>
    public partial class FiltroControl : UserControl
    {
        public FiltroControl()
        {
            InitializeComponent();


        }

        public event FiltroHandler InseriuFiltroMinX;
        public event FiltroHandler InseriuFiltroMaxX;
        public event FiltroHandler InseriuFiltroMinY;
        public event FiltroHandler InseriuFiltroMaxY;

        public int PontosNaEscalaXMin { get; set; }
        public int PontosNaEscalaXMax { get; set; }
        public int PontosNaEscalaYMin { get; set; }
        public int PontosNaEscalaYMax { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((Model)DataContext).RestaurarFiltro();
        }
    }
}
