using AlertasTempranas.Logica.Interfaces;
using AlertasTempranas.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlertasTempranas.Logica
{
    public class EstudianteNegocio : IEstudianteNegocio
    {
        private IList<Estudiante> estudiantes;
        public EstudianteNegocio()
        {
            estudiantes = new List<Estudiante>()
            {
                new Estudiante
                {
                    Id = "6502",
                    NombreCompleto = "Karen Yinela",
                    Programa = "Derecho",
                    Componentes = new List<ComponenteEstudiante>()
                },
                new Estudiante
                {
                    Id = "5204",
                    NombreCompleto = "Medina Javier",
                    Programa = "Derecho",
                    Componentes = new List<ComponenteEstudiante>()
                },
                new Estudiante
                {
                    Id = "5457",
                    NombreCompleto = "Chaparro Rafael",
                    Programa = "Derecho",
                    Componentes = new List<ComponenteEstudiante>()
                },
                new Estudiante
                {
                    Id = "5323",
                    NombreCompleto = "Merchan David",
                    Programa = "Arquitectura",
                    Componentes = new List<ComponenteEstudiante>()
                },
                new Estudiante
                {
                    Id = "60254",
                    NombreCompleto = "Omar Andres",
                    Programa = "Ingeniería Civil",
                    Componentes = new List<ComponenteEstudiante>()
                }
            };
        }

        public Estudiante GetEstudianteById(string idEstudiante)
        {
            var estudiante = estudiantes.FirstOrDefault(x => x.Id == idEstudiante);
            return estudiante;
        }
    }
}
