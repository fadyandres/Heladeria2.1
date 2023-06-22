using AutoMapper;
using HeladeriaAPI.Models.Dto;
using Heladeria2._1.Repositorios.IRepository;
using Microsoft.AspNetCore.Mvc;
using HeladeriaAPI.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Heladeria2._1.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingsController : ControllerBase
    {
        private readonly ILogger<ToppingsController> _logger;
        private readonly IToppings _toppingsrepo;
        private readonly IMapper _mapper;
    
        
        public ToppingsController(ILogger<ToppingsController> logger, IToppings toppingsrepo, IMapper mapper)
        {
            _logger = logger;
            _toppingsrepo = toppingsrepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ToppingsDto>>> GetToppings()
        {
            _logger.LogInformation("Obtener Toppings");

            var toppingsList = await _toppingsrepo.Getall();

            return Ok(_mapper.Map<IEnumerable<ToppingsDto>>(toppingsList));
        }


        [HttpGet("{id:int}", Name = "Gettoppings")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ToppingsDto>> Gettoppings(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Helado con ID {id}");
                return BadRequest();
            }
            var topping = await _toppingsrepo.Get(d => d.IdToppings == id);

            if (topping == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ToppingsDto>(topping));
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ToppingsDto>> AddToppings([FromBody] ToppingsCrearDto toppingsCrearDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _toppingsrepo.Get(s => s.Topping.ToLower() == toppingsCrearDto.Topping.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Topping con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (toppingsCrearDto == null)
            {
                return BadRequest(toppingsCrearDto);
            }

            Toppings modelo = _mapper.Map<Toppings>(toppingsCrearDto);

            await _toppingsrepo.Add(modelo);

            return CreatedAtRoute("Gettoppings", new { nombre = modelo.Topping }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteToppings(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var toppings = await _toppingsrepo.Get(s => s.IdToppings == id);

            if (toppings == null)
            {
                return NotFound();
            }

            _toppingsrepo.Remove(toppings);

            return NoContent();
        }
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateToppings(int id, [FromBody] ToppingsUpdateDto toppingsUpdateDto)
        {
            if (toppingsUpdateDto == null || id != toppingsUpdateDto.IdToppings)
            {
                return BadRequest();
            }

            Toppings modelo = _mapper.Map<Toppings>(toppingsUpdateDto);

            _toppingsrepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialToppings(int id, JsonPatchDocument<ToppingsUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var toppings = await _toppingsrepo.Get(s => s.IdToppings == id, tracked: false);

            ToppingsUpdateDto toppingsUpdateDto = _mapper.Map<ToppingsUpdateDto>(toppings);

            if (toppings == null) return BadRequest();

            patchDto.ApplyTo(toppingsUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Toppings modelo = _mapper.Map<Toppings>(toppingsUpdateDto);

            _toppingsrepo.Update(modelo);

            return NoContent();
        }

    }
    
}
