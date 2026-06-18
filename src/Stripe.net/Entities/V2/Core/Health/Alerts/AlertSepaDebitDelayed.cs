// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AlertSepaDebitDelayed : StripeEntity<AlertSepaDebitDelayed>
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
