// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolana : StripeEntity<PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolana>
    {
        /// <summary>
        /// Address of the deposit address.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// The token currencies supported on this network.
        /// </summary>
        [JsonProperty("supported_tokens")]
        [STJS.JsonPropertyName("supported_tokens")]
        public List<PaymentIntentNextActionCryptoDisplayDetailsDepositAddressesSolanaSupportedToken> SupportedTokens { get; set; }
    }
}
