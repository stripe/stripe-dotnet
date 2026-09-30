// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationOutcomeDetailsNetworkDetails : StripeEntity<AuthenticationOutcomeDetailsNetworkDetails>
    {
        /// <summary>
        /// Contains details for Cartes Bancaires specific fields in the authentication outcomes.
        /// </summary>
        [JsonProperty("cartes_bancaires")]
        [STJS.JsonPropertyName("cartes_bancaires")]
        public AuthenticationOutcomeDetailsNetworkDetailsCartesBancaires CartesBancaires { get; set; }
    }
}
