// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertListOptions : ListOptions
    {
        /// <summary>
        /// Filter results to only include this type of alert.
        /// One of: <c>credit_balance_threshold</c>, <c>spend_threshold</c>, or
        /// <c>usage_threshold</c>.
        /// </summary>
        [JsonProperty("alert_type")]
        [STJS.JsonPropertyName("alert_type")]
        public string AlertType { get; set; }

        /// <summary>
        /// Filter results to only include alerts for the given customer.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Filter results to only include alerts with the given meter.
        /// </summary>
        [JsonProperty("meter")]
        [STJS.JsonPropertyName("meter")]
        public string Meter { get; set; }
    }
}
