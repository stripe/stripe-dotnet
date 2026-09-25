// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionSchedulePauseSchedulePauseSettings : StripeEntity<QuotePreviewSubscriptionSchedulePauseSchedulePauseSettings>
    {
        [JsonProperty("bill_for")]
        [STJS.JsonPropertyName("bill_for")]
        public QuotePreviewSubscriptionSchedulePauseSchedulePauseSettingsBillFor BillFor { get; set; }

        /// <summary>
        /// Determines how to handle debits and credits when pausing.
        /// One of: <c>invoice</c>, or <c>pending_invoice_item</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("invoicing_behavior")]
        [STJS.JsonPropertyName("invoicing_behavior")]
        public string InvoicingBehavior { get; set; }

        /// <summary>
        /// The type of pause settings.
        /// One of: <c>subscription</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
