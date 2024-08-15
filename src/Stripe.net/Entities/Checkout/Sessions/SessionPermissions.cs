// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPermissions : StripeEntity<SessionPermissions>
    {
        /// <summary>
        /// Permissions for updating the Checkout Session.
        /// </summary>
        [JsonProperty("update")]
        public SessionPermissionsUpdate Update { get; set; }
    }
}
