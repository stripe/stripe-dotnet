// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionCancelOptions : BaseOptions
    {
        /// <summary>
        /// Details about why this subscription was cancelled.
        /// </summary>
        [JsonProperty("cancellation_details")]
        [STJS.JsonPropertyName("cancellation_details")]
        public SubscriptionCancellationDetailsOptions CancellationDetails { get; set; }

        /// <summary>
        /// Will generate a final invoice that invoices for any un-invoiced metered usage and
        /// new/pending proration invoice items. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("invoice_now")]
        [STJS.JsonPropertyName("invoice_now")]
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// Will generate a proration invoice item that credits remaining unused time until the
        /// subscription period end. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("prorate")]
        [STJS.JsonPropertyName("prorate")]
        public bool? Prorate { get; set; }
    }
}
