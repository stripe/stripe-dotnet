// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class HoldListOptions : ListOptions
    {
        /// <summary>
        /// Only return ReserveHolds associated with the currency specified by this currency code.
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Only return ReserveHolds that are releasable.
        /// </summary>
        [JsonProperty("is_releasable")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_releasable")]
#endif
        public bool? IsReleasable { get; set; }

        /// <summary>
        /// One of: <c>charge</c>, or <c>standalone</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        /// <summary>
        /// Only return ReserveHolds associated with the ReservePlan specified by this ReservePlan
        /// ID.
        /// </summary>
        [JsonProperty("reserve_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserve_plan")]
#endif
        public string ReservePlan { get; set; }

        /// <summary>
        /// Only return ReserveHolds associated with the ReserveRelease specified by this
        /// ReserveRelease ID.
        /// </summary>
        [JsonProperty("reserve_release")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserve_release")]
#endif
        public string ReserveRelease { get; set; }

        /// <summary>
        /// Only return ReserveHolds associated with the Charge specified by this source charge ID.
        /// </summary>
        [JsonProperty("source_charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_charge")]
#endif
        public string SourceCharge { get; set; }
    }
}
