// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionPermissions : StripeEntity<SessionPermissions>
    {
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
        [JsonProperty("update_shipping_details")]
        [STJS.JsonPropertyName("update_shipping_details")]
        public string UpdateShippingDetails { get; set; }
    }
}
