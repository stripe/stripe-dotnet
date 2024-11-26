// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionCancelOptions : BaseOptions
    {
        /// <summary>
        /// Details about why this subscription was cancelled.
        /// </summary>
        [JsonProperty("cancellation_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancellation_details")]
#endif
        public SubscriptionCancellationDetailsOptions CancellationDetails { get; set; }

        /// <summary>
        /// Will generate a final invoice that invoices for any un-invoiced metered usage and
        /// new/pending proration invoice items. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("invoice_now")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_now")]
#endif
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// Will generate a proration invoice item that credits remaining unused time until the
        /// subscription period end. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("prorate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prorate")]
#endif
        public bool? Prorate { get; set; }
    }
}
