// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthSepaDebitDelayedResolvedEventDataImpact : StripeEntity<V2CoreHealthSepaDebitDelayedResolvedEventDataImpact>
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
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("impacted_payments_percentage")]
        public decimal ImpactedPaymentsPercentage { get; set; }
    }
}
