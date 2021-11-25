using System.Collections;
using System.Collections.Generic;

namespace AlertasTempranas.Modelos
{
    public class Estudiante
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Programa { get; set; }
        public IList<ComponenteEstudiante> Componentes { get; set; }
    }
}
