// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionSellerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The network profile for the seller.
        /// </summary>
        [JsonProperty("network_profile")]
        [STJS.JsonPropertyName("network_profile")]
        public string NetworkProfile { get; set; }
    }
}
