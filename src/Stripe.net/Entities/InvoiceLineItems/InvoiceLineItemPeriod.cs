namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceLineItemPeriod : StripeEntity<InvoiceLineItemPeriod>
    {
        [JsonProperty("end")]
        public long End { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }
    }
}
