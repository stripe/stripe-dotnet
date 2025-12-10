// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthSepaDebitDelayedResolvedEventDataImpact : StripeEntity<V2CoreHealthSepaDebitDelayedResolvedEventDataImpact>
    {
        /// <summary>
        /// The number of impacted payments.
        /// </summary>
        [JsonProperty("impacted_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_payments")]
#endif
        public long ImpactedPayments { get; set; }

        /// <summary>
        /// The percentage of impacted payments.
        /// </summary>
        [JsonProperty("impacted_payments_percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_payments_percentage")]
#endif
        public string ImpactedPaymentsPercentage { get; set; }
    }
}
