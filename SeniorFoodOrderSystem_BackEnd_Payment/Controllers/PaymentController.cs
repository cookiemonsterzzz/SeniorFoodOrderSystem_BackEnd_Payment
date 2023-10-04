using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult> UpsertPayment(Guid orderId)
        {
            var order = _context.Orders.FirstOrDefault(x => x.Id == orderId);

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
                    PaymentStatus = "Pending",
                    DateTimeCreated = DateTimeOffset.UtcNow,
                    DateTimeUpdated = DateTimeOffset.UtcNow,
                    Order = order
                };

                _context.Payments.Add(payment);
                await _context.SaveChangesAsync();

                return Ok(payment);
            }
        }
    }
}

