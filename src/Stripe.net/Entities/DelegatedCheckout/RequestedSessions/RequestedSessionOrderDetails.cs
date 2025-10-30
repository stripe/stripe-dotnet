// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionOrderDetails : StripeEntity<RequestedSessionOrderDetails>
    {
        /// <summary>
        /// The URL to the order status.
        /// </summary>
        [JsonProperty("order_status_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order_status_url")]
#endif
        public string OrderStatusUrl { get; set; }

        /// <summary>
        /// The seller's order identifier.
        /// </summary>
        [JsonProperty("order_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("order_id")]
#endif
        public string OrderId { get; set; }
    }
}
