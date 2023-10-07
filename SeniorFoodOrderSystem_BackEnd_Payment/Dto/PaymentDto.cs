namespace SeniorFoodOrderSystem_BackEnd_Payment.Dto
{
    public class PaymentDto
    {
        public Guid orderId { get; set; }

        public string paymentMode { get; set; } = string.Empty;
    }
}
