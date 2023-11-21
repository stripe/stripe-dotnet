// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsCardThreeDSecureOptions : INestedOptions
    {
        /// <summary>
        /// The <c>transStatus</c> returned from the card Issuer’s ACS in the ARes.
        /// One of: <c>A</c>, <c>C</c>, <c>I</c>, <c>N</c>, <c>R</c>, <c>U</c>, or <c>Y</c>.
        /// </summary>
        [JsonProperty("ares_trans_status")]
        public string AresTransStatus { get; set; }

        /// <summary>
        /// The cryptogram, also known as the "authentication value" (AAV, CAVV or AEVV). This value
        /// is 20 bytes, base64-encoded into a 28-character string. (Most 3D Secure providers will
        /// return the base64-encoded version, which is what you should specify here.).
        /// </summary>
        [JsonProperty("cryptogram")]
        public string Cryptogram { get; set; }

        /// <summary>
        /// The Electronic Commerce Indicator (ECI) is returned by your 3D Secure provider and
        /// indicates what degree of authentication was performed.
        /// One of: <c>01</c>, <c>02</c>, <c>05</c>, <c>06</c>, or <c>07</c>.
        /// </summary>
        [JsonProperty("electronic_commerce_indicator")]
        public string ElectronicCommerceIndicator { get; set; }

        /// <summary>
        /// Network specific 3DS fields. Network specific arguments require an explicit card brand
        /// choice. The parameter `payment_method_options.card.network`` must be populated
        /// accordingly.
        /// </summary>
        [JsonProperty("network_options")]
        public SetupIntentPaymentMethodOptionsCardThreeDSecureNetworkOptionsOptions NetworkOptions { get; set; }

        /// <summary>
        /// The challenge indicator (<c>threeDSRequestorChallengeInd</c>) which was requested in the
        /// AReq sent to the card Issuer's ACS. A string containing 2 digits from 01-99.
        /// </summary>
        [JsonProperty("requestor_challenge_indicator")]
        public string RequestorChallengeIndicator { get; set; }

        /// <summary>
        /// For 3D Secure 1, the XID. For 3D Secure 2, the Directory Server Transaction ID
        /// (dsTransID).
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// The version of 3D Secure that was performed.
        /// One of: <c>1.0.2</c>, <c>2.1.0</c>, or <c>2.2.0</c>.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
