using System;
using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Visualizador.views;

namespace Visualizador
{
    [TestClass]
    public class VisualizadorUnitTests
    {
        [TestMethod]
        public void UsuarioDevePoderEscolherCorDoGrafico()
        {
            //Arrange
            var window = new MainWindow();
            var random = new Random();

            //Act
            window.Show();
            window.propriedadesControl.CorComboBox.SelectedIndex =
                random.Next(((LinearGradientBrush[])window.propriedadesControl.CorComboBox.ItemsSource).Length);

            //Assert
            Assert.AreSame(window.propriedadesControl.CorComboBox.SelectedItem, window.serie.Brush);
        }

        [TestMethod]
        public void UsuarioDevePoderEscolherTracejadoDoGrafico()
        {
            //Arrange
            var window = new MainWindow();
            var random = new Random();

            //Act
            window.Show();
            window.propriedadesControl.CorComboBox.SelectedIndex =
                random.Next(((string[])window.propriedadesControl.TracejadoComboBox.ItemsSource).Length);

            //Assert
            Assert.AreSame(window.propriedadesControl.CorComboBox.SelectedItem, window.serie.Brush);
        }
    }
}
