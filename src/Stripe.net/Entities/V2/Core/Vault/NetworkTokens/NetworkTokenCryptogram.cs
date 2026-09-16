// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class NetworkTokenCryptogram : StripeEntity<NetworkTokenCryptogram>
    {
        /// <summary>
        /// The electronic commerce indicator associated with the cryptogram.
        /// </summary>
        [JsonProperty("eci")]
        [STJS.JsonPropertyName("eci")]
        public string Eci { get; set; }

        /// <summary>
        /// The cryptogram type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The cryptogram value.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
