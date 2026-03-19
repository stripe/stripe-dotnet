// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertCreateOptions : BaseOptions
    {
        /// <summary>
        /// The type of alert to create.
        /// One of: <c>credit_balance_threshold</c>, <c>spend_threshold</c>, or
        /// <c>usage_threshold</c>.
        /// </summary>
        [JsonProperty("alert_type")]
        [STJS.JsonPropertyName("alert_type")]
        public string AlertType { get; set; }

        /// <summary>
        /// The configuration of the credit balance threshold.
        /// </summary>
        [JsonProperty("credit_balance_threshold")]
        [STJS.JsonPropertyName("credit_balance_threshold")]
        public AlertCreditBalanceThresholdOptions CreditBalanceThreshold { get; set; }

        /// <summary>
        /// The configuration of the spend threshold. An event fires when the amount consumed
        /// exceeds the threshold, after all credits and discounts are applied but before tax is
        /// applied.
        /// </summary>
        [JsonProperty("spend_threshold")]
        [STJS.JsonPropertyName("spend_threshold")]
        public AlertSpendThresholdOptions SpendThreshold { get; set; }

        /// <summary>
        /// The title of the alert.
        /// </summary>
        [JsonProperty("title")]
        [STJS.JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// The configuration of the usage threshold.
        /// </summary>
        [JsonProperty("usage_threshold")]
        [STJS.JsonPropertyName("usage_threshold")]
        public AlertUsageThresholdOptions UsageThreshold { get; set; }
    }
}
