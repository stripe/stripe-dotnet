// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// A Connection Token is used by the Stripe Terminal SDK to connect to a reader.
    ///
    /// Related guide: <a href="https://stripe.com/docs/terminal/fleet/locations">Fleet
    /// management</a>.
    /// </summary>
    public class ConnectionToken : StripeEntity<ConnectionToken>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The id of the location that this connection token is scoped to. Note that location
        /// scoping only applies to internet-connected readers. For more details, see <a
        /// href="https://docs.stripe.com/terminal/fleet/locations-and-zones?dashboard-or-api=api#connection-tokens">the
        /// docs on scoping connection tokens</a>.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public string Location { get; set; }

        /// <summary>
        /// Your application should pass this token to the Stripe Terminal SDK.
        /// </summary>
        [JsonProperty("secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secret")]
#endif
        public string Secret { get; set; }
    }
}
