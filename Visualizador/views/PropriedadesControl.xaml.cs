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
    public enum Escala
    {
        Normal,
        Logaritmica
    }

    public class SelecionouEscalaArgs : EventArgs
    {
        public Escala escala;
    }

    /// <summary>
    /// Interaction logic for PropriedadesControl.xaml
    /// </summary>
    public partial class PropriedadesControl : UserControl
    {
        public PropriedadesControl()
        {
            InitializeComponent();
        }

        public event Action<object, SelecionouEscalaArgs> SelecionouEscala;

        public event Action<object, EventArgs> Selecionou;

        private void EscalaComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (SelecionouEscala != null)
                    SelecionouEscala(this, new SelecionouEscalaArgs
                    {
                        escala = (Escala) ((ComboBox) sender).SelectedItem
                    });
            }
            catch (Exception)
            {
                
            }
        }

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Selecionou != null) Selecionou(this, new EventArgs());
        }
    }
}
