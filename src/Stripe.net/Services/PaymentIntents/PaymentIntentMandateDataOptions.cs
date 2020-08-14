namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentMandateDataOptions : INestedOptions
    {
        [JsonProperty("customer_acceptance")]
        public PaymentIntentMandateDataCustomerAcceptanceOptions CustomerAcceptance { get; set; }
    }
}
