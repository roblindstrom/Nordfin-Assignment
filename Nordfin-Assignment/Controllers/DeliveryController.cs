using Microsoft.AspNetCore.Mvc;
using Nordfin_AssignmentServices.Services.DeliveryServices;
using Nordfin_AssignmentShared.RequestModels;
using Nordfin_AssignmentShared.ResponseModels;

namespace Nordfin_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : Controller
    {
        private readonly IDeliveryService _deliveryService;
        public DeliveryController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService ?? throw new ArgumentException(nameof(deliveryService));
        }

        [HttpPost]
        public ActionResult<IOrderedEnumerable<DeliveryResponse>> GetFiveAvailableDeliveryDates([FromBody] List<ProductRequest> productRequests, int postalCode)
        {
           var deliveryResponses = _deliveryService.GetAvailableDeliveryDates(postalCode, productRequests);
            if (deliveryResponses != null)
            {
                return Ok(deliveryResponses);
            }
            else
            {
                return BadRequest(deliveryResponses);
            }
        }

    }
}
