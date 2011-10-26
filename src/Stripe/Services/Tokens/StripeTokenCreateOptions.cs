namespace Stripe
{
    public class StripeTokenCreateOptions : CreditCardOptions
    {
        [StripeArgument("amount")]
        public int? AmountInCents { get; set; }

        [StripeArgument("currency")]
        public string Currency { get; set; }
    }
}