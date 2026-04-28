// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IssuedTokenSellerDetailsOptions : INestedOptions
    {
        /// <summary>
        /// A unique id within a network that identifies a logical seller, usually this would be the
        /// unique merchant id.
        /// </summary>
        [JsonProperty("external_id")]
        [STJS.JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// A string that identifies the network that this SharedToken is being created for.
        /// </summary>
        [JsonProperty("network_business_profile")]
        [STJS.JsonPropertyName("network_business_profile")]
        public string NetworkBusinessProfile { get; set; }
    }
}
