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

        /// <summary>
        /// Determines which entity is allowed to update the line items.
        ///
        /// Default is <c>client_only</c>. Stripe Checkout client will automatically update the line
        /// items. If set to <c>server_only</c>, only your server is allowed to update the line
        /// items.
        ///
        /// When set to <c>server_only</c>, you must add the onLineItemsChange event handler when
        /// initializing the Stripe Checkout client and manually update the line items from your
        /// server using the Stripe API.
        /// One of: <c>client_only</c>, or <c>server_only</c>.
        /// </summary>
        [JsonProperty("update_line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("update_line_items")]
#endif
        public string UpdateLineItems { get; set; }

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
        [JsonProperty("update_shipping_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("update_shipping_details")]
#endif
        public string UpdateShippingDetails { get; set; }
    }
}
