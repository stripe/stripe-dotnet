// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionSchedulePauseSchedulePauseSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Controls what to bill for when pausing the subscription.
        /// </summary>
        [JsonProperty("bill_for")]
        [STJS.JsonPropertyName("bill_for")]
        public SubscriptionSchedulePauseSchedulePauseSettingsBillForOptions BillFor { get; set; }

        /// <summary>
        /// Determines whether to generate an invoice for outstanding amounts when pausing.
        /// One of: <c>invoice</c>, or <c>pending_invoice_item</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("invoicing_behavior")]
        [STJS.JsonPropertyName("invoicing_behavior")]
        public string InvoicingBehavior { get; set; }

        /// <summary>
        /// The pause type. Currently only <c>subscription</c> is supported.
        /// One of: <c>subscription</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
