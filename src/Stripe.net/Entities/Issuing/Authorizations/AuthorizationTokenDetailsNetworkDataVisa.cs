// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationTokenDetailsNetworkDataVisa : StripeEntity<AuthorizationTokenDetailsNetworkDataVisa>
    {
        /// <summary>
        /// A unique reference ID from the network to represent the card account number.
        /// </summary>
        [JsonProperty("card_reference_id")]
        [STJS.JsonPropertyName("card_reference_id")]
        public string CardReferenceId { get; set; }

        /// <summary>
        /// The network-unique identifier for the token.
        /// </summary>
        [JsonProperty("token_reference_id")]
        [STJS.JsonPropertyName("token_reference_id")]
        public string TokenReferenceId { get; set; }

        /// <summary>
        /// The ID of the entity requesting tokenization.
        /// </summary>
        [JsonProperty("token_requestor_id")]
        [STJS.JsonPropertyName("token_requestor_id")]
        public string TokenRequestorId { get; set; }

        /// <summary>
        /// Degree of risk associated with the token between <c>01</c> and <c>99</c>, with higher
        /// number indicating higher risk. A <c>00</c> value indicates the token was not scored by
        /// Visa.
        /// </summary>
        [JsonProperty("token_risk_score")]
        [STJS.JsonPropertyName("token_risk_score")]
        public string TokenRiskScore { get; set; }
    }
}
