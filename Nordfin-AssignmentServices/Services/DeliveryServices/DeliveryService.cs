
using Nordfin_AssignmentShared.Models;
using Nordfin_AssignmentShared.RequestModels;
using Nordfin_AssignmentShared.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordfin_AssignmentServices.Services.DeliveryServices
{
    public class DeliveryService : IDeliveryService
    {
        
        public IOrderedEnumerable<DeliveryResponse> GetAvailableDeliveryDates(int postalCode, List<ProductRequest> productRequests)
        {
            var deliveryResponses = new List<DeliveryResponse>();
            var listOfDeliveryDays = new List<DayOfWeek>();
            var dateTracker = DateTime.Now;


            //adds all available days to list
            foreach (var product in productRequests)
            {
                listOfDeliveryDays.AddRange(product.DeliveryDays);
            }
            //Removes duplicate days
            listOfDeliveryDays = listOfDeliveryDays.Distinct().ToList();

            //Gets first avaiable date by adding DaysinAdvanced to today date
            dateTracker = DateTime.Now.AddDays(productRequests.Max(products => products.DaysInAdvance));

            if (productRequests.Any(product => product.ProductType == ProductType.External) && productRequests.Max(products => products.DaysInAdvance) < 5)
            {
                //If any product is external and Days in advance is less then 5, set to datetracker to +5 days
                dateTracker = DateTime.Now.AddDays(5);
            }

            //Gets first 5 avaiable dates
            for (int i = 0; deliveryResponses.Count <= 4; i++)
            {
                    
                    if(listOfDeliveryDays.Contains(dateTracker.DayOfWeek))
                    {
                    //Adds correct day to list of deliveryResponses 
                    deliveryResponses.Add(new DeliveryResponse { PostalCode = postalCode, DeliveryDate = dateTracker });
                    }
                    //Adds another day
                    dateTracker = dateTracker.AddDays(1);
                    
            }
            //If any products are temporary
            if (productRequests.Any(product => product.ProductType == ProductType.Temporary))
            {
                //Loop until it finds first sunday
                var FindSunday = DateTime.Now;
                while (FindSunday.DayOfWeek != DayOfWeek.Sunday)
                {
                    FindSunday = FindSunday.AddDays(1);
                }

                //Removes all dates that are next week since temporary products needs to be delivered same week
                var deliveriesToBeRemoved = deliveryResponses.Where(delivery => delivery.DeliveryDate > FindSunday).ToList();
                deliveryResponses = deliveryResponses.Except(deliveriesToBeRemoved).ToList();

            }
            //Returns ordered list
            return deliveryResponses.OrderBy(x => x.DeliveryDate);

        }


    }
}
