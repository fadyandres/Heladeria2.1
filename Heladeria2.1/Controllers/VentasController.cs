using AutoMapper;
using Heladeria2._1.Repositorios.IRepository;
using HeladeriaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using HeladeriaAPI.Models;

namespace Heladeria2._1.Controllers
{
    public class VentasController : ControllerBase
    {
        private readonly ILogger<VentasController> _logger;
        private readonly IVentas _ventasrepo;
        private readonly IMapper _mapper;

        public VentasController(ILogger<VentasController> logger, IVentas ventasrepo, IMapper mapper)
        {
            _logger = logger;
            _ventasrepo = ventasrepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VentasDto>>> GetVentas()
        {
            _logger.LogInformation("Obtener las Ventas");

            var ventasList = await _ventasrepo.Getall();

            return Ok(_mapper.Map<IEnumerable<VentasDto>>(ventasList));
        }

        [HttpGet("{id:int}", Name = "GetVentas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VentasDto>> GetVentas(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Ventas con Id {id}");
                return BadRequest();
            }
            var ventas = await _ventasrepo.Get(s => s.idVentas == id);

            if (ventas == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<VentasDto>(ventas));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<VentasDto>> AddVentas([FromBody] VentasCrearDto ventasCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _ventasrepo.Get(s => s.idVentas == ventasCreateDto.IdVentas) != null)
            {
                ModelState.AddModelError("IDExiste", "¡La Venta con ese ID ya existe!");
                return BadRequest(ModelState);
            }

            if (ventasCreateDto == null)
            {
                return BadRequest(ventasCreateDto);
            }

            Ventas modelo = _mapper.Map<Ventas>(ventasCreateDto);

            await _ventasrepo.Add(modelo);

            return CreatedAtRoute("GetVentas", new { id = modelo.idVentas }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteVentas(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var ventas = await _ventasrepo.Get(s => s.idVentas == id);

            if (ventas == null)
            {
                return NotFound();
            }

            _ventasrepo.Remove(ventas);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVentas(int id, [FromBody] VentasUpdateDto ventasUpdateDto)
        {
            if (ventasUpdateDto == null || id != ventasUpdateDto.IdVentas)
            {
                return BadRequest();
            }

            Ventas modelo = _mapper.Map<Ventas>(ventasUpdateDto);

            _ventasrepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialVentas(int id, JsonPatchDocument<VentasUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var ventas = await _ventasrepo.Get(s => s.idVentas == id, tracked: false);

            VentasUpdateDto ventasUpdateDto = _mapper.Map<VentasUpdateDto>(ventas);

            if (ventas == null) return BadRequest();

            patchDto.ApplyTo(ventasUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Ventas modelo = _mapper.Map<Ventas>(ventasUpdateDto);

            _ventasrepo.Update(modelo);

            return NoContent();
        }


    }
}
