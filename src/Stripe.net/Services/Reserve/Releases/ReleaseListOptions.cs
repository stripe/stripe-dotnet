// File generated from our OpenAPI spec
namespace Stripe.Reserve
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReleaseListOptions : ListOptions
    {
        /// <summary>
        /// Only return ReserveReleases associated with the currency specified by this currency
        /// code. Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be a <a
        /// href="https://stripe.com/docs/currencies">supported currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Only return ReserveReleases associated with the ReserveHold specified by this
        /// ReserveHold ID.
        /// </summary>
        [JsonProperty("reserve_hold")]
        [STJS.JsonPropertyName("reserve_hold")]
        public string ReserveHold { get; set; }

        /// <summary>
        /// Only return ReserveReleases associated with the ReservePlan specified by this
        /// ReservePlan ID.
        /// </summary>
        [JsonProperty("reserve_plan")]
        [STJS.JsonPropertyName("reserve_plan")]
        public string ReservePlan { get; set; }
    }
}
