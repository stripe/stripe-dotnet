// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargePaymentDetailsLodgingDatumTotalExtraChargeOptions : INestedOptions
    {
        /// <summary>
        /// Amount of the extra charge in cents.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Type of extra charge.
        /// One of: <c>gift_shop</c>, <c>laundry</c>, <c>mini_bar</c>, <c>other</c>, <c>phone</c>,
        /// or <c>restaurant</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
