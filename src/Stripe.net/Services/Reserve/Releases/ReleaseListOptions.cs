// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReleaseListOptions : ListOptions
    {
        /// <summary>
        /// Only return ReserveReleases associated with the currency specified by this currency
        /// code. Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Only return ReserveReleases associated with the ReserveHold specified by this
        /// ReserveHold ID.
        /// </summary>
        [JsonProperty("reserve_hold")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserve_hold")]
#endif
        public string ReserveHold { get; set; }

        /// <summary>
        /// Only return ReserveReleases associated with the ReservePlan specified by this
        /// ReservePlan ID.
        /// </summary>
        [JsonProperty("reserve_plan")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserve_plan")]
#endif
        public string ReservePlan { get; set; }
    }
}
