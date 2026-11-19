// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoiceCustomerBalance : StripeEntity<QuotePreviewInvoiceCustomerBalance>
    {
        /// <summary>
        /// The total amount of customer balance applied to this invoice (automatically + manually).
        /// </summary>
        [JsonProperty("applied_balance")]
        [STJS.JsonPropertyName("applied_balance")]
        public long AppliedBalance { get; set; }

        /// <summary>
        /// The amount of customer balance automatically applied during invoice finalization.
        /// </summary>
        [JsonProperty("automatically_applied_balance")]
        [STJS.JsonPropertyName("automatically_applied_balance")]
        public long AutomaticallyAppliedBalance { get; set; }

        /// <summary>
        /// The total amount of customer balance manually applied after finalization.
        /// </summary>
        [JsonProperty("manually_applied_balance")]
        [STJS.JsonPropertyName("manually_applied_balance")]
        public long ManuallyAppliedBalance { get; set; }
    }
}
