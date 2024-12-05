// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteLineCancelSubscriptionScheduleOptions : INestedOptions
    {
        /// <summary>
        /// Timestamp helper to cancel the underlying schedule on the accompanying line's start
        /// date. Must be set to <c>line_starts_at</c>.
        /// </summary>
        [JsonProperty("cancel_at")]
        public string CancelAt { get; set; }

        /// <summary>
        /// If the subscription schedule is <c>active</c>, indicates if a final invoice will be
        /// generated that contains any un-invoiced metered usage and new/pending proration invoice
        /// items. Boolean that defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("invoice_now")]
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// If the subscription schedule is <c>active</c>, indicates if the cancellation should be
        /// prorated. Boolean that defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("prorate")]
        public bool? Prorate { get; set; }
    }
}
