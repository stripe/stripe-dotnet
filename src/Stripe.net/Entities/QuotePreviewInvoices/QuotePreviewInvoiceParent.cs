// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class QuotePreviewInvoiceParent : StripeEntity<QuotePreviewInvoiceParent>
    {
        /// <summary>
        /// Details about the billing cadence that generated this invoice.
        /// </summary>
        [JsonProperty("billing_cadence_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_cadence_details")]
#endif
        public QuotePreviewInvoiceParentBillingCadenceDetails BillingCadenceDetails { get; set; }

        /// <summary>
        /// Details about the quote that generated this invoice.
        /// </summary>
        [JsonProperty("quote_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("quote_details")]
#endif
        public QuotePreviewInvoiceParentQuoteDetails QuoteDetails { get; set; }

        /// <summary>
        /// Details about the subscription that generated this invoice.
        /// </summary>
        [JsonProperty("subscription_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription_details")]
#endif
        public QuotePreviewInvoiceParentSubscriptionDetails SubscriptionDetails { get; set; }

        /// <summary>
        /// The type of parent that generated this invoice.
        /// One of: <c>billing_cadence_details</c>, <c>quote_details</c>, <c>schedule_details</c>,
        /// or <c>subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Details about the schedule that generated this invoice.
        /// </summary>
        [JsonProperty("schedule_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("schedule_details")]
#endif
        public QuotePreviewInvoiceParentScheduleDetails ScheduleDetails { get; set; }
    }
}
