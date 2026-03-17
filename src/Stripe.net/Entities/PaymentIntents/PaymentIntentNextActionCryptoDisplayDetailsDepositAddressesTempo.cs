// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesTempo : StripeEntity<PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesTempo>
    {
        /// <summary>
        /// Address of the deposit address.
        /// </summary>
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public string Address { get; set; }

        /// <summary>
        /// The token currencies supported on this network.
        /// </summary>
        [JsonProperty("supported_tokens")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supported_tokens")]
#endif
        public List<PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesTempoSupportedToken> SupportedTokens { get; set; }
    }
}
