using WebVeterinaria.Datos.Dtos;

namespace WebVeterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly IAnimalLogic _animallogic;

        public AnimalController(IAnimalLogic logica)
        {
            _animallogic = logica;
        }

        // GET: api/Animal  
        [HttpGet]
        public ActionResult<IEnumerable<DtoAnimal>> GetAnimals()
        {
            return _animallogic.ObtenerAnimales();
        }

        // GET: api/Animal/5  
        [HttpGet("{id}")]
        public async Task<ActionResult<DTOAnimal>> GetAnimal(int id)
        {
            var animals = _animallogic.ObtenerAnimal(id);

            if (animals == null)
            {
                return NotFound();
            }

            return animals;
        }

        // PUT: api/Animal/5  
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimals(int id, DtoAnimal animal)
        {
            if (id != animals.Id)
            {
                return BadRequest();
            }

            _ianimallogic.ActualizarAnimal(animal);

            return NoContent();
        }

        // POST: api/Animal  
        [HttpPost]
        public async Task<ActionResult<DtoAnimal>> PostAnimals(DtoAnimal animal)
        {
            _animallogic.AgregarAnimal(animal);

            return CreatedAtAction("GetAnimals", new { id = animals.Id }, animal);
        }

        // DELETE: api/Animal/5  
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimals(int id)
        {
            _animallogic.EliminarAnimal(id);

            return NoContent();
        }
    }
}

