// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePauseSchedulePauseSettings : StripeEntity<SubscriptionSchedulePauseSchedulePauseSettings>
    {
        [JsonProperty("bill_for")]
        [STJS.JsonPropertyName("bill_for")]
        public SubscriptionSchedulePauseSchedulePauseSettingsBillFor BillFor { get; set; }

        /// <summary>
        /// Determines how to handle debits and credits when pausing.
        /// One of: <c>invoice</c>, or <c>pending_invoice_item</c>.
        /// </summary>
        [JsonProperty("invoicing_behavior")]
        [STJS.JsonPropertyName("invoicing_behavior")]
        public string InvoicingBehavior { get; set; }

        /// <summary>
        /// The type of pause settings.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
