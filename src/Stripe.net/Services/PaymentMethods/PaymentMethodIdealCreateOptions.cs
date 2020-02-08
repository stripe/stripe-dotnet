namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodIdealCreateOptions : INestedOptions
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
