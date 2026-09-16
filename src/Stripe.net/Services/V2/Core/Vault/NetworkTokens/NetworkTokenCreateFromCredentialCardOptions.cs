// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class NetworkTokenCreateFromCredentialCardOptions : INestedOptions
    {
        /// <summary>
        /// The optional origin attestation for the referenced card.
        /// </summary>
        [JsonProperty("origin")]
        [STJS.JsonPropertyName("origin")]
        public string Origin { get; set; }

        /// <summary>
        /// A supported v2 Card ID or v1 PaymentMethod ID of type card.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
