// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthenticationOutcomeDetailsNetworkDetailsCartesBancaires : StripeEntity<AuthenticationOutcomeDetailsNetworkDetailsCartesBancaires>
    {
        /// <summary>
        /// The cryptogram calculation algorithm used by the card Issuer's ACS to calculate the
        /// Authentication cryptogram. Also known as cavvAlgorithm. ARes/RReq messageExtension:
        /// <c>CB-AVALGO</c>.
        /// </summary>
        [JsonProperty("avalgo")]
        [STJS.JsonPropertyName("avalgo")]
        public string Avalgo { get; set; }

        /// <summary>
        /// The exemption indicator returned from Cartes Bancaires in the ARes. This is a 3 byte
        /// bitmap (lowest significant byte first and most significant bit first) that has been
        /// Base64 encoded. String (4 characters). ARes message extension: <c>CB-EXEMPTION</c>.
        /// </summary>
        [JsonProperty("cb_exemption")]
        [STJS.JsonPropertyName("cb_exemption")]
        public string CbExemption { get; set; }

        /// <summary>
        /// The risk score returned from Cartes Bancaires in the ARes. Numeric value 0-99. ARes/RReq
        /// message extension: <c>CB-SCORE</c>.
        /// </summary>
        [JsonProperty("cb_score")]
        [STJS.JsonPropertyName("cb_score")]
        public string CbScore { get; set; }
    }
}
