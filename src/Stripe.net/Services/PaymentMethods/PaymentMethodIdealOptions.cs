namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodIdealOptions : INestedOptions
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
