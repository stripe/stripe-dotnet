// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPaymentSettingsApplicationFeeData : StripeEntity<SessionPaymentSettingsApplicationFeeData>
    {
        /// <summary>
        /// The application fee amount, in the currency's smallest unit, applied to the initial
        /// payment.
        /// </summary>
        [JsonProperty("initial_amount")]
        [STJS.JsonPropertyName("initial_amount")]
        public long? InitialAmount { get; set; }

        /// <summary>
        /// The percentage of each payment collected as an application fee.
        /// </summary>
        [JsonProperty("percentage_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("percentage_decimal")]
        public decimal? PercentageDecimal { get; set; }
    }
}
