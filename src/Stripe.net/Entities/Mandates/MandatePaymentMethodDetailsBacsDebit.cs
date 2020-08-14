namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsBacsDebit : StripeEntity<MandatePaymentMethodDetailsBacsDebit>
    {
        [JsonProperty("network_status")]
        public string NetworkStatus { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
