// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Connection Token is used by the Stripe Terminal SDK to connect to a reader.
    ///
    /// Related guide: <a href="https://docs.stripe.com/terminal/fleet/locations">Fleet
    /// management</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConnectionToken : StripeEntity<ConnectionToken>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The id of the location that this connection token is scoped to. Note that location
        /// scoping only applies to internet-connected readers. For more details, see <a
        /// href="https://docs.stripe.com/terminal/fleet/locations-and-zones?dashboard-or-api=api#connection-tokens">the
        /// docs on scoping connection tokens</a>.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Your application should pass this token to the Stripe Terminal SDK.
        /// </summary>
        [JsonProperty("secret")]
        [STJS.JsonPropertyName("secret")]
        public string Secret { get; set; }
    }
}
