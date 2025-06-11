using WebVeterinaria.Datos.Dtos;

namespace WebVeterinaria.Logica.TipoAnimal
{
    public interface ITipoAnimalLogic
    {
        List<DtoTipoAnimal> ObtenerTipoAnimales();

        DtoTipoAnimal ObtenerTipoAnimal(int id);
        bool EliminarTipoAnimal(int id);
        bool AgregarTipoAnimal(DtoTipoAnimal nuevoTipoAnimal);
        bool ActualizarTipoAnimal(int id, DtoTipoAnimal tipoAnimalDtos);
    }
}
