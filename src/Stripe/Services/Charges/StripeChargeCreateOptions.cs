namespace Stripe
{
    public class StripeChargeCreateOptions : CreditCardOptions
    {
        [StripeArgument("amount")]
        public int? AmountInCents { get; set; }

        [StripeArgument("currency")]
        public string Currency { get; set; }

        [StripeArgument("description")]
        public string Description { get; set; }

        [StripeArgument("customer")]
        public string CustomerId { get; set; }
    }
}