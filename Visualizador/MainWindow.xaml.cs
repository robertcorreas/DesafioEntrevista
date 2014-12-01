﻿using System.Windows;
using Visualizador.ViewModels;

namespace Visualizador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModel)Grid.DataContext).Restaurar();
        }
    }
}