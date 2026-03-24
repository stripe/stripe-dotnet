// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionShipping : StripeEntity<RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionShipping>
    {
        /// <summary>
        /// The shipping option.
        /// </summary>
        [JsonProperty("shipping_option")]
        [STJS.JsonPropertyName("shipping_option")]
        public string ShippingOption { get; set; }
    }
}
