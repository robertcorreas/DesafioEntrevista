using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace Visualizador.models
{
    class Model
    {
        private Curva model;

        public IList<CurvaPonto> Pontos
        {
            get { return model.Pontos; }
        }
        
    public Model()
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = "Selecionar Dados do Gráfico",
                Filter = "Arquivo XML|*.xml"
            };
            openFileDialog.ShowDialog();
            model = (Curva)new XmlSerializer(typeof(Curva)).Deserialize(new StreamReader(openFileDialog.FileName));
        }
    }
}
