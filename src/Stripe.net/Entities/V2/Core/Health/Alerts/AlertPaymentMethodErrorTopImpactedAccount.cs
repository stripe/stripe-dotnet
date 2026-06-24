// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertPaymentMethodErrorTopImpactedAccount : StripeEntity<AlertPaymentMethodErrorTopImpactedAccount>
    {
        /// <summary>
        /// The account ID of the impacted connected account.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The number of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests")]
        [STJS.JsonPropertyName("impacted_requests")]
        public long ImpactedRequests { get; set; }

        /// <summary>
        /// The percentage of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests_percentage")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("impacted_requests_percentage")]
        public decimal? ImpactedRequestsPercentage { get; set; }
    }
}
