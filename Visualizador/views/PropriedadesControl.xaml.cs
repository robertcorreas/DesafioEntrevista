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

namespace Visualizador2.views
{
    /// <summary>
    /// Interaction logic for PropriedadesControl.xaml
    /// </summary>
    public partial class PropriedadesControl : UserControl
    {
        public PropriedadesControl()
        {
            DataContext = this;
            InitializeComponent();
            CorComboBox.SelectedIndex = 0;
            TracejadoComboBox.SelectedIndex = 0;
        }

        public LinearGradientBrush CorSelecionada
        {
            get { return (LinearGradientBrush)GetValue(CorSelecionadaProperty); }
            set { SetValue(CorSelecionadaProperty, value); }
        }

        public static readonly DependencyProperty CorSelecionadaProperty = DependencyProperty.Register(
            "CorSelecionada", typeof (LinearGradientBrush), typeof (PropriedadesControl), new UIPropertyMetadata(default(LinearGradientBrush)));

        public string TracejadoSelecionado
        {
            get { return (string)GetValue(TracejadoSelecionadoProperty); }
            set { SetValue(TracejadoSelecionadoProperty, value); }
        }

        public static readonly DependencyProperty TracejadoSelecionadoProperty = DependencyProperty.Register(
            "TracejadoSelecionado", typeof(string), typeof(PropriedadesControl), new UIPropertyMetadata(default(string)));

        public Escala EscalaSelecionada
        {
            get { return (Escala)GetValue(EscalaSelecionadaProperty); }
            set { SetValue(EscalaSelecionadaProperty, value); }
        }

        public static readonly DependencyProperty EscalaSelecionadaProperty = DependencyProperty.Register(
            "EscalaSelecionada", typeof(Escala), typeof(PropriedadesControl), new UIPropertyMetadata(default(Escala)));

        public event SeleciouEscalaHandler SelecionouEscala;

        private void EscalaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelecionouEscala != null) SelecionouEscala(this, new SeleciouEscalaArgs
            {
                escala = (Escala)((ComboBox)sender).SelectedItem
            });
        }
    }
}
