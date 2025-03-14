// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenNetworkDataVisa : StripeEntity<TokenNetworkDataVisa>
    {
        /// <summary>
        /// A unique reference ID from Visa to represent the card account number.
        /// </summary>
        [JsonProperty("card_reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_reference_id")]
#endif
        public string CardReferenceId { get; set; }

        /// <summary>
        /// The network-unique identifier for the token.
        /// </summary>
        [JsonProperty("token_reference_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_reference_id")]
#endif
        public string TokenReferenceId { get; set; }

        /// <summary>
        /// The ID of the entity requesting tokenization, specific to Visa.
        /// </summary>
        [JsonProperty("token_requestor_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_requestor_id")]
#endif
        public string TokenRequestorId { get; set; }

        /// <summary>
        /// Degree of risk associated with the token between <c>01</c> and <c>99</c>, with higher
        /// number indicating higher risk. A <c>00</c> value indicates the token was not scored by
        /// Visa.
        /// </summary>
        [JsonProperty("token_risk_score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token_risk_score")]
#endif
        public string TokenRiskScore { get; set; }
    }
}
