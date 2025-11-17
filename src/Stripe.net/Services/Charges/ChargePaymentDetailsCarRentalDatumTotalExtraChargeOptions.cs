// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsCarRentalDatumTotalExtraChargeOptions : INestedOptions
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
        /// One of: <c>extra_mileage</c>, <c>gas</c>, <c>gps</c>, <c>late_charge</c>,
        /// <c>one_way_drop_off</c>, <c>other</c>, <c>parking</c>, <c>phone</c>,
        /// <c>regular_mileage</c>, or <c>towing</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
