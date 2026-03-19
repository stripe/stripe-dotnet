// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionPermissionsOptions : INestedOptions
    {
        /// <summary>
        /// Permissions for updating the Checkout Session.
        /// </summary>
        [JsonProperty("update")]
        [STJS.JsonPropertyName("update")]
        public SessionPermissionsUpdateOptions Update { get; set; }

        /// <summary>
        /// Determines which entity is allowed to update the discounts (coupons or promotion codes)
        /// that apply to this session.
        ///
        /// Default is <c>client_only</c>. Stripe Checkout client will automatically handle discount
        /// updates. If set to <c>server_only</c>, only your server is allowed to update discounts.
        /// One of: <c>client_only</c>, or <c>server_only</c>.
        /// </summary>
        [JsonProperty("update_discounts")]
        [STJS.JsonPropertyName("update_discounts")]
        public string UpdateDiscounts { get; set; }

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
        [STJS.JsonPropertyName("update_line_items")]
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
        [STJS.JsonPropertyName("update_shipping_details")]
        public string UpdateShippingDetails { get; set; }
    }
}
