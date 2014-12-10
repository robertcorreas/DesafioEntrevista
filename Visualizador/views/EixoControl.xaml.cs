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

namespace Visualizador.views
{
    /// <summary>
    /// Interaction logic for EixoControl.xaml
    /// </summary>
    public partial class EixoControl : UserControl
    {
        public event Action<object, EventArgs> ClicouRestaurar;

        public event Action<object, EventArgs> InseriuCoordenada;

        public EixoControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ClicouRestaurar != null) ClicouRestaurar(this, new EventArgs());
        }

        private void OnSourceUpdated(object sender, DataTransferEventArgs e)
        {
            if (InseriuCoordenada != null) InseriuCoordenada(this, new EventArgs());
        }
    }
}
