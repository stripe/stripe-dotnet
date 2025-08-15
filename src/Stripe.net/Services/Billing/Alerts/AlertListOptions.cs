// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AlertListOptions : ListOptions
    {
        /// <summary>
        /// Filter results to only include this type of alert.
        /// One of: <c>credit_balance_threshold</c>, or <c>usage_threshold</c>.
        /// </summary>
        [JsonProperty("alert_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alert_type")]
#endif
        public string AlertType { get; set; }

        /// <summary>
        /// Filter results to only include alerts for the given customer.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// Filter results to only include alerts with the given meter.
        /// </summary>
        [JsonProperty("meter")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("meter")]
#endif
        public string Meter { get; set; }
    }
}
