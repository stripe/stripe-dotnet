// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthPaymentMethodErrorResolvedEventDataImpactTopImpactedAccount : StripeEntity<V2CoreHealthPaymentMethodErrorResolvedEventDataImpactTopImpactedAccount>
    {
        /// <summary>
        /// The account ID of the impacted connected account.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The number of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_requests")]
#endif
        public long ImpactedRequests { get; set; }

        /// <summary>
        /// The percentage of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests_percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_requests_percentage")]
#endif
        public string ImpactedRequestsPercentage { get; set; }
    }
}
