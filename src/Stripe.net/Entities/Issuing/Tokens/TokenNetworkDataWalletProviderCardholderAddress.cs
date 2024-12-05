// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenNetworkDataWalletProviderCardholderAddress : StripeEntity<TokenNetworkDataWalletProviderCardholderAddress>
    {
        /// <summary>
        /// The street address of the cardholder tokenizing the card.
        /// </summary>
        [JsonProperty("line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line1")]
#endif
        public string Line1 { get; set; }

        /// <summary>
        /// The postal code of the cardholder tokenizing the card.
        /// </summary>
        [JsonProperty("postal_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("postal_code")]
#endif
        public string PostalCode { get; set; }
    }
}
