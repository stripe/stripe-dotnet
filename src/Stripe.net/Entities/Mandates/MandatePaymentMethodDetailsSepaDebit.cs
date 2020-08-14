namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsSepaDebit : StripeEntity<MandatePaymentMethodDetailsSepaDebit>
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
