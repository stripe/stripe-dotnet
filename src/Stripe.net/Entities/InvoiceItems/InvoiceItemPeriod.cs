namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceItemPeriod : StripeEntity<InvoiceItemPeriod>
    {
        [JsonProperty("end")]
        public long End { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }
    }
}
