// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionSellerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The network profile for the seller.
        /// </summary>
        [JsonProperty("network_profile")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network_profile")]
#endif
        public string NetworkProfile { get; set; }
    }
}
