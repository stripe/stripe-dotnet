// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthSepaDebitDelayedFiringEventDataImpact : StripeEntity<V2CoreHealthSepaDebitDelayedFiringEventDataImpact>
    {
        /// <summary>
        /// The number of impacted payments.
        /// </summary>
        [JsonProperty("impacted_payments")]
        [STJS.JsonPropertyName("impacted_payments")]
        public long ImpactedPayments { get; set; }

        /// <summary>
        /// The percentage of impacted payments.
        /// </summary>
        [JsonProperty("impacted_payments_percentage")]
        [STJS.JsonPropertyName("impacted_payments_percentage")]
        public string ImpactedPaymentsPercentage { get; set; }
    }
}
