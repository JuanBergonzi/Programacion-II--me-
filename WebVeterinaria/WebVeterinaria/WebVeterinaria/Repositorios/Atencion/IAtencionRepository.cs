namespace WebVeterinaria.Repositorios.Atencion
{
    public interface IAtencionRepository
    {
        List<WebVeterinaria.Datos.Clase.Atencion> ObtenerAtenciones();
        WebVeterinaria.Datos.Clase.Atencion ObtenerAtencion(int id);
        void Eliminar(WebVeterinaria.Datos.Clase.Atencion atencion);
        void Agregar(WebVeterinaria.Datos.Clase.Atencion atencion);
        void Actualizar(WebVeterinaria.Datos.Clase.Atencion atencion);
    }
}
