namespace Stripe
{
    using Newtonsoft.Json;

    public class MandatePaymentMethodDetailsAuBecsDebit : StripeEntity<MandatePaymentMethodDetailsAuBecsDebit>
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
