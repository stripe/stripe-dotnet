// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuoteLineCancelSubscriptionScheduleOptions : INestedOptions
    {
        /// <summary>
        /// Timestamp helper to cancel the underlying schedule on the accompanying line's start
        /// date. Must be set to <c>line_starts_at</c>.
        /// </summary>
        [JsonProperty("cancel_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cancel_at")]
#endif
        public string CancelAt { get; set; }

        /// <summary>
        /// If the subscription schedule is <c>active</c>, indicates if a final invoice will be
        /// generated that contains any un-invoiced metered usage and new/pending proration invoice
        /// items. Boolean that defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("invoice_now")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice_now")]
#endif
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// If the subscription schedule is <c>active</c>, indicates if the cancellation should be
        /// prorated. Boolean that defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("prorate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prorate")]
#endif
        public bool? Prorate { get; set; }
    }
}
