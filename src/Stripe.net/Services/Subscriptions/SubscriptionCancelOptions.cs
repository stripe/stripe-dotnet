// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionCancelOptions : BaseOptions
    {
        /// <summary>
        /// Details about why this subscription was cancelled.
        /// </summary>
        [JsonProperty("cancellation_details")]
        public SubscriptionCancellationDetailsOptions CancellationDetails { get; set; }

        /// <summary>
        /// Will generate a final invoice that invoices for any un-invoiced metered usage and
        /// new/pending proration invoice items.
        /// </summary>
        [JsonProperty("invoice_now")]
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// Will generate a proration invoice item that credits remaining unused time until the
        /// subscription period end.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}
