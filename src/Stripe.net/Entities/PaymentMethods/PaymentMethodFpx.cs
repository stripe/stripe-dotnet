namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodFpx : StripeEntity
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
