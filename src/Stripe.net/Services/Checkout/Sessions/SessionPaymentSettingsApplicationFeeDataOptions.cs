// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPaymentSettingsApplicationFeeDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount of the application fee, in the currency's smallest unit, to apply to the
        /// initial payment and transfer to the application owner's Stripe account. The application
        /// fee is capped at the total amount captured.
        /// </summary>
        [JsonProperty("initial_amount")]
        [STJS.JsonPropertyName("initial_amount")]
        public long? InitialAmount { get; set; }

        /// <summary>
        /// A non-negative decimal between 0 and 100, with at most two decimal places. This
        /// represents the percentage of each payment total that will be transferred to the
        /// application owner's Stripe account.
        /// </summary>
        [JsonProperty("percentage_decimal")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("percentage_decimal")]
        public decimal? PercentageDecimal { get; set; }
    }
}
