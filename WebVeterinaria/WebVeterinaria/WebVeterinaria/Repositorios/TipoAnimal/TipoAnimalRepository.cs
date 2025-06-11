using WebVeterinaria.Datos;

namespace WebVeterinaria.Repositorios.TipoAnimal
{
    public class TipoAnimalRepository
    {
        private readonly TodoContext _context;

        public TipoAnimalRepository(TodoContext context)
        {
            _context = context;
        }
        public Datos.Clase.TipoAnimal ObtenerTipoAnimal(int id)
        {
            return _context.TiposAnimals.FirstOrDefault(x => x.IdTipoAnimal == id);
        }
        public void Eliminar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal)
        {
            _context.TiposAnimals.Remove(tipoAnimal);
            _context.SaveChanges();
        }
        public void Agregar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal)
        {
            _context.TiposAnimals.Add(tipoAnimal);
            _context.SaveChanges();
        }
        public void Actualizar(WebVeterinaria.Datos.Clase.TipoAnimal tipoAnimal)
        {
            _context.TiposAnimals.Update(tipoAnimal);
            _context.SaveChanges();
        }
        public List<WebVeterinaria.Datos.Clase.TipoAnimal> ObtenerTipoAnimales()
        {
            return _context.TiposAnimals.ToList();
        }
    }
}
