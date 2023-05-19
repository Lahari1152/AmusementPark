using Business.DTO;
using Business.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controller
{

    [Route("api/attractions")]
    [ApiController]
    public class AttractionController : ControllerBase
    {
        private readonly AttractionService _attractionService;

        public AttractionController(AttractionService attractionService)
        {
            _attractionService = attractionService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AttractionDto>> GetAllAttractions()
        {
            var attractions = _attractionService.GetAllAttractions();
            return Ok(attractions);
        }

        [HttpGet("{id}")]
        public ActionResult<AttractionDto> GetAttractionById(int id)
        {
            var attraction = _attractionService.GetAttractionById(id);
            if (attraction == null)
            {
                return NotFound();
            }
            return Ok(attraction);
        }

        [HttpPost]
        public ActionResult<AttractionDto> CreateAttraction(AttractionDto attractionDto)
        {
            var attraction = _attractionService.CreateAttraction(attractionDto);
            return CreatedAtAction(nameof(GetAttractionById), attraction);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAttraction(int id, AttractionDto attractionDto)
        {
            if (id != attractionDto.Id)
            {
                return BadRequest();
            }

            var attraction = _attractionService.GetAttractionById(id);
            if (attraction == null)
            {
                return NotFound();
            }

            _attractionService.UpdateAttraction(attractionDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAttraction(int id)
        {
            var attraction = _attractionService.GetAttractionById(id);
            if (attraction == null)
            {
                return NotFound();
            }

            _attractionService.DeleteAttraction(id);

            return NoContent();
        }
    }


}
