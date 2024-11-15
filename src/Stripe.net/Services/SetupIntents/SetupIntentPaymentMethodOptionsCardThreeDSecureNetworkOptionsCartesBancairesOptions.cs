// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsCartesBancairesOptions : INestedOptions
    {
        /// <summary>
        /// The cryptogram calculation algorithm used by the card Issuer's ACS to calculate the
        /// Authentication cryptogram. Also known as <c>cavvAlgorithm</c>. messageExtension:
        /// CB-AVALGO.
        /// One of: <c>0</c>, <c>1</c>, <c>2</c>, <c>3</c>, <c>4</c>, or <c>A</c>.
        /// </summary>
        [JsonProperty("cb_avalgo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cb_avalgo")]
#endif

        public string CbAvalgo { get; set; }

        /// <summary>
        /// The exemption indicator returned from Cartes Bancaires in the ARes. message extension:
        /// CB-EXEMPTION; string (4 characters) This is a 3 byte bitmap (low significant byte first
        /// and most significant bit first) that has been Base64 encoded.
        /// </summary>
        [JsonProperty("cb_exemption")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cb_exemption")]
#endif

        public string CbExemption { get; set; }

        /// <summary>
        /// The risk score returned from Cartes Bancaires in the ARes. message extension: CB-SCORE;
        /// numeric value 0-99.
        /// </summary>
        [JsonProperty("cb_score")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cb_score")]
#endif

        public long? CbScore { get; set; }
    }
}
