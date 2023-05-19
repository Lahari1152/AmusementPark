using Business.DTO;
using Business.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ServiceLayer.Controller
{
    
 
    [Route("api/purchases")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly PurchaseService _purchaseService;

        public PurchaseController(PurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PurchaseDto>> GetAllPurchases()
        {
            var purchases = _purchaseService.GetAllPurchases();
            return Ok(purchases);
        }

        [HttpGet("{id}")]
        public ActionResult<PurchaseDto> GetPurchaseById(int id)
        {
            var purchase = _purchaseService.GetPurchaseById(id);
            if (purchase == null)
            {
                return NotFound();
            }
            return Ok(purchase);
        }

        [HttpPost]
        public ActionResult<PurchaseDto> CreatePurchase(PurchaseDto purchaseDto)
        {
            var purchase = _purchaseService.CreatePurchase(purchaseDto);
            return CreatedAtAction(nameof(GetPurchaseById), purchase);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePurchase(int id, PurchaseDto purchaseDto)
        {
            if (id != purchaseDto.Id)
            {
                return BadRequest();
            }

            var purchase = _purchaseService.GetPurchaseById(id);
            if (purchase == null)
            {
                return NotFound();
            }

            _purchaseService.UpdatePurchase(purchaseDto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePurchase(int id)
        {
            var purchase = _purchaseService.GetPurchaseById(id);
            if (purchase == null)
            {
                return NotFound();
            }

            _purchaseService.DeletePurchase(id);

            return NoContent();
        }
    }

}
