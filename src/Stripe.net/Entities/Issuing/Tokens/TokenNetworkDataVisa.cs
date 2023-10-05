// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class TokenNetworkDataVisa : StripeEntity<TokenNetworkDataVisa>
    {
        /// <summary>
        /// A unique reference ID from Visa to represent the card account number.
        /// </summary>
        [JsonProperty("card_reference_id")]
        public string CardReferenceId { get; set; }

        /// <summary>
        /// The network-unique identifier for the token.
        /// </summary>
        [JsonProperty("token_reference_id")]
        public string TokenReferenceId { get; set; }

        /// <summary>
        /// The ID of the entity requesting tokenization, specific to Visa.
        /// </summary>
        [JsonProperty("token_requestor_id")]
        public string TokenRequestorId { get; set; }

        /// <summary>
        /// Degree of risk associated with the token between <c>01</c> and <c>99</c>, with higher
        /// number indicating higher risk. A <c>00</c> value indicates the token was not scored by
        /// Visa.
        /// </summary>
        [JsonProperty("token_risk_score")]
        public string TokenRiskScore { get; set; }
    }
}
