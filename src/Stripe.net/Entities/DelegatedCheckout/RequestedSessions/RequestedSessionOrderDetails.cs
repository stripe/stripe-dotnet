// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionOrderDetails : StripeEntity<RequestedSessionOrderDetails>
    {
        /// <summary>
        /// The seller's order identifier.
        /// </summary>
        [JsonProperty("order_id")]
        [STJS.JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// The URL to the order status.
        /// </summary>
        [JsonProperty("order_status_url")]
        [STJS.JsonPropertyName("order_status_url")]
        public string OrderStatusUrl { get; set; }
    }
}
