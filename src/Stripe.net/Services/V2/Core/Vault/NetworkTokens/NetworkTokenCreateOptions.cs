// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class NetworkTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// Raw card values used to provision the network token.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public NetworkTokenCreateCardOptions Card { get; set; }

        /// <summary>
        /// Private preview supports card only.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
