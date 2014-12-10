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
using Visualizador.viewModels;

namespace Visualizador.views
{
    public delegate void FiltroHandler(object sender, decimal pos);
    /// <summary>
    /// Interaction logic for FiltroWindow.xaml
    /// </summary>
    public partial class FiltroControl : UserControl
    {
        public event Action<object, EventArgs> ClicouRestaurar;

        public event Action<object, EventArgs> InseriuCoordenada;

        public FiltroControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dataContext = DataContext;
            if (ClicouRestaurar != null) ClicouRestaurar(this, new EventArgs());
        }

        private void OnSourceUpdated(object sender, DataTransferEventArgs e)
        {
            if (InseriuCoordenada != null) InseriuCoordenada(this, new EventArgs());
        }
    }
}
