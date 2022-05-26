// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceLineItemPeriod : StripeEntity<InvoiceLineItemPeriod>
    {
        /// <summary>
        /// The end of the period, which must be greater than or equal to the start.
        /// </summary>
        [JsonProperty("end")]
        public long End { get; set; }

        /// <summary>
        /// The start of the period.
        /// </summary>
        [JsonProperty("start")]
        public long Start { get; set; }
    }
}
