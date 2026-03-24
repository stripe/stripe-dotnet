// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionFulfillmentDetailsSelectedFulfillmentOptionShippingOptions : INestedOptions
    {
        /// <summary>
        /// The shipping option identifier.
        /// </summary>
        [JsonProperty("shipping_option")]
        [STJS.JsonPropertyName("shipping_option")]
        public string ShippingOption { get; set; }
    }
}
