using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    public class OrderController : Controller
    {
        IEstimateshipping ShippingEstimator;

        public OrderController(IEstimateshipping shippingEstimator)
        {
            ShippingEstimator = shippingEstimator;
        }

        [HttpPost("/orders")]
        public IActionResult PlaceOrder([FromBody] Order order)
        {

            //Validate it 
            //save it to the db

            var response = new OrderResponse
            {
                For = order.For,
                Item = order.Item,
                Qty = order.Qty,
                ExpectedShipDate = DateTime.Now //RED FLAGS 
            };
            return Ok(response);
        }
    }
}
public class Order
{
    public string For { get; set; }
    public string Item { get; set; }
    public int Qty { get; set; }
}

public class OrderResponse
{
    public string For { get; set; }
    public string Item { get; set; }
    public int Qty { get; set; }
    public DateTime ExpectedShipDate { get; set; }
}
