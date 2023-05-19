using Business.DTO;
using Business.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controller
{
   
    [Route("api/visitors")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly VisitorService _visitorService;

        public VisitorController(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VisitorDto>> GetAllVisitors()
        {
            var visitors = _visitorService.GetAllVisitors();
            return Ok(visitors);
        }

        [HttpGet("{id}")]
        public ActionResult<VisitorDto> GetVisitorById(int id)
        {
            var visitor = _visitorService.GetVisitorById(id);
            if (visitor == null)
            {
                return NotFound();
            }
            return Ok(visitor);
        }

        [HttpPost]
        public ActionResult<VisitorDto> CreateVisitor(VisitorDto visitorDto)
        {
            var visitor = _visitorService.CreateVisitor(visitorDto);
            return CreatedAtAction(nameof(GetVisitorById), visitor);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVisitor(int id, VisitorDto visitorDto)
        {
            if (id != visitorDto.Id)
            {
                return BadRequest();
            }

            var visitor = _visitorService.GetVisitorById(id);
            if (visitor == null)
            {
                return NotFound();
            }

            _visitorService.UpdateVisitor(visitorDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVisitor(int id)
        {
            var visitor = _visitorService.GetVisitorById(id);
            if (visitor == null)
            {
                return NotFound();
            }

            _visitorService.DeleteVisitor(id);

            return NoContent();
        }
    }

}
