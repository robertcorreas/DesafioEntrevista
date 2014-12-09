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
    /// Interaction logic for EixoControl.xaml
    /// </summary>
    public partial class EixoControl : UserControl
    {
        public EixoControl()
        {
            DataContext = this;
            InitializeComponent();
        }

        public int EixoXMin
        {
            get { return (int)GetValue(EixoXMinProperty); }
            set { SetValue(EixoXMinProperty, value); }
        }

        public static readonly DependencyProperty EixoXMinProperty = DependencyProperty.Register(
            "EixoXMin", typeof(int), typeof(EixoControl), new UIPropertyMetadata(default(int)));

        public int EixoXMax
        {
            get { return (int)GetValue(EixoXMaxProperty); }
            set { SetValue(EixoXMaxProperty, value); }
        }

        public static readonly DependencyProperty EixoXMaxProperty = DependencyProperty.Register(
            "EixoXMax", typeof(int), typeof(EixoControl), new UIPropertyMetadata(default(int)));

        public int EixoYMin
        {
            get { return (int)GetValue(EixoYMinProperty); }
            set { SetValue(EixoYMinProperty, value); }
        }

        public static readonly DependencyProperty EixoYMinProperty = DependencyProperty.Register(
            "EixoYMin", typeof(int), typeof(EixoControl), new UIPropertyMetadata(default(int)));

        public int EixoYMax
        {
            get { return (int)GetValue(EixoYMaxProperty); }
            set { SetValue(EixoYMaxProperty, value); }
        }

        public static readonly DependencyProperty EixoYMaxProperty = DependencyProperty.Register(
            "EixoYMax", typeof(int), typeof(EixoControl), new UIPropertyMetadata(default(int)));

        public int PontosNaEscalaXMin { get; set; }
        public int PontosNaEscalaXMax { get; set; }
        public int PontosNaEscalaYMin { get; set; }
        public int PontosNaEscalaYMax { get; set; }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RestaurarEixo();
        }

        public void RestaurarEixo()
        {
            EixoXMin = PontosNaEscalaXMin;
            EixoXMax = PontosNaEscalaXMax;
            EixoYMin = PontosNaEscalaYMin;
            EixoYMax = PontosNaEscalaYMax;
        }
    }
}
