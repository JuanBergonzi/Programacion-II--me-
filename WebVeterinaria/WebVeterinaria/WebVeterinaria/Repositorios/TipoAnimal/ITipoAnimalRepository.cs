namespace WebVeterinaria.Repositorios.TipoAnimal
{
    public interface ITipoAnimalRepository
    {
        List<WebVeterinaria.Datos.Clase.TipoAnimal> ObtenerTipoAnimales();
        WebVeterinaria.Datos.Clase.TipoAnimal ObtenerTipoAnimal(int id);
        void Eliminar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal);
        void Agregar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal);
        void Actualizar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal);
    }
}
