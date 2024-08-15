// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPermissionsUpdate : StripeEntity<SessionPermissionsUpdate>
    {
        /// <summary>
        /// Determines which entity is allowed to update the shipping details.
        ///
        /// Default is <c>client_only</c>. Stripe Checkout client will automatically update the
        /// shipping details. If set to <c>server_only</c>, only your server is allowed to update
        /// the shipping details.
        ///
        /// When set to <c>server_only</c>, you must add the onShippingDetailsChange event handler
        /// when initializing the Stripe Checkout client and manually update the shipping details
        /// from your server using the Stripe API.
        /// One of: <c>client_only</c>, or <c>server_only</c>.
        /// </summary>
        [JsonProperty("shipping_details")]
        public string ShippingDetails { get; set; }
    }
}
