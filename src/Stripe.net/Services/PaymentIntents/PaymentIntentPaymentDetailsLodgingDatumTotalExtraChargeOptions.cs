// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsLodgingDatumTotalExtraChargeOptions : INestedOptions
    {
        /// <summary>
        /// Amount of the extra charge in cents.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Type of extra charge.
        /// One of: <c>gift_shop</c>, <c>laundry</c>, <c>mini_bar</c>, <c>other</c>, <c>phone</c>,
        /// or <c>restaurant</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
