// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertCreateOptions : BaseOptions
    {
        /// <summary>
        /// The type of alert to create.
        /// One of: <c>credit_balance_threshold</c>, <c>spend_threshold</c>, or
        /// <c>usage_threshold</c>.
        /// </summary>
        [JsonProperty("alert_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alert_type")]
#endif
        public string AlertType { get; set; }

        /// <summary>
        /// The configuration of the credit balance threshold.
        /// </summary>
        [JsonProperty("credit_balance_threshold")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_balance_threshold")]
#endif
        public AlertCreditBalanceThresholdOptions CreditBalanceThreshold { get; set; }

        /// <summary>
        /// The configuration of the spend threshold.
        /// </summary>
        [JsonProperty("spend_threshold")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_threshold")]
#endif
        public AlertSpendThresholdOptions SpendThreshold { get; set; }

        /// <summary>
        /// The title of the alert.
        /// </summary>
        [JsonProperty("title")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("title")]
#endif
        public string Title { get; set; }

        /// <summary>
        /// The configuration of the usage threshold.
        /// </summary>
        [JsonProperty("usage_threshold")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_threshold")]
#endif
        public AlertUsageThresholdOptions UsageThreshold { get; set; }
    }
}
