// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class NetworkTokenCreateFromCredentialOptions : BaseOptions
    {
        /// <summary>
        /// The existing Stripe card reference to provision or resolve.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public NetworkTokenCreateFromCredentialCardOptions Card { get; set; }

        /// <summary>
        /// Private preview supports card only.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
