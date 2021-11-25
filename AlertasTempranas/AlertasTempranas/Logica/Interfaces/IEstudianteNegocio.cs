using AlertasTempranas.Modelos;

namespace AlertasTempranas.Logica.Interfaces
{
    public interface IEstudianteNegocio
    {
        Estudiante GetEstudianteById(string idEstudiante);
    }
}
