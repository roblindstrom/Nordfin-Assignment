using Nordfin_AssignmentShared.RequestModels;
using Nordfin_AssignmentShared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentServices.Services.DeliveryServices
{
    public interface IDeliveryService
    {
        IOrderedEnumerable<DeliveryResponse> GetAvailableDeliveryDates(int postalCode, List<ProductRequest> productRequests);
    }
}
