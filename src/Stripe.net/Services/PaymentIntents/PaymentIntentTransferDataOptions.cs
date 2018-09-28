namespace Stripe
{
    using Stripe.Infrastructure;

    public class PaymentIntentTransferDataOptions : INestedOptions
    {
        [FormProperty("amount")]
        public int? Amount { get; set; }

        // This is only available on creation and not update
        [FormProperty("destination")]
        public string Destination { get; set; }
    }
}
