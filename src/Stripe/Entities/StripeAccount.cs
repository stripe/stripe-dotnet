namespace Stripe.Entities
{
    public class StripeAccount
    {
        public string Id { get; set; }
        public bool ChargeEnabled { get; set; }
        public string[] CurrenciesSupported { get; set; }
        public bool DetailsSubmitted { get; set; }
        public string Email { get; set; }
        public string StatementDescriptor { get; set; }
    }
}