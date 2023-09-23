using FoodPaymentAPI.Data;
using FoodPaymentAPI.Model;

namespace FoodPaymentAPI.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ArchitectContext _context;
        public PaymentService(ArchitectContext context) 
        { 
            _context = context;
        }

        Payment IPaymentService.GetPayment(Guid orderid)
        {
            throw new NotImplementedException();
        }

        Payment IPaymentService.MakePayment(Guid orderid, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
