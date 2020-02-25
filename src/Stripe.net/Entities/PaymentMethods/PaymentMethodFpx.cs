namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodFpx : StripeEntity<PaymentMethodFpx>
    {
        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
