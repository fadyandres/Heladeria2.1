using AutoMapper;
using Heladeria2._1.Repositorios.IRepository;
using HeladeriaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using HeladeriaAPI.Models;

namespace Heladeria2._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeladoController : ControllerBase
    {
        private readonly ILogger<HeladoController> _logger;
        private readonly IHelados _heladorepo;
        private readonly IMapper _mapper;
    
        public HeladoController(ILogger<HeladoController> logger, IHelados heladorepo, IMapper mapper)
        {
            _logger = logger;
            _heladorepo=heladorepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<HeladoDto>>> GetHelados()
        {
            _logger.LogInformation("Obtener los Helados");

            var heladoList = await _heladorepo.Getall();

            return Ok(_mapper.Map<IEnumerable<HeladoDto>>(heladoList));
        }

        [HttpGet("{id:int}", Name = "GetHelado")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<HeladoDto>> GetHelado(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Helado con id {id}");
                return BadRequest();
            }
            var helado = await _heladorepo.Get(s => s.IdHelado == id);

            if (helado == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<HeladoDto>(helado));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<HeladoDto>> AddHelado([FromBody] HeladoCrearDto heladoCrearDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _heladorepo.Get(s => s.NombreHelado.ToLower() == heladoCrearDto.NombreHelado.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Helado con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (heladoCrearDto == null)
            {
                return BadRequest(heladoCrearDto);
            }

            Helado modelo = _mapper.Map<Helado>(heladoCrearDto);

            await _heladorepo.Add(modelo);

            return CreatedAtRoute("Gethelado", new { nombre = modelo.NombreHelado }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteHelado(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var helado = await _heladorepo.Get(s => s.IdHelado == id);

            if (helado == null)
            {
                return NotFound();
            }

            _heladorepo.Remove(helado);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateHelado(int id, [FromBody] HeladoUpdateDto heladoUpdateDto)
        {
            if (heladoUpdateDto == null || id != heladoUpdateDto.IdHelado)
            {
                return BadRequest();
            }

            Helado modelo = _mapper.Map<Helado>(heladoUpdateDto);

            _heladorepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialHelado(int id, JsonPatchDocument<HeladoUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var helado = await _heladorepo.Get(s => s.IdHelado == id, tracked: false);

            HeladoUpdateDto heladoUpdateDto = _mapper.Map<HeladoUpdateDto>(helado);

            if (helado == null) return BadRequest();

            patchDto.ApplyTo(heladoUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Helado modelo = _mapper.Map<Helado>(heladoUpdateDto);

            _heladorepo.Update(modelo);

            return NoContent();
        }

    }

}
