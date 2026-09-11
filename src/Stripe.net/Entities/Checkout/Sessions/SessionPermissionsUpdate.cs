// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPermissionsUpdate : StripeEntity<SessionPermissionsUpdate>
    {
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
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public string LineItems { get; set; }

        /// <summary>
        /// Determines which entity is allowed to update the shipping details.
        ///
        /// Default is <c>client_only</c>. Stripe Checkout client will automatically update the
        /// shipping details. If set to <c>server_only</c>, only your server is allowed to update
        /// the shipping details.
        ///
        /// This parameter is only supported when <c>ui_mode=elements</c>.
        /// One of: <c>client_only</c>, or <c>server_only</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public string ShippingDetails { get; set; }
    }
}
