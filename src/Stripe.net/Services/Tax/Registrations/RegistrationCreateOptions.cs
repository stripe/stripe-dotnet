// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class RegistrationCreateOptions : BaseOptions
    {
        /// <summary>
        /// Time at which the Tax Registration becomes active. Measured in seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("active_from")]
        public long? ActiveFrom { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// If set, the Tax Registration stops being active at this time. If not set, the Tax
        /// Registration will be active indefinitely. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// State, county, province, or region.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The type of the Tax Registration. See <a
        /// href="https://stripe.com/docs/tax/registering">our guide</a> for more information about
        /// registration types.
        /// One of: <c>domestic_small_seller</c>, <c>simplified</c>, <c>standard</c>,
        /// <c>vat_oss_non_union</c>, or <c>vat_oss_union</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
