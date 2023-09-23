using FoodPaymentAPI.Model;

namespace FoodPaymentAPI.Services
{
    public interface IPaymentService
    {
        Payment MakePayment(Guid orderid, decimal amount);

        Payment GetPayment (Guid orderid);


    }
}
