namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataIdealOptions : INestedOptions
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
