// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionPermissions : StripeEntity<SessionPermissions>
    {
        /// <summary>
        /// Permissions for updating the Checkout Session.
        /// </summary>
        [JsonProperty("update")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("update")]
#endif
        public SessionPermissionsUpdate Update { get; set; }
    }
}
