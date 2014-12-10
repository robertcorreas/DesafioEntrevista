using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            string filePath = @"Dados da curva.xml";
            model = (Curva) new XmlSerializer(typeof(Curva)).Deserialize(new StreamReader(filePath));
        }
    }
}
