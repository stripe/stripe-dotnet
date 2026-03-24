// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class HoldListOptions : ListOptions
    {
        /// <summary>
        /// Only return ReserveHolds associated with the currency specified by this currency code.
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Only return ReserveHolds that are releasable.
        /// </summary>
        [JsonProperty("is_releasable")]
        [STJS.JsonPropertyName("is_releasable")]
        public bool? IsReleasable { get; set; }

        /// <summary>
        /// One of: <c>charge</c>, or <c>standalone</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Only return ReserveHolds associated with the ReservePlan specified by this ReservePlan
        /// ID.
        /// </summary>
        [JsonProperty("reserve_plan")]
        [STJS.JsonPropertyName("reserve_plan")]
        public string ReservePlan { get; set; }

        /// <summary>
        /// Only return ReserveHolds associated with the ReserveRelease specified by this
        /// ReserveRelease ID.
        /// </summary>
        [JsonProperty("reserve_release")]
        [STJS.JsonPropertyName("reserve_release")]
        public string ReserveRelease { get; set; }

        /// <summary>
        /// Only return ReserveHolds associated with the Charge specified by this source charge ID.
        /// </summary>
        [JsonProperty("source_charge")]
        [STJS.JsonPropertyName("source_charge")]
        public string SourceCharge { get; set; }
    }
}
