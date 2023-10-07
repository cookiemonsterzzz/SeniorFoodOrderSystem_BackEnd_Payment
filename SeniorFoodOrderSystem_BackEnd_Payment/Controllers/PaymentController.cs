using Microsoft.AspNetCore.Mvc;
using SeniorFoodOrderSystem_BackEnd_Payment.Dto;

namespace SeniorFoodOrderSystem_BackEnd_Payment.Controllers
{
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        private SeniorFoodOrderSystemDatabaseContext _context;

        public PaymentController(SeniorFoodOrderSystemDatabaseContext context)
        {
            _context = context;
        }

        [HttpPost("upsertPayment")]
        public async Task<ActionResult> UpsertPayment([FromBody] PaymentDto paymentDto)
        {
            var order = _context.Orders.FirstOrDefault(x => x.Id == paymentDto.orderId);

            if (order is null)
            {
                return NotFound();
            }
            else
            {
                var payment = new Payment
                {
                    Id = Guid.NewGuid(),
                    OrderId = order.Id,
                    Amount = order.Amount,
                    PaymentMode = paymentDto.paymentMode,
                    PaymentStatus = "Paid",
                    DateTimeCreated = DateTimeOffset.UtcNow,
                    DateTimeUpdated = DateTimeOffset.UtcNow,
                };

                _context.Payments.Add(payment);

                order.OrderStatus = "Paid";

                await _context.SaveChangesAsync();

                return Ok(payment);
            }
        }
    }
}

