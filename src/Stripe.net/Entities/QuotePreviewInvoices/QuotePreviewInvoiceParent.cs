// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoiceParent : StripeEntity<QuotePreviewInvoiceParent>
    {
        /// <summary>
        /// Details about the billing cadence that generated this invoice.
        /// </summary>
        [JsonProperty("billing_cadence_details")]
        [STJS.JsonPropertyName("billing_cadence_details")]
        public QuotePreviewInvoiceParentBillingCadenceDetails BillingCadenceDetails { get; set; }

        /// <summary>
        /// Details about the quote that generated this invoice.
        /// </summary>
        [JsonProperty("quote_details")]
        [STJS.JsonPropertyName("quote_details")]
        public QuotePreviewInvoiceParentQuoteDetails QuoteDetails { get; set; }

        /// <summary>
        /// Details about the schedule that generated this invoice.
        /// </summary>
        [JsonProperty("schedule_details")]
        [STJS.JsonPropertyName("schedule_details")]
        public QuotePreviewInvoiceParentScheduleDetails ScheduleDetails { get; set; }

        /// <summary>
        /// Details about the subscription that generated this invoice.
        /// </summary>
        [JsonProperty("subscription_details")]
        [STJS.JsonPropertyName("subscription_details")]
        public QuotePreviewInvoiceParentSubscriptionDetails SubscriptionDetails { get; set; }

        /// <summary>
        /// The type of parent that generated this invoice.
        /// One of: <c>billing_cadence_details</c>, <c>quote_details</c>, <c>schedule_details</c>,
        /// or <c>subscription_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
