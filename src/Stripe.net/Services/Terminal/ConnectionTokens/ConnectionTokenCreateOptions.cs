// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConnectionTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// The id of the location that this connection token is scoped to. If specified the
        /// connection token will only be usable with readers assigned to that location, otherwise
        /// the connection token will be usable with all readers. Note that location scoping only
        /// applies to internet-connected readers. For more details, see <a
        /// href="https://docs.stripe.com/terminal/fleet/locations-and-zones?dashboard-or-api=api#connection-tokens">the
        /// docs on scoping connection tokens</a>.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public string Location { get; set; }
    }
}
