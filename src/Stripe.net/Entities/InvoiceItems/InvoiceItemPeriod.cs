namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceItemPeriod : StripeEntity<InvoiceItemPeriod>
    {
        /// <summary>
        /// End of the line item's billing period.
        /// </summary>
        [JsonProperty("end")]
        public long End { get; set; }

        /// <summary>
        /// Start of the line item's billing period.
        /// </summary>
        [JsonProperty("start")]
        public long Start { get; set; }
    }
}
